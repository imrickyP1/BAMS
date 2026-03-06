namespace BAMS.UserControls
{
    partial class AttendanceUC
    {
        
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceUC));
            panelMain = new Panel();
            panel1 = new Panel();
            dgvAttendance = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colDay = new DataGridViewTextBoxColumn();
            colAMIn = new DataGridViewTextBoxColumn();
            colAMOut = new DataGridViewTextBoxColumn();
            colPMIn = new DataGridViewTextBoxColumn();
            colPMOut = new DataGridViewTextBoxColumn();
            colUT = new DataGridViewTextBoxColumn();
            colOT = new DataGridViewTextBoxColumn();
            colTotalHours = new DataGridViewTextBoxColumn();
            colRemarks = new DataGridViewTextBoxColumn();
            panelfilter = new Panel();
            pictureBox3 = new PictureBox();
            txtSearchName = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            btnExportPdf = new Button();
            btnFilter = new Button();
            cmbEmployee = new ComboBox();
            label4 = new Label();
            dtTo = new DateTimePicker();
            label3 = new Label();
            dtFrom = new DateTimePicker();
            label2 = new Label();
            panelHeader = new Panel();
            label1 = new Label();
            panelMain.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            panelfilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panel1);
            panelMain.Controls.Add(panelfilter);
            panelMain.Controls.Add(panelHeader);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1265, 859);
            panelMain.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvAttendance);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 172);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(1265, 687);
            panel1.TabIndex = 2;
            // 
            // dgvAttendance
            // 
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 245, 245);
            dgvAttendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.BackgroundColor = Color.White;
            dgvAttendance.BorderStyle = BorderStyle.None;
            dgvAttendance.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(25, 118, 210);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAttendance.ColumnHeadersHeight = 45;
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAttendance.Columns.AddRange(new DataGridViewColumn[] { colId, colFullName, colDay, colAMIn, colAMOut, colPMIn, colPMOut, colUT, colOT, colTotalHours, colRemarks });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = Color.White;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle14.ForeColor = Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(232, 240, 254);
            dataGridViewCellStyle14.SelectionForeColor = Color.Black;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dgvAttendance.DefaultCellStyle = dataGridViewCellStyle14;
            dgvAttendance.Dock = DockStyle.Fill;
            dgvAttendance.EnableHeadersVisualStyles = false;
            dgvAttendance.GridColor = Color.LightGray;
            dgvAttendance.Location = new Point(20, 20);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.RowHeadersVisible = false;
            dgvAttendance.RowTemplate.Height = 38;
            dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.Size = new Size(1225, 647);
            dgvAttendance.TabIndex = 0;
            dgvAttendance.CellContentClick += dgvAttendance_CellContentClick;
            // 
            // colId
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colId.DefaultCellStyle = dataGridViewCellStyle3;
            colId.FillWeight = 27.679903F;
            colId.HeaderText = "ID";
            colId.MinimumWidth = 50;
            colId.Name = "colId";
            // 
            // colFullName
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colFullName.DefaultCellStyle = dataGridViewCellStyle4;
            colFullName.FillWeight = 559.44165F;
            colFullName.HeaderText = "Full Name";
            colFullName.MinimumWidth = 220;
            colFullName.Name = "colFullName";
            // 
            // colDay
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colDay.DefaultCellStyle = dataGridViewCellStyle5;
            colDay.FillWeight = 80F;
            colDay.HeaderText = "Day";
            colDay.Name = "colDay";
            // 
            // colAMIn
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colAMIn.DefaultCellStyle = dataGridViewCellStyle6;
            colAMIn.FillWeight = 80F;
            colAMIn.HeaderText = "AM In";
            colAMIn.Name = "colAMIn";
            // 
            // colAMOut
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colAMOut.DefaultCellStyle = dataGridViewCellStyle7;
            colAMOut.FillWeight = 80F;
            colAMOut.HeaderText = "AM Out";
            colAMOut.Name = "colAMOut";
            // 
            // colPMIn
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colPMIn.DefaultCellStyle = dataGridViewCellStyle8;
            colPMIn.FillWeight = 80F;
            colPMIn.HeaderText = "PM In";
            colPMIn.Name = "colPMIn";
            // 
            // colPMOut
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colPMOut.DefaultCellStyle = dataGridViewCellStyle9;
            colPMOut.FillWeight = 80F;
            colPMOut.HeaderText = "PM Out";
            colPMOut.Name = "colPMOut";
            // 
            // colUT
            // 
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colUT.DefaultCellStyle = dataGridViewCellStyle10;
            colUT.FillWeight = 70F;
            colUT.HeaderText = "U/T";
            colUT.Name = "colUT";
            // 
            // colOT
            // 
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colOT.DefaultCellStyle = dataGridViewCellStyle11;
            colOT.FillWeight = 70F;
            colOT.HeaderText = "O/T";
            colOT.Name = "colOT";
            // 
            // colTotalHours
            // 
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colTotalHours.DefaultCellStyle = dataGridViewCellStyle12;
            colTotalHours.FillWeight = 180F;
            colTotalHours.HeaderText = "Total Hours";
            colTotalHours.Name = "colTotalHours";
            // 
            // colRemarks
            // 
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colRemarks.DefaultCellStyle = dataGridViewCellStyle13;
            colRemarks.FillWeight = 150F;
            colRemarks.HeaderText = "Remarks";
            colRemarks.Name = "colRemarks";
            // 
            // panelfilter
            // 
            panelfilter.BackColor = Color.FromArgb(250, 250, 250);
            panelfilter.Controls.Add(pictureBox3);
            panelfilter.Controls.Add(txtSearchName);
            panelfilter.Controls.Add(label5);
            panelfilter.Controls.Add(pictureBox1);
            panelfilter.Controls.Add(btnExportPdf);
            panelfilter.Controls.Add(btnFilter);
            panelfilter.Controls.Add(cmbEmployee);
            panelfilter.Controls.Add(label4);
            panelfilter.Controls.Add(dtTo);
            panelfilter.Controls.Add(label3);
            panelfilter.Controls.Add(dtFrom);
            panelfilter.Controls.Add(label2);
            panelfilter.Dock = DockStyle.Top;
            panelfilter.Location = new Point(0, 78);
            panelfilter.Name = "panelfilter";
            panelfilter.Padding = new Padding(20);
            panelfilter.Size = new Size(1265, 94);
            panelfilter.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(911, 47);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // txtSearchName
            // 
            txtSearchName.BorderStyle = BorderStyle.FixedSingle;
            txtSearchName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchName.Location = new Point(32, 52);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.PlaceholderText = "Search full name ...";
            txtSearchName.Size = new Size(399, 29);
            txtSearchName.TabIndex = 10;
            txtSearchName.TextChanged += txtSearchName_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 26);
            label5.Name = "label5";
            label5.Size = new Size(115, 21);
            label5.TabIndex = 9;
            label5.Text = "Search Name:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1052, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnExportPdf
            // 
            btnExportPdf.BackColor = Color.FromArgb(211, 47, 47);
            btnExportPdf.Cursor = Cursors.Hand;
            btnExportPdf.FlatAppearance.BorderSize = 0;
            btnExportPdf.FlatStyle = FlatStyle.Flat;
            btnExportPdf.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportPdf.ForeColor = Color.White;
            btnExportPdf.Location = new Point(1052, 46);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(155, 35);
            btnExportPdf.TabIndex = 7;
            btnExportPdf.Text = "   Export PDF";
            btnExportPdf.UseVisualStyleBackColor = false;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(33, 150, 243);
            btnFilter.Cursor = Cursors.Hand;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(911, 47);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(111, 34);
            btnFilter.TabIndex = 6;
            btnFilter.Text = "       Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // cmbEmployee
            // 
            cmbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(771, 55);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(107, 29);
            cmbEmployee.TabIndex = 5;
            cmbEmployee.SelectedIndexChanged += cmbEmployee_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(771, 26);
            label4.Name = "label4";
            label4.Size = new Size(86, 21);
            label4.TabIndex = 4;
            label4.Text = "Employee";
            label4.Click += label4_Click;
            // 
            // dtTo
            // 
            dtTo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtTo.Format = DateTimePickerFormat.Short;
            dtTo.Location = new Point(617, 52);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(103, 29);
            dtTo.TabIndex = 3;
            dtTo.ValueChanged += dtTo_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(617, 26);
            label3.Name = "label3";
            label3.Size = new Size(32, 21);
            label3.TabIndex = 2;
            label3.Text = "To:";
            // 
            // dtFrom
            // 
            dtFrom.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtFrom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtFrom.Format = DateTimePickerFormat.Short;
            dtFrom.Location = new Point(449, 52);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(119, 29);
            dtFrom.TabIndex = 1;
            dtFrom.ValueChanged += dtFrom_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(449, 26);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 0;
            label2.Text = "From:";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.DarkBlue;
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1265, 78);
            panelHeader.TabIndex = 0;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 21);
            label1.Name = "label1";
            label1.Size = new Size(273, 37);
            label1.TabIndex = 0;
            label1.Text = "Attendance Records";
            // 
            // AttendanceUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelMain);
            Name = "AttendanceUC";
            Size = new Size(1265, 859);
            Load += AttendanceUC_Load;
            panelMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            panelfilter.ResumeLayout(false);
            panelfilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panelHeader;
        private Label label1;
        private Panel panelfilter;
        private DateTimePicker dtFrom;
        private Label label2;
        private DateTimePicker dtTo;
        private Label label3;
        private ComboBox cmbEmployee;
        private Label label4;
        private Button btnFilter;
        private Panel panel1;
        private DataGridView dgvAttendance;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colDay;
        private DataGridViewTextBoxColumn colAMIn;
        private DataGridViewTextBoxColumn colAMOut;
        private DataGridViewTextBoxColumn colPMIn;
        private DataGridViewTextBoxColumn colPMOut;
        private DataGridViewTextBoxColumn colUT;
        private DataGridViewTextBoxColumn colOT;
        private DataGridViewTextBoxColumn colTotalHours;
        private DataGridViewTextBoxColumn colRemarks;
        private Button btnExportPdf;
        private PictureBox pictureBox1;
        private TextBox txtSearchName;
        private Label label5;
        private PictureBox pictureBox3;
    }
} 