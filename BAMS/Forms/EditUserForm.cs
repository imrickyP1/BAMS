using BAMS.Repositories;
using System.Data;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace BAMS.Forms
{
    public partial class EditUserForm : Form
    {
        private int userId = 0;

        public EditUserForm(int id)
        {
            InitializeComponent();

            userId = id;

            InitializeComboBoxes();
            InitializePlaceholders();

            LoadUserData();
        }

        private void InitializeComboBoxes()
        {
            cmbGender.Items.Clear();
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");

            cmbPosition.Items.Clear();
            cmbPosition.Items.Add("Admin");
            cmbPosition.Items.Add("Staff");
            cmbPosition.Items.Add("Official");

            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPosition.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbGender.SelectedIndex = -1;
            cmbGender.Text = "Select Gender";
            cmbGender.ForeColor = Color.Gray;

            cmbPosition.SelectedIndex = -1;
            cmbPosition.Text = "Select Position";
            cmbPosition.ForeColor = Color.Gray;

            cmbGender.Enter += RemoveComboPlaceholder;
            cmbGender.Leave += AddComboPlaceholder;

            cmbPosition.Enter += RemoveComboPlaceholder;
            cmbPosition.Leave += AddComboPlaceholder;
        }

        private void InitializePlaceholders()
        {
            SetPlaceholder(txtFullName, "Full Name");
            SetPlaceholder(txtUsername, "Username");
            SetPlaceholder(txtPassword, "Password");
        }

        private void SetPlaceholder(TextBox box, string text)
        {
            box.Text = text;
            box.ForeColor = Color.Gray;

            box.Enter += (s, e) =>
            {
                if (box.Text == text)
                {
                    box.Text = "";
                    box.ForeColor = Color.Black;
                }
            };

            box.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(box.Text))
                {
                    box.Text = text;
                    box.ForeColor = Color.Gray;
                }
            };
        }

        private void RemoveComboPlaceholder(object? sender, EventArgs e)
        {
            if (sender is ComboBox cmb)
            {
                if (cmb.ForeColor == Color.Gray)
                    cmb.ForeColor = Color.Black;
            }
        }

        private void AddComboPlaceholder(object? sender, EventArgs e)
        {
            if (sender is ComboBox cmb)
            {
                if (cmb.SelectedIndex == -1)
                {
                    cmb.Text = cmb == cmbGender ? "Select Gender" : "Select Position";
                    cmb.ForeColor = Color.Gray;
                }
            }
        }

        private void LoadUserData()
        {
            UserRepository repo = new UserRepository();
            DataTable dt = repo.GetUserById(userId);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                txtFullName.Text = row["FullName"].ToString();
                txtFullName.ForeColor = Color.Black;

                cmbGender.SelectedItem = row["Gender"].ToString();
                cmbGender.ForeColor = Color.Black;

                cmbPosition.SelectedItem = row["Position"].ToString();
                cmbPosition.ForeColor = Color.Black;

                txtUsername.Text = row["Username"].ToString();
                txtUsername.ForeColor = Color.Black;

                txtPassword.Text = row["Password"].ToString();
                txtPassword.ForeColor = Color.Black;
            }
            else
            {
                MessageBox.Show("User not found.");
                this.Close();
            }
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            if (txtFullName.ForeColor == Color.Gray ||
                txtUsername.ForeColor == Color.Gray ||
                txtPassword.ForeColor == Color.Gray ||
                cmbGender.SelectedIndex == -1 ||
                cmbPosition.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string gender = cmbGender.SelectedItem?.ToString() ?? string.Empty;
            string position = cmbPosition.SelectedItem?.ToString() ?? string.Empty;

            UserRepository repo = new UserRepository();

            repo.UpdateUser(
                userId,
                txtFullName.Text.Trim(),
                gender,
                position,
                txtUsername.Text.Trim(),
                txtPassword.Text.Trim()
            );

            MessageBox.Show("User Updated Successfully!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}