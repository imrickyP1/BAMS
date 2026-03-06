//using BAMS.Repositories;
//using System;
//using System.Data;
//using System.Windows.Forms;
//using System.Drawing;

//namespace BAMS.Forms
//{
//    public partial class AddUserForm : Form
//    {
//        private int userId = 0;

//        public AddUserForm(int id = 0)
//        {
//            InitializeComponent();

//            userId = id;

//            InitializeComboBoxes();
//            InitializePlaceholders();

//            if (userId != 0)
//            {
//                LoadUserData();
//            }
//        }

//        private void InitializeComboBoxes()
//        {
//            cmbGender.Items.Clear();
//            cmbGender.Items.Add("Select Gender");
//            cmbGender.Items.Add("Male");
//            cmbGender.Items.Add("Female");

//            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
//            cmbGender.SelectedIndex = 0;

//            cmbPosition.Items.Clear();
//            cmbPosition.Items.Add("Select Position");
//            cmbPosition.Items.Add("Admin");
//            cmbPosition.Items.Add("Staff");
//            cmbPosition.Items.Add("Official");

//            cmbPosition.DropDownStyle = ComboBoxStyle.DropDownList;
//            cmbPosition.SelectedIndex = 0;
//        }

//        private void InitializePlaceholders()
//        {
//            SetPlaceholder(txtFullName, "Full Name");
//            SetPlaceholder(txtUsername, "Username");
//            SetPlaceholder(txtPassword, "Password");
//        }

//        private void SetPlaceholder(TextBox box, string text)
//        {
//            box.Text = text;
//            box.ForeColor = Color.Gray;

//            box.Enter += (sender, e) =>
//            {
//                if (box.Text == text)
//                {
//                    box.Text = "";
//                    box.ForeColor = Color.Black;

//                    if (box == txtPassword)
//                        txtPassword.UseSystemPasswordChar = true;
//                }
//            };

//            box.Leave += (sender, e) =>
//            {
//                if (string.IsNullOrWhiteSpace(box.Text))
//                {
//                    box.UseSystemPasswordChar = false;
//                    box.Text = text;
//                    box.ForeColor = Color.Gray;
//                }
//            };
//        }

//        private void LoadUserData()
//        {
//            UserRepository repo = new UserRepository();
//            DataTable dt = repo.GetUserById(userId);

//            if (dt.Rows.Count > 0)
//            {
//                DataRow row = dt.Rows[0];

//                txtFullName.ForeColor = Color.Black;
//                cmbGender.ForeColor = Color.Black;
//                cmbPosition.ForeColor = Color.Black;
//                txtUsername.ForeColor = Color.Black;
//                txtPassword.ForeColor = Color.Black;

//                txtFullName.Text = row["FullName"].ToString();
//                cmbGender.SelectedItem = row["Gender"].ToString();
//                cmbPosition.SelectedItem = row["Position"].ToString();
//                txtUsername.Text = row["Username"].ToString();
//                txtPassword.Text = row["Password"].ToString();

//                txtPassword.UseSystemPasswordChar = true;
//            }
//            else
//            {
//                MessageBox.Show("User not found.");
//            }
//        }

//        private void btnSave_Click(object sender, EventArgs e)
//        {
//            if (txtFullName.ForeColor == Color.Gray ||
//                cmbGender.ForeColor == Color.Gray ||
//                cmbPosition.ForeColor == Color.Gray ||
//                txtUsername.ForeColor == Color.Gray ||
//                txtPassword.ForeColor == Color.Gray ||
//                cmbGender.SelectedIndex == -1 ||
//                cmbPosition.SelectedIndex == -1)
//            {
//                MessageBox.Show("Please fill in all fields properly.");
//                return;
//            }

//            UserRepository repo = new UserRepository();

//            if (userId == 0)
//            {
//                repo.AddUser(
//                    txtFullName.Text,
//                    cmbGender.Text,
//                    cmbPosition.Text,
//                    txtUsername.Text,
//                    txtPassword.Text
//                );

