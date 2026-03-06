namespace BAMS.Forms
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            panelSidebar = new Panel();
            pictureBox6 = new PictureBox();
            btnUploadData = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnUserlist = new Button();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            bntLogout = new Button();
            btnFpGrowth = new Button();
            btnAttendance = new Button();
            btnDashboard = new Button();
            panelMain = new Panel();
            panelTable = new Panel();
            dgvAttendance = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colDay = new DataGridViewTextBoxColumn();
            colAMIn = new DataGridViewTextBoxColumn();
            colAMOut = new DataGridViewTextBoxColumn();
            colPMIn = new DataGridViewTextBoxColumn();
            colPMOut = new DataGridViewTextBoxColumn();
            colRemarks = new DataGridViewTextBoxColumn();
            label3 = new Label();
            panelCards = new Panel();
            cardList = new Panel();
            pictureBox9 = new PictureBox();
            lblTotalList = new Label();
            label7 = new Label();
            label8 = new Label();
            cardStaff = new Panel();
            pictureBox8 = new PictureBox();
            lblTotalStaff = new Label();
            label4 = new Label();
            label5 = new Label();
            cardOfficial = new Panel();
            pictureBox7 = new PictureBox();
            lblTotalOfficial = new Label();
            label2 = new Label();
            label1 = new Label();
            panelHeader = new Panel();
            labelHeader = new Label();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelMain.SuspendLayout();
            panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            panelCards.SuspendLayout();
            cardList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            cardStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            cardOfficial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.DarkBlue;
            panelSidebar.Controls.Add(pictureBox6);
            panelSidebar.Controls.Add(btnUploadData);
            panelSidebar.Controls.Add(panel1);
            panelSidebar.Controls.Add(pictureBox3);
            panelSidebar.Controls.Add(btnUserlist);
            panelSidebar.Controls.Add(pictureBox5);
            panelSidebar.Controls.Add(pictureBox4);
            panelSidebar.Controls.Add(pictureBox2);
            panelSidebar.Controls.Add(bntLogout);
            panelSidebar.Controls.Add(btnFpGrowth);
            panelSidebar.Controls.Add(btnAttendance);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(289, 835);
            panelSidebar.TabIndex = 0;
            panelSidebar.Paint += panelSidebar_Paint;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(10, 437);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(33, 35);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 18;
            pictureBox6.TabStop = false;
            // 
            // btnUploadData
            // 
            btnUploadData.BackColor = Color.Navy;
            btnUploadData.FlatStyle = FlatStyle.Flat;
            btnUploadData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUploadData.ForeColor = Color.White;
            btnUploadData.Location = new Point(10, 437);
            btnUploadData.Name = "btnUploadData";
            btnUploadData.Size = new Size(261, 35);
            btnUploadData.TabIndex = 17;
            btnUploadData.Text = "Upload Data";
            btnUploadData.UseVisualStyleBackColor = false;
            btnUploadData.Click += btnUploadData_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(57, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(163, 145);
            panel1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(10, 307);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // btnUserlist
            // 
            btnUserlist.BackColor = Color.Navy;
            btnUserlist.FlatStyle = FlatStyle.Flat;
            btnUserlist.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserlist.ForeColor = Color.White;
            btnUserlist.Location = new Point(10, 307);
            btnUserlist.Name = "btnUserlist";
            btnUserlist.Size = new Size(261, 35);
            btnUserlist.TabIndex = 14;
            btnUserlist.Text = "User List";
            btnUserlist.UseVisualStyleBackColor = false;
            btnUserlist.Click += btnUserlist_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.AliceBlue;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(10, 394);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(33, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.AliceBlue;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(10, 350);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(33, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.AliceBlue;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(10, 264);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // bntLogout
            // 
            bntLogout.BackColor = Color.Red;
            bntLogout.Dock = DockStyle.Bottom;
            bntLogout.FlatStyle = FlatStyle.Flat;
            bntLogout.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntLogout.ForeColor = Color.White;
            bntLogout.Location = new Point(0, 800);
            bntLogout.Name = "bntLogout";
            bntLogout.Size = new Size(289, 35);
            bntLogout.TabIndex = 5;
            bntLogout.Text = "Logout";
            bntLogout.UseVisualStyleBackColor = false;
            bntLogout.Click += bntLogout_Click;
            // 
            // btnFpGrowth
            // 
            btnFpGrowth.BackColor = Color.Navy;
            btnFpGrowth.FlatStyle = FlatStyle.Flat;
            btnFpGrowth.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFpGrowth.ForeColor = Color.White;
            btnFpGrowth.Location = new Point(10, 394);
            btnFpGrowth.Name = "btnFpGrowth";
            btnFpGrowth.Size = new Size(261, 35);
            btnFpGrowth.TabIndex = 4;
            btnFpGrowth.Text = "FP-Growth";
            btnFpGrowth.UseVisualStyleBackColor = false;
            btnFpGrowth.Click += btnFpgrowth_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.BackColor = Color.Navy;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAttendance.ForeColor = Color.White;
            btnAttendance.Location = new Point(10, 350);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(261, 35);
            btnAttendance.TabIndex = 3;
            btnAttendance.Text = "Attendance";
            btnAttendance.UseVisualStyleBackColor = false;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Navy;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(10, 264);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(261, 35);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(panelTable);
            panelMain.Controls.Add(panelCards);
            panelMain.Controls.Add(panelHeader);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(289, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(0, 0, 0, 10);
            panelMain.Size = new Size(1315, 835);
            panelMain.TabIndex = 1;
            panelMain.Paint += panelMain_Paint;
            // 
            // panelTable
            // 
            panelTable.Controls.Add(dgvAttendance);
            panelTable.Controls.Add(label3);
            panelTable.Dock = DockStyle.Fill;
            panelTable.Location = new Point(0, 226);
            panelTable.Name = "panelTable";
            panelTable.Padding = new Padding(10);
            panelTable.Size = new Size(1315, 599);
            panelTable.TabIndex = 2;
            // 
            // dgvAttendance
            // 
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.BackgroundColor = Color.White;
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colDay, colAMIn, colAMOut, colPMIn, colPMOut, colRemarks });
            dgvAttendance.Dock = DockStyle.Fill;
            dgvAttendance.Location = new Point(10, 47);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.ReadOnly = true;
            dgvAttendance.RowHeadersVisible = false;
            dgvAttendance.Size = new Size(1295, 542);
            dgvAttendance.TabIndex = 1;
            // 
            // colID
            // 
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colDay
            // 
            colDay.HeaderText = "Day";
            colDay.Name = "colDay";
            colDay.ReadOnly = true;
            // 
            // colAMIn
            // 
            colAMIn.HeaderText = "AM In";
            colAMIn.Name = "colAMIn";
            colAMIn.ReadOnly = true;
            // 
            // colAMOut
            // 
            colAMOut.HeaderText = "AM Out";
            colAMOut.Name = "colAMOut";
            colAMOut.ReadOnly = true;
            // 
            // colPMIn
            // 
            colPMIn.HeaderText = "PM In";
            colPMIn.Name = "colPMIn";
            colPMIn.ReadOnly = true;
            // 
            // colPMOut
            // 
            colPMOut.HeaderText = "PM Out";
            colPMOut.Name = "colPMOut";
            colPMOut.ReadOnly = true;
            // 
            // colRemarks
            // 
            colRemarks.HeaderText = "Remarks";
            colRemarks.Name = "colRemarks";
            colRemarks.ReadOnly = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 10);
            label3.Name = "label3";
            label3.Size = new Size(219, 37);
            label3.TabIndex = 0;
            label3.Text = "Attendance Log";
            // 
            // panelCards
            // 
            panelCards.Controls.Add(cardList);
            panelCards.Controls.Add(cardStaff);
            panelCards.Controls.Add(cardOfficial);
            panelCards.Dock = DockStyle.Top;
            panelCards.Location = new Point(0, 75);
            panelCards.Name = "panelCards";
            panelCards.Padding = new Padding(10);
            panelCards.Size = new Size(1315, 151);
            panelCards.TabIndex = 1;
            // 
            // cardList
            // 
            cardList.BackColor = Color.RoyalBlue;
            cardList.Controls.Add(pictureBox9);
            cardList.Controls.Add(lblTotalList);
            cardList.Controls.Add(label7);
            cardList.Controls.Add(label8);
            cardList.Location = new Point(619, 13);
            cardList.Name = "cardList";
            cardList.Size = new Size(272, 120);
            cardList.TabIndex = 4;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(17, 14);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(73, 85);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 3;
            pictureBox9.TabStop = false;
            // 
            // lblTotalList
            // 
            lblTotalList.AutoSize = true;
            lblTotalList.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalList.ForeColor = Color.White;
            lblTotalList.Location = new Point(207, 35);
            lblTotalList.Name = "lblTotalList";
            lblTotalList.Size = new Size(43, 50);
            lblTotalList.TabIndex = 2;
            lblTotalList.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(96, 60);
            label7.Name = "label7";
            label7.Size = new Size(42, 25);
            label7.TabIndex = 1;
            label7.Text = "List";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(96, 35);
            label8.Name = "label8";
            label8.Size = new Size(55, 25);
            label8.TabIndex = 0;
            label8.Text = "Total";
            // 
            // cardStaff
            // 
            cardStaff.BackColor = Color.MediumBlue;
            cardStaff.Controls.Add(pictureBox8);
            cardStaff.Controls.Add(lblTotalStaff);
            cardStaff.Controls.Add(label4);
            cardStaff.Controls.Add(label5);
            cardStaff.Location = new Point(316, 13);
            cardStaff.Name = "cardStaff";
            cardStaff.Size = new Size(272, 120);
            cardStaff.TabIndex = 4;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(17, 14);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(73, 85);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 3;
            pictureBox8.TabStop = false;
            // 
            // lblTotalStaff
            // 
            lblTotalStaff.AutoSize = true;
            lblTotalStaff.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalStaff.ForeColor = Color.White;
            lblTotalStaff.Location = new Point(207, 35);
            lblTotalStaff.Name = "lblTotalStaff";
            lblTotalStaff.Size = new Size(43, 50);
            lblTotalStaff.TabIndex = 2;
            lblTotalStaff.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(96, 60);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 1;
            label4.Text = "Staff";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(96, 35);
            label5.Name = "label5";
            label5.Size = new Size(55, 25);
            label5.TabIndex = 0;
            label5.Text = "Total";
            // 
            // cardOfficial
            // 
            cardOfficial.BackColor = Color.DarkBlue;
            cardOfficial.Controls.Add(pictureBox7);
            cardOfficial.Controls.Add(lblTotalOfficial);
            cardOfficial.Controls.Add(label2);
            cardOfficial.Controls.Add(label1);
            cardOfficial.Location = new Point(13, 13);
            cardOfficial.Name = "cardOfficial";
            cardOfficial.Size = new Size(272, 120);
            cardOfficial.TabIndex = 0;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(17, 14);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(73, 85);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 3;
            pictureBox7.TabStop = false;
            // 
            // lblTotalOfficial
            // 
            lblTotalOfficial.AutoSize = true;
            lblTotalOfficial.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalOfficial.ForeColor = Color.White;
            lblTotalOfficial.Location = new Point(207, 35);
            lblTotalOfficial.Name = "lblTotalOfficial";
            lblTotalOfficial.Size = new Size(43, 50);
            lblTotalOfficial.TabIndex = 2;
            lblTotalOfficial.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(96, 60);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 1;
            label2.Text = "Official";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(96, 35);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 0;
            label1.Text = "Total";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.DarkBlue;
            panelHeader.Controls.Add(labelHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1315, 75);
            panelHeader.TabIndex = 0;
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHeader.ForeColor = Color.White;
            labelHeader.Location = new Point(43, 16);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(545, 37);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "Barangay Attendance Monitoring System";
            labelHeader.Click += labelHeader_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1604, 835);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Barangay Attendance";
            WindowState = FormWindowState.Maximized;
            Load += DashboardForm_Load;
            panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelMain.ResumeLayout(false);
            panelTable.ResumeLayout(false);
            panelTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            panelCards.ResumeLayout(false);
            cardList.ResumeLayout(false);
            cardList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            cardStaff.ResumeLayout(false);
            cardStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            cardOfficial.ResumeLayout(false);
            cardOfficial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Button btnDashboard;
        private Button bntLogout;
        private Button btnAttendance;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private Button btnFpGrowth;
        private Panel panelMain;
        private Panel panelHeader;
        private Panel panelCards;
        private Label labelHeader;
        private Panel cardOfficial;
        private Label lblTotalOfficial;
        private Label label2;
        private Label label1;
        private Panel cardList;
        private PictureBox pictureBox9;
        private Label lblTotalList;
        private Label label7;
        private Label label8;
        private Panel cardStaff;
        private PictureBox pictureBox8;
        private Label lblTotalStaff;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox7;
        private Panel panelTable;
        private Label label3;
        private DataGridView dgvAttendance;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colDay;
        private DataGridViewTextBoxColumn colAMIn;
        private DataGridViewTextBoxColumn colAMOut;
        private DataGridViewTextBoxColumn colPMIn;
        private DataGridViewTextBoxColumn colPMOut;
        private DataGridViewTextBoxColumn colRemarks;
        private Button btnUserlist;
        private PictureBox pictureBox3;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnUploadData;
        private PictureBox pictureBox6;
    }
}