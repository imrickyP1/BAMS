namespace BAMS.UserControls
{
    partial class UploadDataUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadDataUC));
            panelContainer = new Panel();
            panelMain = new Panel();
            panelDropZone = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panelTitle = new Panel();
            label1 = new Label();
            panelContainer.SuspendLayout();
            panelMain.SuspendLayout();
            panelDropZone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitle.SuspendLayout();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(panelMain);
            panelContainer.Controls.Add(panelTitle);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1297, 867);
            panelContainer.TabIndex = 0;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelDropZone);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 75);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(60, 30, 60, 30);
            panelMain.Size = new Size(1297, 792);
            panelMain.TabIndex = 1;
            // 
            // panelDropZone
            // 
            panelDropZone.BorderStyle = BorderStyle.FixedSingle;
            panelDropZone.Controls.Add(pictureBox1);
            panelDropZone.Controls.Add(label2);
            panelDropZone.Dock = DockStyle.Top;
            panelDropZone.Location = new Point(60, 30);
            panelDropZone.Margin = new Padding(10);
            panelDropZone.Name = "panelDropZone";
            panelDropZone.Size = new Size(1177, 600);
            panelDropZone.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(594, 208);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(582, 287);
            label2.Name = "label2";
            label2.Size = new Size(265, 60);
            label2.TabIndex = 2;
            label2.Text = "Drag and drop a file here,\r\n       or click to select";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.DarkBlue;
            panelTitle.Controls.Add(label1);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1297, 75);
            panelTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 21);
            label1.Name = "label1";
            label1.Size = new Size(179, 37);
            label1.TabIndex = 0;
            label1.Text = "Upload Data";
            // 
            // UploadDataUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelContainer);
            Name = "UploadDataUC";
            Size = new Size(1297, 867);
            panelContainer.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelDropZone.ResumeLayout(false);
            panelDropZone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitle.ResumeLayout(false);
            panelTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContainer;
        private Panel panelTitle;
        private Label label1;
        private Panel panelMain;
        private Panel panelDropZone;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
