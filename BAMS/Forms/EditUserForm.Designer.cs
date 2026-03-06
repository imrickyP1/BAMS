namespace BAMS.Forms
{
    partial class EditUserForm
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

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            txtFullName = new TextBox();
            cmbGender = new ComboBox();
            cmbPosition = new ComboBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 12F);
            txtFullName.Location = new Point(143, 140);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(293, 29);
            txtFullName.TabIndex = 0;
            txtFullName.Text = "Full Name";
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 12F);
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(143, 180);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(293, 29);
            cmbGender.TabIndex = 1;
            cmbGender.Text = "Gender";
            // 
            // cmbPosition
            // 
            cmbPosition.Font = new Font("Segoe UI", 12F);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(143, 220);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(293, 29);
            cmbPosition.TabIndex = 2;
            cmbPosition.Text = "Position";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(143, 260);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(293, 29);
            txtUsername.TabIndex = 3;
            txtUsername.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(143, 300);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(293, 29);
            txtPassword.TabIndex = 4;
            txtPassword.Text = "Password";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LimeGreen;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(340, 357);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(96, 30);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(143, 357);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(96, 30);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(217, 63);
            label1.Name = "label1";
            label1.Size = new Size(150, 37);
            label1.TabIndex = 7;
            label1.Text = "EDIT USER";
            // 
            // EditUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(589, 450);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(cmbPosition);
            Controls.Add(cmbGender);
            Controls.Add(txtFullName);
            Name = "EditUserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private ComboBox cmbGender;
        private ComboBox cmbPosition;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnSave;
        private Button btnCancel;
        private Label label1;
    }
}