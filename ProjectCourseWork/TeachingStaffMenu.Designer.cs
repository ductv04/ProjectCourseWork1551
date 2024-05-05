namespace ProjectCourseWork
{
    partial class TeachingStaffMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeachingStaffMenu));
            panel1 = new Panel();
            closebtn = new Button();
            pictureBoxHome = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            pictureBoxSubject = new PictureBox();
            pictureBoxTeacherProfile = new PictureBox();
            pictureBoxViewStudentData = new PictureBox();
            label1 = new Label();
            pictureBoxLogout = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSubject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTeacherProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxViewStudentData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogout).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(closebtn);
            panel1.Controls.Add(pictureBoxHome);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 95);
            panel1.TabIndex = 0;
            // 
            // closebtn
            // 
            closebtn.BackColor = Color.White;
            closebtn.Cursor = Cursors.Hand;
            closebtn.FlatStyle = FlatStyle.Flat;
            closebtn.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closebtn.ForeColor = Color.FromArgb(41, 128, 185);
            closebtn.Location = new Point(710, 0);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(40, 40);
            closebtn.TabIndex = 6;
            closebtn.Text = "X";
            closebtn.UseVisualStyleBackColor = false;
            closebtn.Click += closebtn_Click;
            // 
            // pictureBoxHome
            // 
            pictureBoxHome.Image = Properties.Resources.blob_removebg_preview1;
            pictureBoxHome.Location = new Point(0, 0);
            pictureBoxHome.Name = "pictureBoxHome";
            pictureBoxHome.Size = new Size(99, 95);
            pictureBoxHome.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHome.TabIndex = 5;
            pictureBoxHome.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(213, 24);
            label3.Name = "label3";
            label3.Size = new Size(356, 40);
            label3.TabIndex = 4;
            label3.Text = "Teaching Staff Menu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(326, 271);
            label2.Name = "label2";
            label2.Size = new Size(98, 34);
            label2.TabIndex = 6;
            label2.Text = "Profile";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(578, 271);
            label4.Name = "label4";
            label4.Size = new Size(118, 34);
            label4.TabIndex = 7;
            label4.Text = "Subject";
            // 
            // pictureBoxSubject
            // 
            pictureBoxSubject.Image = (Image)resources.GetObject("pictureBoxSubject.Image");
            pictureBoxSubject.Location = new Point(565, 143);
            pictureBoxSubject.Name = "pictureBoxSubject";
            pictureBoxSubject.Size = new Size(141, 125);
            pictureBoxSubject.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSubject.TabIndex = 9;
            pictureBoxSubject.TabStop = false;
            pictureBoxSubject.Click += pictureBoxSubject_Click;
            // 
            // pictureBoxTeacherProfile
            // 
            pictureBoxTeacherProfile.Image = (Image)resources.GetObject("pictureBoxTeacherProfile.Image");
            pictureBoxTeacherProfile.Location = new Point(302, 143);
            pictureBoxTeacherProfile.Name = "pictureBoxTeacherProfile";
            pictureBoxTeacherProfile.Size = new Size(141, 125);
            pictureBoxTeacherProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTeacherProfile.TabIndex = 10;
            pictureBoxTeacherProfile.TabStop = false;
            pictureBoxTeacherProfile.Click += pictureBoxTeacherProfile_Click;
            // 
            // pictureBoxViewStudentData
            // 
            pictureBoxViewStudentData.Image = (Image)resources.GetObject("pictureBoxViewStudentData.Image");
            pictureBoxViewStudentData.Location = new Point(36, 143);
            pictureBoxViewStudentData.Name = "pictureBoxViewStudentData";
            pictureBoxViewStudentData.Size = new Size(141, 125);
            pictureBoxViewStudentData.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxViewStudentData.TabIndex = 26;
            pictureBoxViewStudentData.TabStop = false;
            pictureBoxViewStudentData.Click += pictureBoxViewStudentData_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(61, 271);
            label1.Name = "label1";
            label1.Size = new Size(85, 34);
            label1.TabIndex = 25;
            label1.Text = "View";
            // 
            // pictureBoxLogout
            // 
            pictureBoxLogout.Image = Properties.Resources._5932994;
            pictureBoxLogout.Location = new Point(667, 459);
            pictureBoxLogout.Name = "pictureBoxLogout";
            pictureBoxLogout.Size = new Size(83, 73);
            pictureBoxLogout.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogout.TabIndex = 27;
            pictureBoxLogout.TabStop = false;
            pictureBoxLogout.Click += pictureBoxLogout_Click;
            // 
            // TeachingStaffMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 530);
            Controls.Add(pictureBoxLogout);
            Controls.Add(pictureBoxViewStudentData);
            Controls.Add(label1);
            Controls.Add(pictureBoxTeacherProfile);
            Controls.Add(pictureBoxSubject);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TeachingStaffMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeachingStaff";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSubject).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTeacherProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxViewStudentData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label4;
        private PictureBox pictureBoxSubject;
        private PictureBox pictureBoxTeacherProfile;
        private PictureBox pictureBoxHome;
        private Button closebtn;
        private PictureBox pictureBoxViewStudentData;
        private Label label1;
        private PictureBox pictureBoxLogout;
    }
}