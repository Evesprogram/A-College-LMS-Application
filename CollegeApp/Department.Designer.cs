namespace CollegeApp
{
    partial class DepartmentForm
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
            label1 = new Label();
            dgvDepartment = new DataGridView();
            pnlInputs = new Panel();
            txtBuilding = new TextBox();
            txtDepartmentName = new TextBox();
            lblDepartmentName = new Label();
            lblBuilding = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            btnBack = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).BeginInit();
            pnlInputs.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.BlueViolet;
            pnlHeader.Controls.Add(label1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1118, 125);
            pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 18);
            label1.Name = "label1";
            label1.Size = new Size(292, 31);
            label1.TabIndex = 0;
            label1.Text = "Department Management";
            // 
            // dgvDepartment
            // 
            dgvDepartment.AllowUserToOrderColumns = true;
            dgvDepartment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartment.Location = new Point(20, 169);
            dgvDepartment.Name = "dgvDepartment";
            dgvDepartment.RowHeadersWidth = 51;
            dgvDepartment.Size = new Size(598, 188);
            dgvDepartment.TabIndex = 1;
            dgvDepartment.CellClick += dgvDepartment_CellClick;
            dgvDepartment.Click += DepartmentForm_Load;
            // 
            // pnlInputs
            // 
            pnlInputs.BackColor = Color.White;
            pnlInputs.Controls.Add(txtBuilding);
            pnlInputs.Controls.Add(txtDepartmentName);
            pnlInputs.Controls.Add(lblDepartmentName);
            pnlInputs.Controls.Add(lblBuilding);
            pnlInputs.Dock = DockStyle.Right;
            pnlInputs.Location = new Point(803, 125);
            pnlInputs.Name = "pnlInputs";
            pnlInputs.Size = new Size(315, 374);
            pnlInputs.TabIndex = 2;
            // 
            // txtBuilding
            // 
            txtBuilding.Location = new Point(16, 122);
            txtBuilding.Name = "txtBuilding";
            txtBuilding.Size = new Size(163, 27);
            txtBuilding.TabIndex = 3;
            // 
            // txtDepartmentName
            // 
            txtDepartmentName.Location = new Point(24, 44);
            txtDepartmentName.Name = "txtDepartmentName";
            txtDepartmentName.Size = new Size(125, 27);
            txtDepartmentName.TabIndex = 2;
            // 
            // lblDepartmentName
            // 
            lblDepartmentName.AutoSize = true;
            lblDepartmentName.Location = new Point(16, 21);
            lblDepartmentName.Name = "lblDepartmentName";
            lblDepartmentName.Size = new Size(133, 20);
            lblDepartmentName.TabIndex = 1;
            lblDepartmentName.Text = "Department Name";
            // 
            // lblBuilding
            // 
            lblBuilding.AutoSize = true;
            lblBuilding.Location = new Point(24, 90);
            lblBuilding.Name = "lblBuilding";
            lblBuilding.Size = new Size(64, 20);
            lblBuilding.TabIndex = 0;
            lblBuilding.Text = "Building";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(12, 395);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.UseWaitCursor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(274, 395);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MediumOrchid;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(136, 395);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Orange;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(414, 395);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.MediumPurple;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(12, 439);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(143, 37);
            btnBack.TabIndex = 7;
            btnBack.Text = "⬅️ Dashboard";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // DepartmentForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1118, 499);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(pnlInputs);
            Controls.Add(dgvDepartment);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(800, 500);
            Name = "DepartmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Department Management";
            Load += DepartmentForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).EndInit();
            pnlInputs.ResumeLayout(false);
            pnlInputs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private DataGridView dgvDepartment;
        private Panel pnlInputs;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClear;
        private TextBox txtBuilding;
        private TextBox txtDepartmentName;
        private Label lblDepartmentName;
        private Label lblBuilding;
        private Button btnBack;
    }
}