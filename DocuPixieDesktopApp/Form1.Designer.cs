namespace DocuPixieDesktopApp
{
    partial class SignUp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnSignup = new Button();
            btnLogin = new Button();
            txtConfirmPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.rpa_vantaggi2;
            pictureBox1.Location = new Point(839, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1080, 1080);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(244, 26);
            label1.Name = "label1";
            label1.Size = new Size(353, 94);
            label1.TabIndex = 1;
            label1.Text = "DocuPixie ";
            // 
            // label2
            // 
            label2.Location = new Point(39, 51);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Picture1;
            pictureBox2.Location = new Point(21, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(184, 165);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(260, 131);
            label3.Name = "label3";
            label3.Size = new Size(308, 54);
            label3.TabIndex = 5;
            label3.Text = "AI-Powered Document Scanner And\r\nOrganizer\r\n";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.DarkCyan;
            pictureBox3.Location = new Point(67, 241);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(626, 687);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkCyan;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(105, 273);
            label4.Name = "label4";
            label4.Size = new Size(195, 19);
            label4.TabIndex = 7;
            label4.Text = "Welcome to DocuPixie..";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial Narrow", 10.2F);
            txtEmail.Location = new Point(206, 345);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(284, 27);
            txtEmail.TabIndex = 8;
            txtEmail.Text = "E-Mail";
            txtEmail.TextAlign = HorizontalAlignment.Center;
            txtEmail.MouseClick += txtEmail_MouseClick;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial Narrow", 10.2F);
            txtPassword.Location = new Point(204, 420);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(286, 27);
            txtPassword.TabIndex = 9;
            txtPassword.Text = "Password";
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.MouseClick += txtPassword_MouseClick;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.Cyan;
            btnSignup.Font = new Font("Arial Narrow", 10.2F);
            btnSignup.Location = new Point(244, 558);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(203, 29);
            btnSignup.TabIndex = 10;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Cyan;
            btnLogin.Font = new Font("Arial Narrow", 10.2F);
            btnLogin.Location = new Point(244, 626);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(203, 29);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Arial Narrow", 10.2F);
            txtConfirmPassword.Location = new Point(206, 492);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(284, 27);
            txtConfirmPassword.TabIndex = 12;
            txtConfirmPassword.Text = "Confirm Password";
            txtConfirmPassword.TextAlign = HorizontalAlignment.Center;
            txtConfirmPassword.MouseClick += txtConfirmPassword_MouseClick;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(900, 673);
            Controls.Add(txtConfirmPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnSignup);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "SignUp";
            Text = "SignUp Page";
            WindowState = FormWindowState.Maximized;
            Load += SignUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label4;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnSignup;
        private Button btnLogin;
        private TextBox txtConfirmPassword;
    }
}
