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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AdminRepository repo = new AdminRepository();

            bool isValid = repo.Login(txtUsername.Text, txtPassword.Text);

            if (isValid)
            {
                DashboardForm dashboard = new DashboardForm();
                dashboard.FormClosed += (s, args) =>
                {
                    this.Show();
                };

                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
