

namespace RoadService
{
    public partial class Form1 : Form
    {
        RoadServiceDBContext dbContext;

        public Form1()
        {
            InitializeComponent();
            dbContext = new RoadServiceDBContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = dbContext.Database.ProviderName;
        }
    }
}
