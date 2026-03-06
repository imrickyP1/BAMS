namespace BAMS.UserControls
{
    partial class UserListUC
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panelMain = new Panel();
            panelTable = new Panel();
            dgvUser = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colGender = new DataGridViewTextBoxColumn();
            colPosition = new DataGridViewTextBoxColumn();
            colAction = new DataGridViewTextBoxColumn();
            panelToolbar = new Panel();
            panelSearchCard = new Panel();
            btnAddUser = new Button();
            txtSearch = new TextBox();
            panelHeader = new Panel();
            label2 = new Label();
            panelMain.SuspendLayout();
            panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            panelToolbar.SuspendLayout();
            panelSearchCard.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(panelTable);
            panelMain.Controls.Add(panelToolbar);
            panelMain.Controls.Add(panelHeader);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1225, 834);
            panelMain.TabIndex = 0;
            // 
            // panelTable
            // 
            panelTable.Controls.Add(dgvUser);
            panelTable.Dock = DockStyle.Fill;
            panelTable.Location = new Point(0, 173);
            panelTable.Name = "panelTable";
            panelTable.Padding = new Padding(10);
            panelTable.Size = new Size(1225, 661);
            panelTable.TabIndex = 2;
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.AllowUserToDeleteRows = false;
            dgvUser.AllowUserToResizeColumns = false;
            dgvUser.AllowUserToResizeRows = false;
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUser.BackgroundColor = Color.White;
            dgvUser.BorderStyle = BorderStyle.None;
            dgvUser.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUser.ColumnHeadersHeight = 45;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUser.Columns.AddRange(new DataGridViewColumn[] { Id, colFullName, colGender, colPosition, colAction });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.SlateGray;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvUser.DefaultCellStyle = dataGridViewCellStyle6;
            dgvUser.Dock = DockStyle.Fill;
            dgvUser.EnableHeadersVisualStyles = false;
            dgvUser.GridColor = Color.Gainsboro;
            dgvUser.Location = new Point(10, 10);
            dgvUser.MultiSelect = false;
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersVisible = false;
            dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUser.Size = new Size(1205, 641);
            dgvUser.TabIndex = 0;
            dgvUser.CellContentClick += dgvUser_CellContentClick;
            dgvUser.CellFormatting += dgvUser_CellFormatting;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Id.DefaultCellStyle = dataGridViewCellStyle2;
            Id.FillWeight = 25.9245815F;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 50;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // colFullName
            // 
            colFullName.DataPropertyName = "FullName";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colFullName.DefaultCellStyle = dataGridViewCellStyle3;
            colFullName.FillWeight = 368.527924F;
            colFullName.HeaderText = "FullName";
            colFullName.MinimumWidth = 250;
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            // 
            // colGender
            // 
            colGender.DataPropertyName = "Gender";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colGender.DefaultCellStyle = dataGridViewCellStyle4;
            colGender.FillWeight = 80F;
            colGender.HeaderText = "Gender";
            colGender.Name = "colGender";
            colGender.ReadOnly = true;
            // 
            // colPosition
            // 
            colPosition.DataPropertyName = "Position";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colPosition.DefaultCellStyle = dataGridViewCellStyle5;
            colPosition.FillWeight = 180F;
            colPosition.HeaderText = "Position";
            colPosition.Name = "colPosition";
            colPosition.ReadOnly = true;
            // 
            // colAction
            // 
            colAction.FillWeight = 120F;
            colAction.HeaderText = "Action";
            colAction.Name = "colAction";
            colAction.ReadOnly = true;
            colAction.Resizable = DataGridViewTriState.True;
            colAction.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // panelToolbar
            // 
            panelToolbar.BackColor = Color.White;
            panelToolbar.Controls.Add(panelSearchCard);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(0, 77);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Padding = new Padding(15);
            panelToolbar.Size = new Size(1225, 96);
            panelToolbar.TabIndex = 1;
            // 
            // panelSearchCard
            // 
            panelSearchCard.BackColor = Color.Black;
            panelSearchCard.Controls.Add(btnAddUser);
            panelSearchCard.Controls.Add(txtSearch);
            panelSearchCard.Dock = DockStyle.Fill;
            panelSearchCard.Location = new Point(15, 15);
            panelSearchCard.Name = "panelSearchCard";
            panelSearchCard.Padding = new Padding(15);
            panelSearchCard.Size = new Size(1195, 66);
            panelSearchCard.TabIndex = 0;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.FromArgb(37, 99, 235);
            btnAddUser.Cursor = Cursors.Hand;
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(521, 18);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(149, 33);
            btnAddUser.TabIndex = 2;
            btnAddUser.Text = "+ Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.WhiteSmoke;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = SystemColors.InfoText;
            txtSearch.Location = new Point(18, 18);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "      Search name...";
            txtSearch.Size = new Size(461, 33);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.DarkBlue;
            panelHeader.Controls.Add(label2);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1225, 77);
            panelHeader.TabIndex = 0;
            panelHeader.Paint += panelHeader_Paint_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 21);
            label2.Name = "label2";
            label2.Size = new Size(253, 37);
            label2.TabIndex = 1;
            label2.Text = "User Management";
            // 
            // UserListUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMain);
            Name = "UserListUC";
            Size = new Size(1225, 834);
            panelMain.ResumeLayout(false);
            panelTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            panelToolbar.ResumeLayout(false);
            panelSearchCard.ResumeLayout(false);
            panelSearchCard.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panelHeader;
        private Label label2;
        private Panel panelToolbar;
        private Panel panelSearchCard;
        private TextBox txtSearch;
        
        private Button btnAddUser;
        private Panel panelTable;
        private DataGridView dgvUser;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colGender;
        private DataGridViewTextBoxColumn colPosition;
        private DataGridViewTextBoxColumn colAction;
    }
}
