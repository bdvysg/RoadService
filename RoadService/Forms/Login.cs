using RoadService.Classes;
using RoadService.Repository;

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var login = txtBLogin.Text.Trim();
            var password = txtBPassword.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Логін або пароль не можуть бути пустими");
                return;
            }

            List<User> users = unitOfWork.Users.GetAll(includeProperties: "Employee").ToList();

            if (users.Any(u => u.Username == login && u.Password == password))
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
