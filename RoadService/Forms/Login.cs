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

namespace RoadService
{
    public partial class Login : Form
    {
        UnitOfWork unitOfWork;

        public Login()
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork(new RoadServiceDBContext());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Логін або пароль не можуть бути пустими");
                return;
            }

            List<User> users = unitOfWork.Users.GetAll(includeProperties: "Employee").ToList();

            if (users.Any(u => u.Username == textBox1.Text.Trim() && u.Password == textBox2.Text.Trim()))
            {
                Main form = new Main();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправльний логін або пароль");
            }
        }
    }
}
