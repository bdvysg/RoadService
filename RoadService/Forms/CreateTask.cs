using RoadService.Classes;
using RoadService.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Task = RoadService.Classes.Task;

namespace RoadService.Forms
{
    public partial class CreateTask : Form
    {
        private UnitOfWork unitOfWork;
        private AddressList addressList;
        private ResourceTimeTable resourceTimeTable;
        private EmployeeTimeTable employeeTimeTable;
        private Task task;

        public CreateTask()
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork(new RoadServiceDBContext());
            addressList = new AddressList(unitOfWork);
            task = new Task();
            task.Employees = new List<Employee>();
            task.PlannedResources = new List<Resource>();

            resourceTimeTable = new ResourceTimeTable(unitOfWork);
            employeeTimeTable = new EmployeeTimeTable(unitOfWork);

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0);
            dateTimePicker2.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (addressList.IsValidAddress(textBox3.Text.Trim().Normalize()))
            {
                task.Address = textBox3.Text.Trim();
                richTextBox1.Enabled = true;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                button5.Enabled = true;
                MessageBox.Show("Дана адреса обслуговується");
            }
            else
            {
                textBox3.Text = string.Empty;
                MessageBox.Show("Дана адреса не обслуговується. Перевірте правильність адреси та спробуйте ще раз");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var date1 = dateTimePicker1.Value;
            date1 = new DateTime(date1.Year, date1.Month, date1.Day, date1.Hour, 0, 0);

            var date2 = dateTimePicker2.Value;
            date2 = new DateTime(date2.Year, date2.Month, date2.Day, date2.Hour, 0, 0);

            if (DateTime.Now >= date1)
            {
                MessageBox.Show("Дата початку не може бути меншою або дорівнювати сьогодішній даті");
                return;
            }

            if (DateTime.Now >= date2)
            {
                MessageBox.Show("Дата кінця не може бути меншою або дорівнювати сьогоднішній даті");
                return;
            }

            if (date1 >= date2)
            {
                MessageBox.Show("Дата початку не може бути меншою або дорівнювати даті закінчення завдання");
                return;
            }


            comboBox1.Items.Clear();
            comboBox2.Items.Clear();

            comboBox1.Items.AddRange(employeeTimeTable.GetEmployees(date1, date2).ToArray());
            comboBox2.Items.AddRange(resourceTimeTable.GetResources(date1, date2).ToArray());

            task.TimeStart = date1;
            task.TimeEnd = date2;

            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            textBox4.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            task.Employees.Add(comboBox1.SelectedItem as Employee);
            comboBox1.Items.Remove(comboBox1.SelectedItem as Employee);

            if (task.Employees.Count > 0 || task.PlannedResources.Count > 0)
            {
                button6.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = int.Parse(textBox4.Text);
            textBox4.Text = "1";
            int max_count = unitOfWork.Stock.Get(u => u.Resource.Id == (comboBox2.SelectedItem as Resource).Id).Count;
            var ress = unitOfWork.Resource.GetAll();

            if (count > max_count)
            {
                MessageBox.Show($"На складі доступно лише {max_count} одиниць!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            for (int i = 0; i < count; i++)
            {
                task.PlannedResources.Add(ress.First(u => u.Id == (comboBox2.SelectedItem as Resource).Id));
            }

            if (task.Employees.Count > 0 || task.PlannedResources.Count > 0)
            {
                button6.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            task.PlannedPrice = Calc.GetPlannedPrice(task);
            label10.Text = "Орієнтована ціна - " + task.PlannedPrice.ToString() + " грн.";
            button2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            task.isClosed = false;
            task.Status = "Очікується до виконання";
            task.Name = textBox1.Text;
            task.Description = richTextBox1.Text;

            if (string.IsNullOrEmpty(task.Name))
            {
                MessageBox.Show("Назва завдання не може бути пустою", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(task.Description))
            {
                MessageBox.Show("Опис завдання не може бути пустим", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (task.Address == null)
            {
                MessageBox.Show("Адреса не підтверджена", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (task.TimeStart == null || task.TimeEnd == null)
            {
                MessageBox.Show("Підтвердіть обрану дату", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (task.PlannedPrice == null || task.PlannedPrice == 0)
            {
                MessageBox.Show("Запланована сума не розрахована", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var emp in task.Employees)
            {
                employeeTimeTable.ReserveEmployee(emp, task.TimeStart, task.TimeEnd);
            }

            var groupedCounts = task.PlannedResources.GroupBy(x => x)
                                 .Select(group => new
                                 {
                                     Value = group.Key,
                                     Count = group.Count()
                                 })
                                 .ToList();

            foreach (var group in groupedCounts)
            {
                resourceTimeTable.ReserveResource(group.Value, group.Count, task.TimeStart, task.TimeEnd);
            }
            unitOfWork.Task.Add(task);
            unitOfWork.Save();
            this.Close();
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem is Material)
            {
                label9.Text = "Кількість ( " + (comboBox2.SelectedItem as Material).UnitOfMeasure + " )";
            }
            else
            {
                label9.Text = "Кількість";
            }
        }
    }
}
