using RoadService.Classes;
using RoadService.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Task = RoadService.Classes.Task;

namespace RoadService.Forms
{
    public partial class CloseTask : Form
    {
        private UnitOfWork unitOfWork;
        private AddressList addressList;
        private ResourceTimeTable resourceTimeTable;
        private EmployeeTimeTable employeeTimeTable;
        private Task task;


        public CloseTask(Task task)
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork(new RoadServiceDBContext());
            addressList = new AddressList(unitOfWork);
            resourceTimeTable = new ResourceTimeTable(unitOfWork);
            employeeTimeTable = new EmployeeTimeTable(unitOfWork);

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0);
            dateTimePicker2.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0);

            this.task = task;
            textBox1.Text = task.Name;
            textBox3.Text = task.Address;
            textBox5.Text = task.PlannedPrice.ToString();
            richTextBox1.Text = task.Description;
            dateTimePicker1.Value = task.TimeStart;
            dateTimePicker2.Value = task.TimeEnd;

            var res = task.PlannedResources.Select(u => unitOfWork.Resource.Get(e => e.Id == u.Id)).Where(u => u is Material).Distinct().ToArray();
            comboBox2.Items.AddRange(res);

            task.ActualResources = task.PlannedResources.Select(u => unitOfWork.Resource.Get(e => e.Id == u.Id)).Where(u => u is not Material).ToList();

            UpdateTables();
        }

        public void UpdateTables()
        {
            dataGridView1.DataSource = task.Employees;

            var gropus = task.PlannedResources.GroupBy(x => x.Name)
                     .Select(group => new
                     {
                         Value = group.Key,
                         Count = group.Count()
                     })
                     .ToList();

            dataGridView2.DataSource = gropus;
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            var gropus = task.PlannedResources.GroupBy(x => x.Id)
                     .Select(group => new
                     {
                         Value = group.Key,
                         Count = group.Count()
                     })
                     .ToList();
            textBox2.Text = gropus.FirstOrDefault(x => x.Value == (comboBox2.SelectedItem as Resource).Id).Count.ToString();
            textBox4.Text = textBox2.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            task.ActualPrice = Calc.GetActualPrice(task);
            textBox6.Text = task.ActualPrice.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = int.Parse(textBox4.Text);
            textBox4.Text = textBox2.Text;
            int max_count = unitOfWork.Stock.Get(u => u.Resource.Id == (comboBox2.SelectedItem as Resource).Id).Count;
            var ress = unitOfWork.Resource.GetAll();

            if (count > max_count + int.Parse(textBox4.Text))
            {
                MessageBox.Show($"На складі доступно лише {max_count - int.Parse(textBox4.Text)} одиниць!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < count; i++)
            {
                task.ActualResources.Add(ress.First(u => u.Id == (comboBox2.SelectedItem as Resource).Id));
            }
            comboBox2.Items.Remove(comboBox2.SelectedItem as Resource);

            if (comboBox2.Items.Count == 0)
            {
                comboBox2.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox4.Text = string.Empty;
                textBox4.ReadOnly = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            task.Status = "Завершено";
            task.isClosed = true;
            unitOfWork.Task.Update(task);
            unitOfWork.Save();
            this.Close();
        }
    }
}
