namespace ProjectCourseWork
{
    partial class ViewStudentSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudentSubject));
            txtCurrentSubject2 = new TextBox();
            txtCurrentSubject1 = new TextBox();
            label1 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            closebtn = new Button();
            label3 = new Label();
            pictureBoxHome = new PictureBox();
            btnBack = new Button();
            txtName = new TextBox();
            label9 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtPrevSubject2 = new TextBox();
            txtPrevSubject1 = new TextBox();
            label2 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            SuspendLayout();
            // 
            // txtCurrentSubject2
            // 
            txtCurrentSubject2.Location = new Point(731, 198);
            txtCurrentSubject2.Name = "txtCurrentSubject2";
            txtCurrentSubject2.Size = new Size(229, 27);
            txtCurrentSubject2.TabIndex = 128;
            // 
            // txtCurrentSubject1
            // 
            txtCurrentSubject1.Location = new Point(385, 196);
            txtCurrentSubject1.Name = "txtCurrentSubject1";
            txtCurrentSubject1.Size = new Size(229, 27);
            txtCurrentSubject1.TabIndex = 127;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(731, 165);
            label1.Name = "label1";
            label1.Size = new Size(211, 27);
            label1.TabIndex = 126;
            label1.Text = "Current Subject 2:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(379, 165);
            label7.Name = "label7";
            label7.Size = new Size(211, 27);
            label7.TabIndex = 125;
            label7.Text = "Current Subject 1:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(closebtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBoxHome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(972, 95);
            panel1.TabIndex = 113;
            // 
            // closebtn
            // 
            closebtn.BackColor = Color.White;
            closebtn.Cursor = Cursors.Hand;
            closebtn.FlatStyle = FlatStyle.Flat;
            closebtn.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closebtn.ForeColor = Color.FromArgb(41, 128, 185);
            closebtn.Location = new Point(932, 0);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(40, 40);
            closebtn.TabIndex = 6;
            closebtn.Text = "X";
            closebtn.UseVisualStyleBackColor = false;
            closebtn.Click += closebtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(347, 23);
            label3.Name = "label3";
            label3.Size = new Size(278, 40);
            label3.TabIndex = 4;
            label3.Text = "Student Subject";
            // 
            // pictureBoxHome
            // 
            pictureBoxHome.Image = Properties.Resources.blob_removebg_preview1;
            pictureBoxHome.Location = new Point(0, 0);
            pictureBoxHome.Name = "pictureBoxHome";
            pictureBoxHome.Size = new Size(99, 95);
            pictureBoxHome.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHome.TabIndex = 1;
            pictureBoxHome.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(41, 128, 185);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(414, 390);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(148, 35);
            btnBack.TabIndex = 114;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(31, 195);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 27);
            txtName.TabIndex = 116;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(31, 165);
            label9.Name = "label9";
            label9.Size = new Size(88, 27);
            label9.TabIndex = 115;
            label9.Text = "Name:";
            // 
            // txtPrevSubject2
            // 
            txtPrevSubject2.Location = new Point(731, 313);
            txtPrevSubject2.Name = "txtPrevSubject2";
            txtPrevSubject2.Size = new Size(236, 27);
            txtPrevSubject2.TabIndex = 133;
            // 
            // txtPrevSubject1
            // 
            txtPrevSubject1.Location = new Point(391, 311);
            txtPrevSubject1.Name = "txtPrevSubject1";
            txtPrevSubject1.Size = new Size(229, 27);
            txtPrevSubject1.TabIndex = 132;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(731, 280);
            label2.Name = "label2";
            label2.Size = new Size(222, 27);
            label2.TabIndex = 131;
            label2.Text = "Previous Subject 2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(385, 280);
            label4.Name = "label4";
            label4.Size = new Size(222, 27);
            label4.TabIndex = 130;
            label4.Text = "Previous Subject 1:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(31, 310);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(229, 27);
            txtEmail.TabIndex = 135;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 280);
            label5.Name = "label5";
            label5.Size = new Size(80, 27);
            label5.TabIndex = 134;
            label5.Text = "Email:";
            // 
            // ViewStudentSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 437);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtPrevSubject2);
            Controls.Add(txtPrevSubject1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(txtCurrentSubject2);
            Controls.Add(txtCurrentSubject1);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(txtName);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewStudentSubject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewStudentSubject";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCurrentSubject2;
        private TextBox txtCurrentSubject1;
        private Label label1;
        private Label label7;
        private Panel panel1;
        private Button closebtn;
        private Label label3;
        private PictureBox pictureBoxHome;
        private Button btnBack;
        private TextBox txtName;
        private Label label9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtPrevSubject2;
        private TextBox txtPrevSubject1;
        private Label label2;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
    }
}