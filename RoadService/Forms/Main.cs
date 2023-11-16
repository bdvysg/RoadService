

using RoadService.Classes;
using RoadService.Forms;
using RoadService.Repository;
using System.Security.AccessControl;
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
            var tasks = unitOfWork.Task.GetAll().Where(u => !u.isClosed);
            dataGridView1.DataSource = tasks;
        }

        private void äîäàòèÍîâåÇàâäàííÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTask form = new CreateTask();
            form.Show();
        }

        private void äîäàòèÄàí³ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertData form = new InsertData();
            form.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void îíîâèòèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*var tasks = unitOfWork.Task.GetAll().ToList();
            var res_list = tasks.Select(t=> t.PlannedResources.Select(u=> u.Id).ToList()).ToList();
            var res = unitOfWork.Resource.GetAll();

             for (int i = 0; i < tasks.Count(); i++)
            {
                var fin_res = new List<Resource>();
                foreach (var resrc in res_list)
                {
                    fin_res.Add(res.First(r => resrc.Contains(r.Id)));
                }
                tasks[i].PlannedResources = fin_res;
            }*/
            var tasks = unitOfWork.Task.GetAll().Where(u => !u.isClosed).ToList();
            dataGridView1.DataSource = tasks;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Task selectedObject = dataGridView1.Rows[e.RowIndex].DataBoundItem as Task;
                if (selectedObject != null)
                {
                    CloseTask form = new CloseTask(selectedObject);
                    form.Show();
                }
            }
        }
    }
}