//                MessageBox.Show("User added successfully!");
//            }
//            else
//            {
//                repo.UpdateUser(
//                    userId,
//                    txtFullName.Text,
//                    cmbGender.Text,
//                    cmbPosition.Text,
//                    txtUsername.Text,
//                    txtPassword.Text
//                );

//                MessageBox.Show("User updated successfully!");
//            }

//            this.Close();
//        }
//    }
//}

using BAMS.Repositories;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BAMS.Forms
{
    public partial class AddUserForm : Form
    {
        private int userId;

        public AddUserForm(int id = 0)
        {
            InitializeComponent();

            userId = id;

            SetupComboBoxes();
            SetupPlaceholders();

            if (userId != 0)
                LoadUserData();
        }

        // =============================
        // INITIALIZATION
        // =============================

        private void SetupComboBoxes()
        {
            cmbGender.Items.Clear();
            cmbGender.Items.AddRange(new object[]
            {
                "Select Gender",
                "Male",
                "Female"
            });

            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.SelectedIndex = 0;

            cmbPosition.Items.Clear();
            cmbPosition.Items.AddRange(new object[]
            {
                "Select Position",
                "Admin",
                "Staff",
                "Official"
            });

            cmbPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPosition.SelectedIndex = 0;
        }

        private void SetupPlaceholders()
        {
            SetPlaceholder(txtFullName, "Full Name");
            SetPlaceholder(txtUsername, "Username");
            SetPlaceholder(txtPassword, "Password");
        }

        // =============================
        // PLACEHOLDER SYSTEM
        // =============================

        private void SetPlaceholder(TextBox box, string placeholder)
        {
            box.Text = placeholder;
            box.ForeColor = Color.Gray;

            box.Enter += (s, e) =>
            {
                if (box.Text == placeholder)
                {
                    box.Text = "";
                    box.ForeColor = Color.Black;

                    if (box == txtPassword)
                        box.UseSystemPasswordChar = true;
                }
            };

            box.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(box.Text))
                {
                    box.UseSystemPasswordChar = false;
                    box.Text = placeholder;
                    box.ForeColor = Color.Gray;
                }
            };
        }

        // =============================
        // LOAD USER (EDIT MODE)
        // =============================

        private void LoadUserData()
        {
            try
            {
                UserRepository repo = new UserRepository();
                DataTable dt = repo.GetUserById(userId);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("User not found.");
                    return;
                }

                DataRow row = dt.Rows[0];

                txtFullName.ForeColor = Color.Black;
                txtUsername.ForeColor = Color.Black;
                txtPassword.ForeColor = Color.Black;

                txtFullName.Text = row["FullName"]?.ToString();
                txtUsername.Text = row["Username"]?.ToString();
                txtPassword.Text = row["Password"]?.ToString();

                cmbGender.SelectedItem = row["Gender"]?.ToString();
                cmbPosition.SelectedItem = row["Position"]?.ToString();

                txtPassword.UseSystemPasswordChar = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user:\n" + ex.Message);
            }
        }

        // =============================
        // VALIDATION
        // =============================

        private bool ValidateForm()
        {
            if (txtFullName.ForeColor == Color.Gray ||
                txtUsername.ForeColor == Color.Gray ||
                txtPassword.ForeColor == Color.Gray)
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }

            if (cmbGender.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a gender.");
                return false;
            }

            if (cmbPosition.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a position.");
                return false;
            }

            return true;
        }

        // =============================
        // SAVE BUTTON
        // =============================

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            try
            {
                UserRepository repo = new UserRepository();

                if (userId == 0)
                {
                    repo.AddUser(
                        txtFullName.Text.Trim(),
                        cmbGender.Text,
                        cmbPosition.Text,
                        txtUsername.Text.Trim(),
                        txtPassword.Text
                    );

                    MessageBox.Show(
                        "User added successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    repo.UpdateUser(
                        userId,
                        txtFullName.Text.Trim(),
                        cmbGender.Text,
                        cmbPosition.Text,
                        txtUsername.Text.Trim(),
                        txtPassword.Text
                    );

                    MessageBox.Show(
                        "User updated successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error saving user:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}