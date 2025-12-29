using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAMS.UserControls;

namespace BAMS.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            this.Load += DashboardForm_Load;
        }

        private void LoadPage(UserControl uc)
        {
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvAttendance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvAttendance.Columns[e.ColumnIndex].Name != "colRemarks")
                return;

            if (e.Value == null || string.IsNullOrWhiteSpace(e.Value.ToString()))
                return;

            string remark = e.Value.ToString().Trim().ToLower();

            switch (remark)
            {
                case "on time":
                    e.CellStyle.BackColor = Color.Green;
                    break;

                case "late":
                    e.CellStyle.BackColor = Color.Orange;
                    break;

                case "undertime":
                    e.CellStyle.BackColor = Color.Red;
                    break;

                case "overtime":
                    e.CellStyle.BackColor = Color.Blue;
                    break;
                default:
                    e.CellStyle.BackColor = Color.Gray;
                    break;
            }
            e.CellStyle.ForeColor = Color.White;
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            e.CellStyle.Font = dgvAttendance.Font;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadPage(new DashboardUC());
        }

        private void btnUserlist_Click(object sender, EventArgs e)
        {
            LoadPage(new UserListUC());
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            LoadPage(new AttendanceUC());
        }

        private void btnFpgrowth_Click(object sender, EventArgs e)
        {
            LoadPage(new FpGrowthUC());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            LoadPage(new ReportsUC());
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadPage(new DashboardUC());
        }

        private void bntLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
