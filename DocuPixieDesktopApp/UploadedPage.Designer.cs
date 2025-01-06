namespace DocuPixieDesktopApp
{
    partial class UploadedPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadedPage));
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnDownload = new Button();
            btnMore = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1114, 137);
            label3.Name = "label3";
            label3.Size = new Size(308, 54);
            label3.TabIndex = 9;
            label3.Text = "AI-Powered Document Scanner And\r\nOrganizer\r\n";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Picture1;
            pictureBox2.Location = new Point(875, 26);
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
            label1.Location = new Point(1098, 32);
            label1.Name = "label1";
            label1.Size = new Size(353, 94);
            label1.TabIndex = 7;
            label1.Text = "DocuPixie ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 1104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(997, 232);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(595, 538);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.Cyan;
            btnDownload.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDownload.Location = new Point(1036, 844);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(258, 67);
            btnDownload.TabIndex = 20;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            // 
            // btnMore
            // 
            btnMore.BackColor = Color.Cyan;
            btnMore.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMore.Location = new Point(1358, 844);
            btnMore.Name = "btnMore";
            btnMore.Size = new Size(234, 63);
            btnMore.TabIndex = 21;
            btnMore.Text = "More";
            btnMore.UseVisualStyleBackColor = false;
            btnMore.Click += btnMore_Click;
            // 
            // UploadedPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1399, 919);
            Controls.Add(btnMore);
            Controls.Add(btnDownload);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "UploadedPage";
            Text = "UploadedPage";
            WindowState = FormWindowState.Maximized;
            Load += UploadedPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Button btnDownload;
        private Button btnMore;
    }
}