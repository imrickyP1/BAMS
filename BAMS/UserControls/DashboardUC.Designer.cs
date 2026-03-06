namespace BAMS.UserControls
{
    partial class DashboardUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardUC));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            panelText = new Panel();
            label1 = new Label();
            panelCards = new Panel();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            lblUserList = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            lbltotalStaff = new Label();
            label5 = new Label();
            label6 = new Label();
            panelTotalOfficial = new Panel();
            pictureBox1 = new PictureBox();
            lblTotalOfficial = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            panelTable = new Panel();
            dgvAttendance = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colDay = new DataGridViewTextBoxColumn();
            colAMIn = new DataGridViewTextBoxColumn();
            colAMOut = new DataGridViewTextBoxColumn();
            colPMIn = new DataGridViewTextBoxColumn();
            colPMOut = new DataGridViewTextBoxColumn();
            colRemarks = new DataGridViewTextBoxColumn();
            panelText.SuspendLayout();
            panelCards.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelTotalOfficial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            SuspendLayout();
            // 
            // panelText
            // 
            panelText.BackColor = Color.DarkBlue;
            panelText.Controls.Add(label1);
            panelText.Dock = DockStyle.Top;
            panelText.Location = new Point(0, 0);
            panelText.Name = "panelText";
            panelText.Size = new Size(1106, 80);
            panelText.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 21);
            label1.Name = "label1";
            label1.Size = new Size(534, 37);
            label1.TabIndex = 0;
            label1.Text = "Barangay Atendance Monitoring System";
            // 
            // panelCards
            // 
            panelCards.BackColor = Color.White;
            panelCards.Controls.Add(panel2);
            panelCards.Controls.Add(panel1);
            panelCards.Controls.Add(panelTotalOfficial);
            panelCards.Dock = DockStyle.Top;
            panelCards.Location = new Point(0, 80);
            panelCards.Name = "panelCards";
            panelCards.Size = new Size(1106, 159);
            panelCards.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(lblUserList);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(699, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 110);
            panel2.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(20, 19);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(63, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // lblUserList
            // 
            lblUserList.AutoSize = true;
            lblUserList.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserList.ForeColor = Color.White;
            lblUserList.Location = new Point(189, 29);
            lblUserList.Name = "lblUserList";
            lblUserList.Size = new Size(43, 50);
            lblUserList.TabIndex = 2;
            lblUserList.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(88, 60);
            label8.Name = "label8";
            label8.Size = new Size(87, 25);
            label8.TabIndex = 1;
            label8.Text = "User List";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(88, 31);
            label9.Name = "label9";
            label9.Size = new Size(55, 25);
            label9.TabIndex = 0;
            label9.Text = "Total";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lbltotalStaff);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(376, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 110);
            panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(20, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // lbltotalStaff
            // 
            lbltotalStaff.AutoSize = true;
            lbltotalStaff.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltotalStaff.ForeColor = Color.White;
            lbltotalStaff.Location = new Point(179, 29);
            lbltotalStaff.Name = "lbltotalStaff";
            lbltotalStaff.Size = new Size(43, 50);
            lbltotalStaff.TabIndex = 2;
            lbltotalStaff.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(89, 60);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 1;
            label5.Text = "Staff";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(89, 31);
            label6.Name = "label6";
            label6.Size = new Size(55, 25);
            label6.TabIndex = 0;
            label6.Text = "Total";
            // 
            // panelTotalOfficial
            // 
            panelTotalOfficial.BackColor = Color.DarkBlue;
            panelTotalOfficial.Controls.Add(pictureBox1);
            panelTotalOfficial.Controls.Add(lblTotalOfficial);
            panelTotalOfficial.Controls.Add(label3);
            panelTotalOfficial.Controls.Add(label2);
            panelTotalOfficial.Location = new Point(48, 23);
            panelTotalOfficial.Name = "panelTotalOfficial";
            panelTotalOfficial.Size = new Size(247, 110);
            panelTotalOfficial.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblTotalOfficial
            // 
            lblTotalOfficial.AutoSize = true;
            lblTotalOfficial.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalOfficial.ForeColor = Color.White;
            lblTotalOfficial.Location = new Point(179, 29);
            lblTotalOfficial.Name = "lblTotalOfficial";
            lblTotalOfficial.Size = new Size(43, 50);
            lblTotalOfficial.TabIndex = 2;
            lblTotalOfficial.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(87, 60);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 1;
            label3.Text = "Official";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(87, 31);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 0;
            label2.Text = "Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 239);
            label4.Name = "label4";
            label4.Padding = new Padding(30, 10, 0, 10);
            label4.Size = new Size(249, 57);
            label4.TabIndex = 2;
            label4.Text = "Attendance Log";
            // 
            // panelTable
            // 
            panelTable.Controls.Add(dgvAttendance);
            panelTable.Dock = DockStyle.Fill;
            panelTable.Location = new Point(0, 296);
            panelTable.Name = "panelTable";
            panelTable.Padding = new Padding(20, 10, 20, 10);
            panelTable.Size = new Size(1106, 549);
            panelTable.TabIndex = 3;
            // 
            // dgvAttendance
            // 
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.AllowUserToResizeRows = false;
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.BackgroundColor = Color.White;
            dgvAttendance.BorderStyle = BorderStyle.None;
            dgvAttendance.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAttendance.ColumnHeadersHeight = 45;
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAttendance.Columns.AddRange(new DataGridViewColumn[] { colId, colFullName, colDay, colAMIn, colAMOut, colPMIn, colPMOut, colRemarks });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvAttendance.DefaultCellStyle = dataGridViewCellStyle10;
            dgvAttendance.Dock = DockStyle.Fill;
            dgvAttendance.EnableHeadersVisualStyles = false;
            dgvAttendance.GridColor = Color.Gainsboro;
            dgvAttendance.Location = new Point(20, 10);
            dgvAttendance.Margin = new Padding(10);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.ReadOnly = true;
            dgvAttendance.RowHeadersVisible = false;
            dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.Size = new Size(1066, 529);
            dgvAttendance.TabIndex = 0;
            // 
            // colId
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colId.DefaultCellStyle = dataGridViewCellStyle2;
            colId.FillWeight = 25.9273739F;
            colId.HeaderText = "ID";
            colId.MinimumWidth = 50;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colFullName
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colFullName.DefaultCellStyle = dataGridViewCellStyle3;
            colFullName.FillWeight = 492.944153F;
            colFullName.HeaderText = "Full Name";
            colFullName.MinimumWidth = 220;
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            // 
            // colDay
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colDay.DefaultCellStyle = dataGridViewCellStyle4;
            colDay.FillWeight = 80F;
            colDay.HeaderText = "Day";
            colDay.Name = "colDay";
            colDay.ReadOnly = true;
            // 
            // colAMIn
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colAMIn.DefaultCellStyle = dataGridViewCellStyle5;
            colAMIn.FillWeight = 80F;
            colAMIn.HeaderText = "AM In";
            colAMIn.Name = "colAMIn";
            colAMIn.ReadOnly = true;
            // 
            // colAMOut
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colAMOut.DefaultCellStyle = dataGridViewCellStyle6;
            colAMOut.FillWeight = 80F;
            colAMOut.HeaderText = "AM Out";
            colAMOut.Name = "colAMOut";
            colAMOut.ReadOnly = true;
            // 
            // colPMIn
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colPMIn.DefaultCellStyle = dataGridViewCellStyle7;
            colPMIn.FillWeight = 80F;
            colPMIn.HeaderText = "PM In";
            colPMIn.Name = "colPMIn";
            colPMIn.ReadOnly = true;
            // 
            // colPMOut
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colPMOut.DefaultCellStyle = dataGridViewCellStyle8;
            colPMOut.FillWeight = 80F;
            colPMOut.HeaderText = "PM Out";
            colPMOut.Name = "colPMOut";
            colPMOut.ReadOnly = true;
            // 
            // colRemarks
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colRemarks.DefaultCellStyle = dataGridViewCellStyle9;
            colRemarks.FillWeight = 150F;
            colRemarks.HeaderText = "Remarks";
            colRemarks.Name = "colRemarks";
            colRemarks.ReadOnly = true;
            // 
            // DashboardUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelTable);
            Controls.Add(label4);
            Controls.Add(panelCards);
            Controls.Add(panelText);
            Name = "DashboardUC";
            Size = new Size(1106, 845);
            Load += DashboardUC_Load;
            panelText.ResumeLayout(false);
            panelText.PerformLayout();
            panelCards.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelTotalOfficial.ResumeLayout(false);
            panelTotalOfficial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelText;
        private Label label1;
        private Panel panelCards;
        private Panel panelTotalOfficial;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lblTotalOfficial;
        private Label label3;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Label lblUserList;
        private Label label8;
        private Label label9;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label lbltotalStaff;
        private Label label5;
        private Label label6;
        private Label label4;
        private Panel panelTable;
        private DataGridView dgvAttendance;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colDay;
        private DataGridViewTextBoxColumn colAMIn;
        private DataGridViewTextBoxColumn colAMOut;
        private DataGridViewTextBoxColumn colPMIn;
        private DataGridViewTextBoxColumn colPMOut;
        private DataGridViewTextBoxColumn colRemarks;
    }
}
