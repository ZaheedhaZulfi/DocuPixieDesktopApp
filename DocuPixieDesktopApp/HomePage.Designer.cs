namespace DocuPixieDesktopApp
{
    partial class HomePage
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
            btnAccount = new Button();
            btnUploadDocument = new Button();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(251, 123);
            label3.Name = "label3";
            label3.Size = new Size(308, 54);
            label3.TabIndex = 16;
            label3.Text = "AI-Powered Document Scanner And\r\nOrganizer\r\n";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Picture1;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(184, 165);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(235, 18);
            label1.Name = "label1";
            label1.Size = new Size(353, 94);
            label1.TabIndex = 14;
            label1.Text = "DocuPixie ";
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.Cyan;
            btnAccount.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAccount.Location = new Point(398, 521);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(201, 57);
            btnAccount.TabIndex = 19;
            btnAccount.Text = "Account";
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnUploadDocument
            // 
            btnUploadDocument.BackColor = Color.Cyan;
            btnUploadDocument.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUploadDocument.Location = new Point(1226, 521);
            btnUploadDocument.Name = "btnUploadDocument";
            btnUploadDocument.Size = new Size(250, 57);
            btnUploadDocument.TabIndex = 20;
            btnUploadDocument.Text = "Upload Document";
            btnUploadDocument.UseVisualStyleBackColor = false;
            btnUploadDocument.Click += btnUploadDocument_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Teal;
            pictureBox4.Location = new Point(173, 219);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1613, 593);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Picture2;
            pictureBox5.Location = new Point(400, 282);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(199, 208);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Picture3;
            pictureBox6.Location = new Point(1279, 282);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(161, 208);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 23;
            pictureBox6.TabStop = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1332, 675);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(btnUploadDocument);
            Controls.Add(btnAccount);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Name = "HomePage";
            Text = "HomePage";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox3;
        private Button btnAccount;
        private Button btnUploadDocument;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}