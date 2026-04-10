namespace CollegeApp
{
    partial class Student
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtStudentID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            txtCourseName = new TextBox();
            dgvStudents = new DataGridView();
            btnView = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            txtSearch = new TextBox();
            labelSearch = new Label();
            btnTotalStudents = new Button();
            btnClear = new Button();
            btnBack = new Button();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(2, 3);
            label1.Name = "label1";
            label1.Size = new Size(661, 54);
            label1.TabIndex = 0;
            label1.Text = "Student Management Application";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 112);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "StudentID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 150);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 2;
            label3.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 187);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 3;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 229);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 4;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 265);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 5;
            label6.Text = "Course Name";
            // 
            // txtStudentID
            // 
            txtStudentID.BackColor = SystemColors.ControlLight;
            txtStudentID.ForeColor = SystemColors.ActiveCaptionText;
            txtStudentID.Location = new Point(125, 112);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(262, 27);
            txtStudentID.TabIndex = 6;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = SystemColors.ControlLight;
            txtFirstName.Location = new Point(125, 150);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(262, 27);
            txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.ControlLight;
            txtLastName.Location = new Point(125, 187);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(262, 27);
            txtLastName.TabIndex = 8;
            // 
            // txtAge
            // 
            txtAge.BackColor = SystemColors.ControlLight;
            txtAge.Location = new Point(125, 229);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(262, 27);
            txtAge.TabIndex = 9;
            // 
            // txtCourseName
            // 
            txtCourseName.BackColor = SystemColors.ControlLight;
            txtCourseName.Location = new Point(125, 265);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(262, 27);
            txtCourseName.TabIndex = 10;
            // 
            // dgvStudents
            // 
            dgvStudents.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.GridColor = SystemColors.InactiveCaption;
            dgvStudents.Location = new Point(444, 107);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(533, 185);
            dgvStudents.TabIndex = 11;
            dgvStudents.CellClick += dataGridView1_CellClick;
            // 
            // btnView
            // 
            btnView.BackColor = Color.SlateGray;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnView.ForeColor = Color.White;
            btnView.Location = new Point(37, 357);
            btnView.Name = "btnView";
            btnView.Size = new Size(94, 29);
            btnView.TabIndex = 12;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumSeaGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.Window;
            btnAdd.Location = new Point(147, 355);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DodgerBlue;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(509, 357);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(609, 356);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandTimeout = 30;
            sqlCommand2.EnableOptimizedParameterBinding = false;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.InactiveCaption;
            txtSearch.Location = new Point(664, 23);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by Name or Course";
            txtSearch.Size = new Size(191, 27);
            txtSearch.TabIndex = 17;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.BackColor = Color.White;
            labelSearch.FlatStyle = FlatStyle.Flat;
            labelSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSearch.ForeColor = SystemColors.ControlText;
            labelSearch.Location = new Point(861, 23);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(87, 23);
            labelSearch.TabIndex = 18;
            labelSearch.Text = "🔍Search";
            // 
            // btnTotalStudents
            // 
            btnTotalStudents.BackColor = SystemColors.ControlDarkDark;
            btnTotalStudents.FlatStyle = FlatStyle.Flat;
            btnTotalStudents.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTotalStudents.ForeColor = Color.White;
            btnTotalStudents.Location = new Point(409, 356);
            btnTotalStudents.Name = "btnTotalStudents";
            btnTotalStudents.Size = new Size(94, 29);
            btnTotalStudents.TabIndex = 19;
            btnTotalStudents.Text = "Total ";
            btnTotalStudents.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.RosyBrown;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.Window;
            btnClear.Location = new Point(260, 355);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.SeaGreen;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.Window;
            btnBack.Location = new Point(833, 355);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(144, 33);
            btnBack.TabIndex = 21;
            btnBack.Text = "← Dashboard";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(444, 304);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(64, 25);
            lblTotal.TabIndex = 22;
            lblTotal.Text = "Total: ";
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1008, 496);
            Controls.Add(lblTotal);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnTotalStudents);
            Controls.Add(labelSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnView);
            Controls.Add(dgvStudents);
            Controls.Add(txtCourseName);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtStudentID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new Size(800, 500);
            Name = "Student";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Application Form";
            Load += Student_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        private TextBox txtSearch;
        private Label labelSearch;
        private Button btnTotalStudents;
        private Button btnClear;
        private Button btnBack;
        private Label lblTotal;
    }
}