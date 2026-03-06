using System;
using System.Data;
using System.Windows.Forms;
using BAMS.Forms;
using BAMS.Repositories;

namespace BAMS.UserControls
{
    public partial class UserListUC : UserControl
    {
        public UserListUC()
        {
            InitializeComponent();

            SetupGridStyle();
            LoadUsers();
        }

        private void SetupActionColumn()
        {
            if (dgvUser.Columns.Contains("colAction"))
                return;

            DataGridViewTextBoxColumn actionCol = new DataGridViewTextBoxColumn();
            actionCol.Name = "colAction";
            actionCol.HeaderText = "Action";
            actionCol.Width = 150;
            actionCol.ReadOnly = true;
            actionCol.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvUser.Columns.Add(actionCol);
        }
        private void LoadUsers()
        {
            foreach (DataGridViewRow row in dgvUser.Rows)
            {
                row.Cells["colAction"].Value = "Edit | Delete";
            }
            try
            {
                UserRepository repo = new UserRepository();
                DataTable dt = repo.GetAllUsers();

                dgvUser.AutoGenerateColumns = false;
                dgvUser.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users:\n" + ex.Message);
            }
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvUser.Columns[e.ColumnIndex].Name != "colAction")
                return;

            int id = Convert.ToInt32(
                dgvUser.Rows[e.RowIndex].Cells["Id"].Value
            );

            Rectangle cellRect = dgvUser.GetCellDisplayRectangle(
                e.ColumnIndex,
                e.RowIndex,
                false
            );

            int clickX = dgvUser.PointToClient(Cursor.Position).X - cellRect.Left;

            bool isEdit = clickX < cellRect.Width / 2;

            if (isEdit)
            {
                EditUserForm form = new EditUserForm(id);
                form.ShowDialog();
                LoadUsers();
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this user?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        UserRepository repo = new UserRepository();
                        repo.DeleteUser(id);

                        MessageBox.Show(
                            "User deleted successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        LoadUsers();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UserRepository repo = new UserRepository();
                DataTable dt = repo.SearchUsers(txtSearch.Text);

                dgvUser.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm form = new AddUserForm();
            form.ShowDialog();

            LoadUsers();
        }

        private void panelToolbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SetupGridStyle()
        {
            dgvUser.BorderStyle = BorderStyle.None;
            dgvUser.RowHeadersVisible = false;
            dgvUser.EnableHeadersVisualStyles = false;

            dgvUser.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 99, 235);
            dgvUser.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUser.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvUser.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvUser.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(59, 130, 246);

            dgvUser.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvUser.RowTemplate.Height = 42;

            dgvUser.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvUser.Columns["colAction"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvUser.Columns["colAction"].DefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvUser.Columns["colAction"].DefaultCellStyle.ForeColor =
                Color.FromArgb(37, 99, 235);

            dgvUser.Cursor = Cursors.Hand;
        }

        private void dgvUser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUser.Columns[e.ColumnIndex].Name == "colAction")
            {
                e.Value = "✏ Edit      🗑 Delete";
                e.CellStyle.ForeColor = Color.FromArgb(37, 99, 235);
                e.CellStyle.SelectionForeColor = Color.White;
                e.FormattingApplied = true;
            }

            if (dgvUser.Columns[e.ColumnIndex].Name == "Role")
            {
                string role = e.Value?.ToString();

                if (role == "Admin")
                {
                    e.CellStyle.BackColor = Color.RoyalBlue;
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (role == "Official")
                {
                    e.CellStyle.BackColor = Color.Goldenrod;
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (role == "Staff")
                {
                    e.CellStyle.BackColor = Color.SkyBlue;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }

        private void panelHeader_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}

