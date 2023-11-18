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

            dtp1.Format = DateTimePickerFormat.Custom;
            dtp1.CustomFormat = "dd.MM.yyyy HH:mm";
            dpt2.Format = DateTimePickerFormat.Custom;
            dpt2.CustomFormat = "dd.MM.yyyy HH:mm";
            dtp1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0);
            dpt2.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0);
        }

        private void btnCheckAddress_Click(object sender, EventArgs e)
        {
            if (addressList.IsValidAddress(txtAddress.Text.Trim().Normalize()))
            {
                task.Address = txtAddress.Text.Trim();
                rtxtDescription.Enabled = true;
                dtp1.Enabled = true;
                dpt2.Enabled = true;
                btnFilter.Enabled = true;
                MessageBox.Show("Дана адреса обслуговується");
            }
            else
            {
                txtAddress.Text = string.Empty;
                MessageBox.Show("Дана адреса не обслуговується. Перевірте правильність адреси та спробуйте ще раз");
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var date1 = dtp1.Value;
            date1 = new DateTime(date1.Year, date1.Month, date1.Day, date1.Hour, 0, 0);

            var date2 = dpt2.Value;
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


            cmbEmployees.Items.Clear();
            cmbResources.Items.Clear();

            cmbEmployees.Items.AddRange(employeeTimeTable.GetEmployees(date1, date2).ToArray());
            cmbResources.Items.AddRange(resourceTimeTable.GetResources(date1, date2).ToArray());

            task.TimeStart = date1;
            task.TimeEnd = date2;

            cmbEmployees.Enabled = true;
            cmbResources.Enabled = true;
            txtCount.Enabled = true;
            btnAddEmployee.Enabled = true;
            btnAddResources.Enabled = true;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            var emp = cmbEmployees.SelectedItem as Employee;

            task.Employees.Add(emp);
            dgvEmployees.DataSource = task.Employees.Select(item => new
            {
                Імя = item.FirstName,
                Прізвище = item.LastName,
                Посада = item.Position,
                Ставка = item.WagePerHour
            }).ToList();

            cmbEmployees.Items.Remove(cmbEmployees.SelectedItem as Employee);

            if (task.Employees.Count > 0 && task.PlannedResources.Count > 0)
            {
                btnCalcPrice.Enabled = true;
            }
        }

        private void btnAddResources_Click(object sender, EventArgs e)
        {
            int count = int.Parse(txtCount.Text);
            txtCount.Text = "1";
            int max_count = unitOfWork.Stock.Get(u => u.Resource.Id == (cmbResources.SelectedItem as Resource).Id).Count;
            var ress = unitOfWork.Resource.GetAll();

            if (count > max_count)
            {
                MessageBox.Show($"На складі доступно лише {max_count} одиниць!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            for (int i = 0; i < count; i++)
            {
                task.PlannedResources.Add(ress.First(u => u.Id == (cmbResources.SelectedItem as Resource).Id));
            }

            dgvResources.DataSource = task.PlannedResources.GroupBy(x => x)
                                .Select(group => new
                                {
                                    Назва = group.Key.Name,
                                    Ціна = group.Key.Price,
                                    Кількість = group.Count()
                                })
                                .ToList();

            if (task.Employees.Count > 0 && task.PlannedResources.Count > 0)
            {
                btnCalcPrice.Enabled = true;
            }
        }

        private void btnCalcPrice_Click(object sender, EventArgs e)
        {
            task.PlannedPrice = Calc.GetPlannedPrice(task);
            label10.Text = "Орієнтована ціна - " + task.PlannedPrice.ToString() + " грн.";
            btnCreate.Enabled = true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            task.isClosed = false;
            task.Status = "Очікується до виконання";
            task.Name = txtName.Text;
            task.Description = rtxtDescription.Text;

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
            if (cmbResources.SelectedItem is Material)
            {
                lblCount.Text = "Кількість ( " + (cmbResources.SelectedItem as Material).UnitOfMeasure + " )";
            }
            else
            {
                lblCount.Text = "Кількість";
            }
        }
    }
}
