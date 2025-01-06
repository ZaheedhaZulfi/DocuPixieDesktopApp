namespace DocuPixieDesktopApp
{
    partial class UploadPage
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
            label2 = new Label();
            btnBrowse = new Button();
            plnDragDrop = new Panel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            plnDragDrop.SuspendLayout();
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
            label3.TabIndex = 19;
            label3.Text = "AI-Powered Document Scanner And\r\nOrganizer\r\n";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Picture1;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(184, 165);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
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
            label1.TabIndex = 17;
            label1.Text = "DocuPixie ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Miriam Libre", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(56, 213);
            label2.Name = "label2";
            label2.Size = new Size(365, 39);
            label2.TabIndex = 20;
            label2.Text = "Upload your Document...";
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.Cyan;
            btnBrowse.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBrowse.Location = new Point(96, 371);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(245, 65);
            btnBrowse.TabIndex = 21;
            btnBrowse.Text = "Browse From Pc";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // plnDragDrop
            // 
            plnDragDrop.AllowDrop = true;
            plnDragDrop.BackColor = Color.Teal;
            plnDragDrop.Controls.Add(label4);
            plnDragDrop.Location = new Point(476, 265);
            plnDragDrop.Name = "plnDragDrop";
            plnDragDrop.Size = new Size(794, 535);
            plnDragDrop.TabIndex = 22;
            plnDragDrop.DragDrop += pnlDragDrop_DragDrop;
            plnDragDrop.DragEnter += pnlDragDrop_DragEnter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(307, 188);
            label4.Name = "label4";
            label4.Size = new Size(219, 41);
            label4.TabIndex = 0;
            label4.Text = "Drag And Drop";
            // 
            // UploadPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1172, 574);
            Controls.Add(plnDragDrop);
            Controls.Add(btnBrowse);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Name = "UploadPage";
            Text = "UploadPage";
            WindowState = FormWindowState.Maximized;
            Load += UploadPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            plnDragDrop.ResumeLayout(false);
            plnDragDrop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Button btnBrowse;
        private Panel plnDragDrop;
        private Label label4;
    }
}