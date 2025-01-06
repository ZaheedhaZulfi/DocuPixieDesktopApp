namespace DocuPixieDesktopApp
{
    partial class SummeraizedPage
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
            richTextBox1 = new RichTextBox();
            btnSave = new Button();
            btnShare = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            label3.TabIndex = 22;
            label3.Text = "AI-Powered Document Scanner And\r\nOrganizer\r\n";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Picture1;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(184, 165);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
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
            label1.TabIndex = 20;
            label1.Text = "DocuPixie ";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(373, 251);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(923, 279);
            richTextBox1.TabIndex = 23;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Cyan;
            btnSave.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(425, 574);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(283, 61);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnShare
            // 
            btnShare.BackColor = Color.Cyan;
            btnShare.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShare.Location = new Point(1001, 573);
            btnShare.Name = "btnShare";
            btnShare.Size = new Size(283, 62);
            btnShare.TabIndex = 25;
            btnShare.Text = "Share";
            btnShare.UseVisualStyleBackColor = false;
            // 
            // SummeraizedPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1381, 708);
            Controls.Add(btnSave);
            Controls.Add(btnShare);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Name = "SummeraizedPage";
            Text = "SummeraizedPage";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private PictureBox pictureBox2;
        private Label label1;
        private RichTextBox richTextBox1;
        private Button btnSave;
        private Button btnShare;
    }
}