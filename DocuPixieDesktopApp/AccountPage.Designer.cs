namespace DocuPixieDesktopApp
{
    partial class AccountPage
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
            pictureBox1 = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            lblUserEmail = new Label();
            dgvDocuments = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDocuments).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Picture5;
            pictureBox1.Location = new Point(1015, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1022, 1192);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(249, 121);
            label3.Name = "label3";
            label3.Size = new Size(308, 54);
            label3.TabIndex = 29;
            label3.Text = "AI-Powered Document Scanner And\r\nOrganizer\r\n";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Picture1;
            pictureBox2.Location = new Point(10, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(184, 165);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(233, 16);
            label1.Name = "label1";
            label1.Size = new Size(353, 94);
            label1.TabIndex = 27;
            label1.Text = "DocuPixie ";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Picture2;
            pictureBox3.Location = new Point(95, 224);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(156, 142);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 18F);
            label2.Location = new Point(299, 275);
            label2.Name = "label2";
            label2.Size = new Size(67, 35);
            label2.TabIndex = 32;
            label2.Text = "User";
            // 
            // lblUserEmail
            // 
            lblUserEmail.AutoSize = true;
            lblUserEmail.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserEmail.Location = new Point(302, 320);
            lblUserEmail.Name = "lblUserEmail";
            lblUserEmail.Size = new Size(103, 27);
            lblUserEmail.TabIndex = 33;
            lblUserEmail.Text = "User Email";
            // 
            // dgvDocuments
            // 
            dgvDocuments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDocuments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDocuments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocuments.Location = new Point(105, 403);
            dgvDocuments.Name = "dgvDocuments";
            dgvDocuments.ReadOnly = true;
            dgvDocuments.RowHeadersWidth = 51;
            dgvDocuments.Size = new Size(795, 367);
            dgvDocuments.TabIndex = 34;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Cyan;
            btnBack.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(355, 805);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(283, 67);
            btnBack.TabIndex = 35;
            btnBack.Text = "Back to Home";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // AccountPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1122, 884);
            Controls.Add(btnBack);
            Controls.Add(dgvDocuments);
            Controls.Add(lblUserEmail);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Name = "AccountPage";
            Text = "AccountPage";
            WindowState = FormWindowState.Maximized;
            Load += AccountPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDocuments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox3;
        private Label label2;
        private Label lblUserEmail;
        private DataGridView dgvDocuments;
        private Button btnBack;
    }
}