using BAMS.Forms;
using BAMS.Repositories;


namespace BAMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string adminUsername = "admin";
            string adminPassword = "admin123";

            if (txtUsername.Text == adminUsername && txtPassword.Text == adminPassword)
            {
                DashboardForm dashboardForm = new DashboardForm();
                dashboardForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }
    }
}
