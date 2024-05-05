namespace ProjectCourseWork
{
    partial class StudentMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMenu));
            closebtn = new Button();
            label3 = new Label();
            pictureBoxHome = new PictureBox();
            pictureBoxStudentProfile = new PictureBox();
            label5 = new Label();
            pictureBoxViewData = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            pictureBoxLogout = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStudentProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxViewData).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogout).BeginInit();
            SuspendLayout();
            // 
            // closebtn
            // 
            closebtn.BackColor = Color.White;
            closebtn.Cursor = Cursors.Hand;
            closebtn.FlatStyle = FlatStyle.Flat;
            closebtn.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closebtn.ForeColor = Color.FromArgb(41, 128, 185);
            closebtn.Location = new Point(611, 0);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(40, 40);
            closebtn.TabIndex = 2;
            closebtn.Text = "X";
            closebtn.UseVisualStyleBackColor = false;
            closebtn.Click += closebtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(260, 29);
            label3.Name = "label3";
            label3.Size = new Size(249, 40);
            label3.TabIndex = 4;
            label3.Text = "Student Menu";
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
            // pictureBoxStudentProfile
            // 
            pictureBoxStudentProfile.Image = (Image)resources.GetObject("pictureBoxStudentProfile.Image");
            pictureBoxStudentProfile.Location = new Point(403, 152);
            pictureBoxStudentProfile.Name = "pictureBoxStudentProfile";
            pictureBoxStudentProfile.Size = new Size(141, 125);
            pictureBoxStudentProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStudentProfile.TabIndex = 26;
            pictureBoxStudentProfile.TabStop = false;
            pictureBoxStudentProfile.Click += pictureBoxStudentProfile_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(420, 280);
            label5.Name = "label5";
            label5.Size = new Size(98, 34);
            label5.TabIndex = 25;
            label5.Text = "Profile";
            // 
            // pictureBoxViewData
            // 
            pictureBoxViewData.Image = (Image)resources.GetObject("pictureBoxViewData.Image");
            pictureBoxViewData.Location = new Point(74, 152);
            pictureBoxViewData.Name = "pictureBoxViewData";
            pictureBoxViewData.Size = new Size(141, 125);
            pictureBoxViewData.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxViewData.TabIndex = 24;
            pictureBoxViewData.TabStop = false;
            pictureBoxViewData.Click += pictureBoxViewStudentSubject_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(86, 280);
            label2.Name = "label2";
            label2.Size = new Size(118, 34);
            label2.TabIndex = 23;
            label2.Text = "Subject";
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
            panel1.Size = new Size(651, 95);
            panel1.TabIndex = 18;
            // 
            // pictureBoxLogout
            // 
            pictureBoxLogout.Image = Properties.Resources._5932994;
            pictureBoxLogout.Location = new Point(568, 457);
            pictureBoxLogout.Name = "pictureBoxLogout";
            pictureBoxLogout.Size = new Size(83, 73);
            pictureBoxLogout.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogout.TabIndex = 27;
            pictureBoxLogout.TabStop = false;
            pictureBoxLogout.Click += pictureBoxLogout_Click;
            // 
            // StudentMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 530);
            Controls.Add(pictureBoxLogout);
            Controls.Add(pictureBoxStudentProfile);
            Controls.Add(label5);
            Controls.Add(pictureBoxViewData);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StudentMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentMenu";
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStudentProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxViewData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closebtn;
        private Label label3;
        private PictureBox pictureBoxHome;
        private PictureBox pictureBoxStudentProfile;
        private Label label5;
        private PictureBox pictureBoxViewData;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBoxLogout;
    }
}