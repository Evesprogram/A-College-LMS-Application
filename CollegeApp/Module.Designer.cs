namespace CollegeApp
{
    partial class ModuleForm
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblModuleName = new Label();
            pnlInputs = new Panel();
            cmbCourse = new ComboBox();
            lblCourse = new Label();
            txtModuleName = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvModule = new DataGridView();
            btnBack = new Button();
            pnlHeader.SuspendLayout();
            pnlInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvModule).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.DarkSeaGreen;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1060, 125);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(245, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Module Management";
            // 
            // lblModuleName
            // 
            lblModuleName.AutoSize = true;
            lblModuleName.Location = new Point(3, 36);
            lblModuleName.Name = "lblModuleName";
            lblModuleName.Size = new Size(104, 20);
            lblModuleName.TabIndex = 1;
            lblModuleName.Text = "Module Name";
            // 
            // pnlInputs
            // 
            pnlInputs.BackColor = Color.White;
            pnlInputs.Controls.Add(cmbCourse);
            pnlInputs.Controls.Add(lblCourse);
            pnlInputs.Controls.Add(txtModuleName);
            pnlInputs.Controls.Add(lblModuleName);
            pnlInputs.Dock = DockStyle.Right;
            pnlInputs.Location = new Point(798, 125);
            pnlInputs.Name = "pnlInputs";
            pnlInputs.Size = new Size(262, 328);
            pnlInputs.TabIndex = 2;
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(99, 69);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(151, 28);
            cmbCourse.TabIndex = 4;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCourse.Location = new Point(18, 72);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(63, 23);
            lblCourse.TabIndex = 3;
            lblCourse.Text = "Course";
            // 
            // txtModuleName
            // 
            txtModuleName.AcceptsTab = true;
            txtModuleName.BorderStyle = BorderStyle.FixedSingle;
            txtModuleName.Location = new Point(113, 29);
            txtModuleName.Name = "txtModuleName";
            txtModuleName.Size = new Size(146, 27);
            txtModuleName.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(38, 400);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Orange;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(160, 400);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(288, 400);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(425, 400);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvModule
            // 
            dgvModule.AllowUserToOrderColumns = true;
            dgvModule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvModule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvModule.Location = new Point(20, 158);
            dgvModule.Name = "dgvModule";
            dgvModule.RowHeadersWidth = 51;
            dgvModule.Size = new Size(558, 207);
            dgvModule.TabIndex = 7;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.MediumAquamarine;
            btnBack.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.InactiveCaptionText;
            btnBack.Location = new Point(569, 403);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(175, 29);
            btnBack.TabIndex = 8;
            btnBack.Text = "← Dashboard";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ModuleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1060, 453);
            Controls.Add(btnBack);
            Controls.Add(dgvModule);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(pnlInputs);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(800, 500);
            Name = "ModuleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Module Management";
            Load += ModuleForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlInputs.ResumeLayout(false);
            pnlInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvModule).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblModuleName;
        private Panel pnlInputs;
        private TextBox txtModuleName;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvModule;
        private ComboBox cmbCourse;
        private Label lblCourse;
        private Button btnBack;
    }
}