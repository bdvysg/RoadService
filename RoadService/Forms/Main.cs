using RoadService.Forms;
using RoadService.Repository;
using Task = RoadService.Classes.Task;

namespace RoadService
{
    public partial class Main : Form
    {
        RoadServiceDBContext dbContext;
        UnitOfWork unitOfWork;

        public Main()
        {
            InitializeComponent();
            dbContext = new RoadServiceDBContext();
            unitOfWork = new UnitOfWork(dbContext);
            Refresh();
        }

        public void Refresh()
        {
            var tasks = unitOfWork.Task.GetAll().Where(u => !u.isClosed);
            dgv.DataSource = tasks.Select(item => new
            {
                ����� = item.Name,
                ���� = item.Description,
                ������� = item.TimeStart,
                ��������� = item.TimeEnd,
                ֳ�� = item.PlannedPrice,

            }).ToList();
        }

        private void ������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTask form = new CreateTask();
            form.Show();
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertData form = new InsertData();
            form.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Task selectedObject = unitOfWork.Task.Get(u => u.Name == dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (selectedObject != null)
                {
                    CloseTask form = new CloseTask(selectedObject);
                    form.Show();
                }
            }
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task task = unitOfWork.Task.Get(t => t.Name == dgv.CurrentRow.Cells[0].Value.ToString());
            if(task != null)
            {
                unitOfWork.Task.Remove(task);
                unitOfWork.Save();
            }
            Refresh();
        }
    }
}
