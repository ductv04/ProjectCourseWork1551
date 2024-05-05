namespace ProjectCourseWork
{
    partial class AdminProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProfile));
            label1 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            closebtn = new Button();
            label3 = new Label();
            pictureBoxHome = new PictureBox();
            btnBack = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnUpdate = new Button();
            txtName = new TextBox();
            dateTimePickerDOB = new DateTimePicker();
            label6 = new Label();
            txtAddress = new TextBox();
            intPhone = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label9 = new Label();
            cmbEmploymentType = new ComboBox();
            cmbWorkingHours = new ComboBox();
            txtEmail = new TextBox();
            label2 = new Label();
            txtSalary = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(621, 268);
            label1.Name = "label1";
            label1.Size = new Size(177, 27);
            label1.TabIndex = 108;
            label1.Text = "Working Hours:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(332, 268);
            label8.Name = "label8";
            label8.Size = new Size(237, 27);
            label8.TabIndex = 106;
            label8.Text = "Employement Type:";
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
            closebtn.TabIndex = 5;
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
            label3.Size = new Size(228, 40);
            label3.TabIndex = 4;
            label3.Text = "Admin Profile";
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
            btnBack.Location = new Point(730, 402);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(148, 35);
            btnBack.TabIndex = 95;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(41, 128, 185);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(295, 402);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(148, 35);
            btnUpdate.TabIndex = 94;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 190);
            txtName.Name = "txtName";
            txtName.Size = new Size(252, 27);
            txtName.TabIndex = 97;
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Location = new Point(12, 298);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(252, 27);
            dateTimePickerDOB.TabIndex = 105;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 268);
            label6.Name = "label6";
            label6.Size = new Size(156, 27);
            label6.TabIndex = 104;
            label6.Text = "Date of Birth:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(921, 190);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(229, 27);
            txtAddress.TabIndex = 103;
            // 
            // intPhone
            // 
            intPhone.Location = new Point(621, 190);
            intPhone.Name = "intPhone";
            intPhone.Size = new Size(229, 27);
            intPhone.TabIndex = 102;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(921, 160);
            label5.Name = "label5";
            label5.Size = new Size(107, 27);
            label5.TabIndex = 101;
            label5.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(621, 160);
            label4.Name = "label4";
            label4.Size = new Size(90, 27);
            label4.TabIndex = 100;
            label4.Text = "Phone:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 160);
            label9.Name = "label9";
            label9.Size = new Size(88, 27);
            label9.TabIndex = 96;
            label9.Text = "Name:";
            // 
            // cmbEmploymentType
            // 
            cmbEmploymentType.FormattingEnabled = true;
            cmbEmploymentType.Items.AddRange(new object[] { "Full Time", "Part Time" });
            cmbEmploymentType.Location = new Point(332, 300);
            cmbEmploymentType.Name = "cmbEmploymentType";
            cmbEmploymentType.Size = new Size(231, 28);
            cmbEmploymentType.TabIndex = 107;
            // 
            // cmbWorkingHours
            // 
            cmbWorkingHours.FormattingEnabled = true;
            cmbWorkingHours.Items.AddRange(new object[] { "1 Hours", "2 Hours", "3 Hours", "4 Hours", "5 Hours", "6 Hours", "7 Hours", "8 Hours" });
            cmbWorkingHours.Location = new Point(621, 300);
            cmbWorkingHours.Name = "cmbWorkingHours";
            cmbWorkingHours.Size = new Size(231, 28);
            cmbWorkingHours.TabIndex = 109;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(332, 190);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(229, 27);
            txtEmail.TabIndex = 111;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(332, 160);
            label2.Name = "label2";
            label2.Size = new Size(80, 27);
            label2.TabIndex = 110;
            label2.Text = "Email:";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(921, 298);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(229, 27);
            txtSalary.TabIndex = 113;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(921, 268);
            label7.Name = "label7";
            label7.Size = new Size(87, 27);
            label7.TabIndex = 112;
            label7.Text = "Salary:";
            // 
            // AdminProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 500);
            Controls.Add(txtSalary);
            Controls.Add(label7);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(cmbWorkingHours);
            Controls.Add(label1);
            Controls.Add(cmbEmploymentType);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(txtName);
            Controls.Add(dateTimePickerDOB);
            Controls.Add(label6);
            Controls.Add(txtAddress);
            Controls.Add(intPhone);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminProfile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label8;
        private Panel panel1;
        private Button closebtn;
        private Label label3;
        private PictureBox pictureBoxHome;
        private Button btnBack;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnUpdate;
        private TextBox txtName;
        private DateTimePicker dateTimePickerDOB;
        private Label label6;
        private TextBox txtAddress;
        private TextBox intPhone;
        private Label label5;
        private Label label4;
        private Label label9;
        private ComboBox cmbEmploymentType;
        private ComboBox cmbWorkingHours;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtSalary;
        private Label label7;
    }
}