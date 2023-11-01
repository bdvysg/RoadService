

using RoadService.Classes;
using RoadService.Repository;

namespace RoadService
{
    public partial class Form1 : Form
    {
        RoadServiceDBContext dbContext;
        UnitOfWork unitOfWork;

        public Form1()
        {
            InitializeComponent();
            dbContext = new RoadServiceDBContext();
            unitOfWork = new UnitOfWork(dbContext);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test();
            string a = "";
            foreach (var item in unitOfWork.Address.GetAll().ToList())
            {
                a += item.Name + "\n";
            }
            label1.Text = a;
        }

        private void Test()
        {
            foreach (var item in unitOfWork.Address.GetAll().ToList())
            {
                item.Name = item.Name + " updated";
                unitOfWork.Address.Update(item);
            }
            unitOfWork.Save();
        }
    }
}
