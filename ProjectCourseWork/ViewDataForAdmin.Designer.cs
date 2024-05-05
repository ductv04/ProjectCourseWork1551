namespace ProjectCourseWork
{
    partial class ViewDataForAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDataForAdmin));
            DataDGV = new DataGridView();
            closebtn = new Button();
            label3 = new Label();
            label7 = new Label();
            btnBack = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBoxHome = new PictureBox();
            panel1 = new Panel();
            txtSearchBox = new TextBox();
            label9 = new Label();
            cmbFilter = new ComboBox();
            label1 = new Label();
            btnSearch = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)DataDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DataDGV
            // 
            DataDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataDGV.Location = new Point(12, 264);
            DataDGV.Name = "DataDGV";
            DataDGV.RowHeadersWidth = 51;
            DataDGV.Size = new Size(1000, 346);
            DataDGV.TabIndex = 61;
            // 
            // closebtn
            // 
            closebtn.BackColor = Color.White;
            closebtn.Cursor = Cursors.Hand;
            closebtn.FlatStyle = FlatStyle.Flat;
            closebtn.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closebtn.ForeColor = Color.FromArgb(41, 128, 185);
            closebtn.Location = new Point(984, 0);
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
            label3.Location = new Point(385, 25);
            label3.Name = "label3";
            label3.Size = new Size(189, 40);
            label3.TabIndex = 4;
            label3.Text = "View Data";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(418, 217);
            label7.Name = "label7";
            label7.Size = new Size(133, 34);
            label7.TabIndex = 58;
            label7.Text = "Data List";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(41, 128, 185);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(864, 150);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(148, 35);
            btnBack.TabIndex = 60;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(closebtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBoxHome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 95);
            panel1.TabIndex = 56;
            // 
            // txtSearchBox
            // 
            txtSearchBox.Location = new Point(22, 158);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.Size = new Size(296, 27);
            txtSearchBox.TabIndex = 99;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(22, 128);
            label9.Name = "label9";
            label9.Size = new Size(144, 27);
            label9.TabIndex = 98;
            label9.Text = "Search box:";
            // 
            // cmbFilter
            // 
            cmbFilter.AccessibleName = "";
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "Administration", "TeachingStaff", "Student" });
            cmbFilter.Location = new Point(324, 157);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(184, 28);
            cmbFilter.TabIndex = 100;
            cmbFilter.Tag = "";
            cmbFilter.Text = "Search Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(418, 128);
            label1.Name = "label1";
            label1.Size = new Size(0, 27);
            label1.TabIndex = 101;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(41, 128, 185);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(530, 152);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(148, 35);
            btnSearch.TabIndex = 102;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(41, 128, 185);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(698, 152);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(148, 35);
            btnRefresh.TabIndex = 103;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ViewData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 622);
            Controls.Add(btnRefresh);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(cmbFilter);
            Controls.Add(txtSearchBox);
            Controls.Add(label9);
            Controls.Add(DataDGV);
            Controls.Add(label7);
            Controls.Add(btnBack);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewData";
            Load += ViewData_Load;
            ((System.ComponentModel.ISupportInitialize)DataDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHome).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView DataDGV;
        private Button closebtn;
        private Label label3;
        private Label label7;
        private Button btnBack;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBoxHome;
        private Panel panel1;
        private TextBox txtSearchBox;
        private Label label9;
        private ComboBox cmbFilter;
        private Label label1;
        private Button btnSearch;
        private Button btnRefresh;
    }
}