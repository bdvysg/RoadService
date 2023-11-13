

using RoadService.Classes;
using RoadService.Forms;
using RoadService.Repository;

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
            var tasks = unitOfWork.Task.GetAll();
            dataGridView1.DataSource = tasks;
        }

        private void ‰Ó‰‡ÚËÕÓ‚Â«‡‚‰‡ÌÌˇToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTask form = new CreateTask();
            form.Show();
        }

        private void ‰Ó‰‡ÚËƒ‡Ì≥ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertData form = new InsertData();
            form.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ÓÌÓ‚ËÚËToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tasks = unitOfWork.Task.GetAll();
            dataGridView1.DataSource = tasks;
        }
    }
}
