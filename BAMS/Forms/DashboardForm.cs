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
        }

        private void LoadPage(UserControl uc)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadPage(new DashboardUC());
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            LoadPage(new AttendanceUC());
        }

        private void btnFpgrowth_Click(object sender, EventArgs e)
        {
            LoadPage(new FpGrowthUC());
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadPage(new DashboardUC());
        }

        private void bntLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUserlist_Click(object sender, EventArgs e)
        {
            LoadPage(new UserListUC());
        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUploadData_Click(object sender, EventArgs e)
        {
            LoadPage(new UploadDataUC());
        }

        private void labelHeader_Click(object sender, EventArgs e)
        {

        }
    }
}
