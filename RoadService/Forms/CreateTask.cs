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

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0);
            dateTimePicker2.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0);
        }

        // Перевірка обслуговування адреси
        private void button1_Click(object sender, EventArgs e)
        {
            if (addressList.IsValidAddress(textBox3.Text.Trim().Normalize()))
            {
                task.Address = textBox3.Text.Trim();
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

            int res = DateTime.Compare(date1, date2);
            if (res == 0 || res > 0)
            {
                MessageBox.Show("Дата початку не може бути меншою або дорівнювати даті закінчення завдання");
                return;
            }

            comboBox1.Items.AddRange(employeeTimeTable.GetEmployees(date1, date2).Select(u => u.FirstName + " " + u.LastName).ToArray());
            comboBox2.Items.AddRange(resourceTimeTable.GetResources(date1, date2).Select(u => u.Name).ToArray());
        }
    }
}
