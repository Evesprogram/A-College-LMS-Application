namespace CollegeApp
{
    partial class CourseForm
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
            panel1 = new Panel();
            lblTitle = new Label();
            pnlInputs = new Panel();
            lblDepartment = new Label();
            cmbDepartment = new ComboBox();
            txtCourseName = new TextBox();
            lblCourseName = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvCourse = new DataGridView();
            btnBack = new Button();
            panel1.SuspendLayout();
            pnlInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 125);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(235, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Course Management";
            // 
            // pnlInputs
            // 
            pnlInputs.BackColor = Color.White;
            pnlInputs.Controls.Add(lblDepartment);
            pnlInputs.Controls.Add(cmbDepartment);
            pnlInputs.Controls.Add(txtCourseName);
            pnlInputs.Controls.Add(lblCourseName);
            pnlInputs.Dock = DockStyle.Right;
            pnlInputs.Location = new Point(532, 125);
            pnlInputs.Name = "pnlInputs";
            pnlInputs.Size = new Size(268, 325);
            pnlInputs.TabIndex = 1;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(8, 93);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(89, 20);
            lblDepartment.TabIndex = 3;
            lblDepartment.Text = "Department";
            // 
            // cmbDepartment
            // 
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(112, 90);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(151, 28);
            cmbDepartment.TabIndex = 2;
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(112, 37);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(148, 27);
            txtCourseName.TabIndex = 1;
            // 
            // lblCourseName
            // 
            lblCourseName.AutoSize = true;
            lblCourseName.Location = new Point(8, 40);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(98, 20);
            lblCourseName.TabIndex = 0;
            lblCourseName.Text = "Course Name";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(12, 409);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Orange;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(112, 409);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(212, 409);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Plum;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(312, 409);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvCourse
            // 
            dgvCourse.AllowUserToOrderColumns = true;
            dgvCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourse.Location = new Point(20, 142);
            dgvCourse.Name = "dgvCourse";
            dgvCourse.RowHeadersWidth = 51;
            dgvCourse.Size = new Size(448, 223);
            dgvCourse.TabIndex = 6;
            dgvCourse.CellClick += dgvCourse_CellClick;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.RosyBrown;
            btnBack.Location = new Point(412, 409);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(115, 29);
            btnBack.TabIndex = 7;
            btnBack.Text = "🔙Dashboard";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(dgvCourse);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(pnlInputs);
            Controls.Add(panel1);
            Name = "CourseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course Management";
            Click += CourseForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlInputs.ResumeLayout(false);
            pnlInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).EndInit();
            ResumeLayout(false);
            this.Load += new System.EventHandler(this.CourseForm_Load);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Panel pnlInputs;
        private TextBox txtCourseName;
        private Label lblCourseName;
        private Label lblDepartment;
        private ComboBox cmbDepartment;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvCourse;
        private Button btnBack;
    }
}