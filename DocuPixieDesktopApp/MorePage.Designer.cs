namespace DocuPixieDesktopApp
{
    partial class MorePage
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
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            btnScanSummarize = new Button();
            btnShare = new Button();
            btnSave = new Button();
            btnManage = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(253, 126);
            label3.Name = "label3";
            label3.Size = new Size(308, 54);
            label3.TabIndex = 9;
            label3.Text = "AI-Powered Document Scanner And\r\nOrganizer\r\n";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Picture1;
            pictureBox2.Location = new Point(14, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(184, 165);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(237, 21);
            label1.Name = "label1";
            label1.Size = new Size(353, 94);
            label1.TabIndex = 7;
            label1.Text = "DocuPixie ";
            // 
            // btnScanSummarize
            // 
            btnScanSummarize.BackColor = Color.Cyan;
            btnScanSummarize.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnScanSummarize.Location = new Point(177, 257);
            btnScanSummarize.Name = "btnScanSummarize";
            btnScanSummarize.Size = new Size(283, 67);
            btnScanSummarize.TabIndex = 22;
            btnScanSummarize.Text = "Scan And Summarize";
            btnScanSummarize.UseVisualStyleBackColor = false;
            btnScanSummarize.Click += btnScanSummarize_Click;
            // 
            // btnShare
            // 
            btnShare.BackColor = Color.Cyan;
            btnShare.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShare.Location = new Point(177, 366);
            btnShare.Name = "btnShare";
            btnShare.Size = new Size(283, 62);
            btnShare.TabIndex = 23;
            btnShare.Text = "Share";
            btnShare.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Cyan;
            btnSave.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(177, 472);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(283, 61);
            btnSave.TabIndex = 24;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnManage
            // 
            btnManage.BackColor = Color.Cyan;
            btnManage.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManage.Location = new Point(177, 580);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(283, 65);
            btnManage.TabIndex = 25;
            btnManage.Text = "Manage";
            btnManage.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Picture5;
            pictureBox1.Location = new Point(780, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1022, 1192);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // MorePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1145, 639);
            Controls.Add(pictureBox1);
            Controls.Add(btnManage);
            Controls.Add(btnSave);
            Controls.Add(btnShare);
            Controls.Add(btnScanSummarize);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Name = "MorePage";
            Text = "MorePage";
            WindowState = FormWindowState.Maximized;
            Load += MorePage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private PictureBox pictureBox2;
        private Label label1;
        private Button btnScanSummarize;
        private Button btnShare;
        private Button btnSave;
        private Button btnManage;
        private PictureBox pictureBox1;
    }
}