namespace ProjectCourseWork
{
    partial class StudentProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentProfile));
            panel1 = new Panel();
            closebtn = new Button();
            label3 = new Label();
            pictureBoxHome = new PictureBox();
            btnBack = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtName = new TextBox();
            label9 = new Label();
            label1 = new Label();
            label7 = new Label();
            txtCurrentSubject1 = new TextBox();
            txtCurrentSubject2 = new TextBox();
            btnUpdate = new Button();
            dateTimePickerDOB = new DateTimePicker();
            label6 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            intPhone = new TextBox();
            txtAddress = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            SuspendLayout();
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
            panel1.Size = new Size(1155, 95);
            panel1.TabIndex = 93;
            // 
            // closebtn
            // 
            closebtn.BackColor = Color.White;
            closebtn.Cursor = Cursors.Hand;
            closebtn.FlatStyle = FlatStyle.Flat;
            closebtn.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closebtn.ForeColor = Color.FromArgb(41, 128, 185);
            closebtn.Location = new Point(1115, 0);
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
            label3.Location = new Point(465, 25);
            label3.Name = "label3";
            label3.Size = new Size(252, 40);
            label3.TabIndex = 4;
            label3.Text = "Student Profile";
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
            btnBack.Location = new Point(673, 433);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(148, 35);
            btnBack.TabIndex = 95;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(5, 229);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 27);
            txtName.TabIndex = 97;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(5, 199);
            label9.Name = "label9";
            label9.Size = new Size(88, 27);
            label9.TabIndex = 96;
            label9.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(829, 303);
            label1.Name = "label1";
            label1.Size = new Size(211, 27);
            label1.TabIndex = 107;
            label1.Text = "Current Subject 2:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(477, 303);
            label7.Name = "label7";
            label7.Size = new Size(211, 27);
            label7.TabIndex = 106;
            label7.Text = "Current Subject 1:";
            // 
            // txtCurrentSubject1
            // 
            txtCurrentSubject1.Location = new Point(483, 334);
            txtCurrentSubject1.Name = "txtCurrentSubject1";
            txtCurrentSubject1.Size = new Size(229, 27);
            txtCurrentSubject1.TabIndex = 110;
            // 
            // txtCurrentSubject2
            // 
            txtCurrentSubject2.Location = new Point(829, 336);
            txtCurrentSubject2.Name = "txtCurrentSubject2";
            txtCurrentSubject2.Size = new Size(229, 27);
            txtCurrentSubject2.TabIndex = 111;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(41, 128, 185);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(312, 433);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(148, 35);
            btnUpdate.TabIndex = 112;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Location = new Point(96, 334);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(252, 27);
            dateTimePickerDOB.TabIndex = 105;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(96, 304);
            label6.Name = "label6";
            label6.Size = new Size(156, 27);
            label6.TabIndex = 104;
            label6.Text = "Date of Birth:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(298, 229);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(229, 27);
            txtEmail.TabIndex = 98;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(298, 199);
            label2.Name = "label2";
            label2.Size = new Size(80, 27);
            label2.TabIndex = 99;
            label2.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(622, 199);
            label4.Name = "label4";
            label4.Size = new Size(90, 27);
            label4.TabIndex = 100;
            label4.Text = "Phone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(916, 199);
            label5.Name = "label5";
            label5.Size = new Size(107, 27);
            label5.TabIndex = 101;
            label5.Text = "Address:";
            // 
            // intPhone
            // 
            intPhone.Location = new Point(622, 229);
            intPhone.Name = "intPhone";
            intPhone.Size = new Size(229, 27);
            intPhone.TabIndex = 102;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(916, 229);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(229, 27);
            txtAddress.TabIndex = 103;
            // 
            // StudentProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 500);
            Controls.Add(btnUpdate);
            Controls.Add(txtCurrentSubject2);
            Controls.Add(txtCurrentSubject1);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(txtName);
            Controls.Add(dateTimePickerDOB);
            Controls.Add(label6);
            Controls.Add(txtAddress);
            Controls.Add(intPhone);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StudentProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentProfile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private PictureBox pictureBoxHome;
        private Button btnBack;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtName;
        private Label label9;
        private Label label1;
        private Label label7;
        private Button closebtn;
        private TextBox txtCurrentSubject1;
        private TextBox txtCurrentSubject2;
        private Button btnUpdate;
        private DateTimePicker dateTimePickerDOB;
        private Label label6;
        private TextBox txtEmail;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox intPhone;
        private TextBox txtAddress;
    }
}