namespace DocuPixieDesktopApp
{
    partial class LoginPage
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
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial Narrow", 10.2F);
            txtPassword.Location = new Point(198, 418);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(286, 27);
            txtPassword.TabIndex = 17;
            txtPassword.Text = "Password";
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.MouseClick += txtPassword_MouseClick;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial Narrow", 10.2F);
            txtEmail.Location = new Point(200, 343);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(284, 27);
            txtEmail.TabIndex = 16;
            txtEmail.Text = "E-Mail";
            txtEmail.TextAlign = HorizontalAlignment.Center;
            txtEmail.MouseClick += txtEmail_MouseClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkCyan;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(99, 271);
            label4.Name = "label4";
            label4.Size = new Size(195, 19);
            label4.TabIndex = 15;
            label4.Text = "Welcome to DocuPixie..";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.DarkCyan;
            pictureBox3.Location = new Point(61, 239);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(626, 687);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(254, 129);
            label3.Name = "label3";
            label3.Size = new Size(308, 54);
            label3.TabIndex = 13;
            label3.Text = "AI-Powered Document Scanner And\r\nOrganizer\r\n";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Picture1;
            pictureBox2.Location = new Point(15, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(184, 165);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(238, 24);
            label1.Name = "label1";
            label1.Size = new Size(353, 94);
            label1.TabIndex = 11;
            label1.Text = "DocuPixie ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.rpa_vantaggi2;
            pictureBox1.Location = new Point(833, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1080, 1080);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Cyan;
            btnLogin.Font = new Font("Arial Narrow", 10.2F);
            btnLogin.Location = new Point(238, 520);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(203, 29);
            btnLogin.TabIndex = 18;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(913, 557);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "LoginPage";
            Text = "LoginPage";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label label4;
        private PictureBox pictureBox3;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnLogin;
    }
}