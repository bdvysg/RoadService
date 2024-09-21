using RoadService.Classes;
using RoadService.Repository;
using System.Data;
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

            DateManager.SetUpDateTimePicker(dtp1);
            DateManager.SetUpDateTimePicker(dtp2);

            this.task = task;
            txtName.Text = task.Name;
            txtAddress.Text = task.Address;
            txtPlannedPrice.Text = task.PlannedPrice.ToString();
            txtDesc.Text = task.Description;
            dtp1.Value = task.TimeStart;
            dtp2.Value = task.TimeEnd;

            var res = task.PlannedResources.Select(u => unitOfWork.Resource.Get(e => e.Id == u.Id)).Where(u => u is Material).Distinct().ToArray();
            cmbUsedRes.Items.AddRange(res);

            task.ActualResources = task.PlannedResources.Select(u => unitOfWork.Resource.Get(e => e.Id == u.Id)).Where(u => u is not Material).ToList();

            UpdateTables();
        }

        public void UpdateTables()
        {
            dgv1.DataSource = task.Employees.Select(item => new
            {
                Імя = item.FirstName,
                Прізвище = item.LastName,
                Посада = item.Position,
                Ставка = item.WagePerHour
            }).ToList();

            dgv2.DataSource = task.PlannedResources.GroupBy(x => x.Name)
                     .Select(group => new
                     {
                         Назва = group.Key,
                         Кількість = group.Count()
                     })
                     .ToList();
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
            txtPlannedCount.Text = gropus.FirstOrDefault(x => x.Value == (cmbUsedRes.SelectedItem as Resource).Id).Count.ToString();
            txtActualCount.Text = txtPlannedCount.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            task.ActualPrice = Calc.GetActualPrice(task);
            txtActualPrice.Text = task.ActualPrice.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = int.Parse(txtActualCount.Text);
            txtActualCount.Text = txtPlannedCount.Text;
            int max_count = unitOfWork.Stock.Get(u => u.Resource.Id == (cmbUsedRes.SelectedItem as Resource).Id).Count;
            var ress = unitOfWork.Resource.GetAll();

            if (count > max_count + int.Parse(txtActualCount.Text))
            {
                MessageBox.Show($"На складі доступно лише {max_count - int.Parse(txtActualCount.Text)} одиниць!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < count; i++)
            {
                task.ActualResources.Add(ress.First(u => u.Id == (cmbUsedRes.SelectedItem as Resource).Id));
            }
            cmbUsedRes.Items.Remove(cmbUsedRes.SelectedItem as Resource);

            if (cmbUsedRes.Items.Count == 0)
            {
                cmbUsedRes.Text = string.Empty;
                txtPlannedCount.Text = string.Empty;
                txtActualCount.Text = string.Empty;
                txtActualCount.ReadOnly = true;
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
