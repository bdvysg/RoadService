

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
        }

        private void ‰Ó‰‡ÚËÕÓ‚Â«‡‚‰‡ÌÌˇToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTask form = new CreateTask();
            form.Show();
            this.Hide();
        }

        private void ‰Ó‰‡ÚËƒ‡Ì≥ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertData form = new InsertData();
            form.Show();
            this.Hide();
        }
    }
}
