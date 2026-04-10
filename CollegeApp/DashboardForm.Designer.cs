namespace CollegeApp
{
    partial class DashboardForm
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
            label6 = new Label();
            label1 = new Label();
            pnlStudents = new Panel();
            button1 = new Button();
            lblStudents = new Label();
            lblStudentsDesc = new Label();
            pnlDepartment = new Panel();
            lblDepartmentDesc = new Label();
            lblDepartment = new Label();
            pnlLecturer = new Panel();
            lblLecturerDesc = new Label();
            lblLecturer = new Label();
            pnlCourse = new Panel();
            lblCourseDesc = new Label();
            lblCourse = new Label();
            pnlModule = new Panel();
            lblModule = new Label();
            lblModuleDesc = new Label();
            pnlFooter = new Panel();
            lblFooter = new Label();
            pnlHeader.SuspendLayout();
            pnlStudents.SuspendLayout();
            pnlDepartment.SuspendLayout();
            pnlLecturer.SuspendLayout();
            pnlCourse.SuspendLayout();
            pnlModule.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Teal;
            pnlHeader.Controls.Add(label6);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Cursor = Cursors.Hand;
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 3, 4, 3);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(10);
            pnlHeader.Size = new Size(1570, 130);
            pnlHeader.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(681, 89);
            label6.Name = "label6";
            label6.Size = new Size(325, 23);
            label6.TabIndex = 6;
            label6.Text = "Welcome Please Select a Module Below";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(542, 29);
            label1.Name = "label1";
            label1.Size = new Size(485, 41);
            label1.TabIndex = 5;
            label1.Text = " 🏫 College Management System";
            // 
            // pnlStudents
            // 
            pnlStudents.BackColor = Color.White;
            pnlStudents.BorderStyle = BorderStyle.FixedSingle;
            pnlStudents.Controls.Add(button1);
            pnlStudents.Controls.Add(lblStudents);
            pnlStudents.Controls.Add(lblStudentsDesc);
            pnlStudents.Cursor = Cursors.Hand;
            pnlStudents.Location = new Point(13, 227);
            pnlStudents.Margin = new Padding(4, 3, 4, 3);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new Size(261, 130);
            pnlStudents.TabIndex = 0;
            pnlStudents.Click += pnlStudents_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(61, 129);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Open";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblStudents
            // 
            lblStudents.AutoSize = true;
            lblStudents.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudents.ForeColor = SystemColors.GrayText;
            lblStudents.Location = new Point(41, 63);
            lblStudents.Name = "lblStudents";
            lblStudents.Size = new Size(148, 23);
            lblStudents.TabIndex = 6;
            lblStudents.Text = "Manage Student ";
            // 
            // lblStudentsDesc
            // 
            lblStudentsDesc.AutoSize = true;
            lblStudentsDesc.BorderStyle = BorderStyle.FixedSingle;
            lblStudentsDesc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentsDesc.Location = new Point(40, 7);
            lblStudentsDesc.Name = "lblStudentsDesc";
            lblStudentsDesc.Size = new Size(125, 30);
            lblStudentsDesc.TabIndex = 5;
            lblStudentsDesc.Text = "🎓Students";
            // 
            // pnlDepartment
            // 
            pnlDepartment.BackColor = Color.White;
            pnlDepartment.BorderStyle = BorderStyle.FixedSingle;
            pnlDepartment.Controls.Add(lblDepartmentDesc);
            pnlDepartment.Controls.Add(lblDepartment);
            pnlDepartment.Cursor = Cursors.Hand;
            pnlDepartment.Location = new Point(1307, 227);
            pnlDepartment.Margin = new Padding(4, 3, 4, 3);
            pnlDepartment.Name = "pnlDepartment";
            pnlDepartment.Size = new Size(250, 125);
            pnlDepartment.TabIndex = 1;
            pnlDepartment.Click += pnlDepartment_Click;
            // 
            // lblDepartmentDesc
            // 
            lblDepartmentDesc.AutoSize = true;
            lblDepartmentDesc.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDepartmentDesc.ForeColor = Color.Gray;
            lblDepartmentDesc.Location = new Point(50, 67);
            lblDepartmentDesc.Name = "lblDepartmentDesc";
            lblDepartmentDesc.Size = new Size(184, 23);
            lblDepartmentDesc.TabIndex = 7;
            lblDepartmentDesc.Text = "Manage Departments";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.BorderStyle = BorderStyle.FixedSingle;
            lblDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDepartment.Location = new Point(48, 11);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(163, 30);
            lblDepartment.TabIndex = 6;
            lblDepartment.Text = "🏢 Department";
            // 
            // pnlLecturer
            // 
            pnlLecturer.BackColor = Color.White;
            pnlLecturer.BorderStyle = BorderStyle.FixedSingle;
            pnlLecturer.Controls.Add(lblLecturerDesc);
            pnlLecturer.Controls.Add(lblLecturer);
            pnlLecturer.Cursor = Cursors.Hand;
            pnlLecturer.Location = new Point(984, 227);
            pnlLecturer.Margin = new Padding(4, 3, 4, 3);
            pnlLecturer.Name = "pnlLecturer";
            pnlLecturer.Size = new Size(272, 125);
            pnlLecturer.TabIndex = 2;
            pnlLecturer.Click += pnlLecturer_Click;
            // 
            // lblLecturerDesc
            // 
            lblLecturerDesc.AutoSize = true;
            lblLecturerDesc.FlatStyle = FlatStyle.System;
            lblLecturerDesc.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLecturerDesc.ForeColor = SystemColors.GrayText;
            lblLecturerDesc.Location = new Point(49, 67);
            lblLecturerDesc.Name = "lblLecturerDesc";
            lblLecturerDesc.Size = new Size(152, 23);
            lblLecturerDesc.TabIndex = 1;
            lblLecturerDesc.Text = "Manage Lecturers";
            lblLecturerDesc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLecturer
            // 
            lblLecturer.AutoSize = true;
            lblLecturer.BorderStyle = BorderStyle.FixedSingle;
            lblLecturer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLecturer.Location = new Point(49, 11);
            lblLecturer.Name = "lblLecturer";
            lblLecturer.Size = new Size(126, 30);
            lblLecturer.TabIndex = 0;
            lblLecturer.Text = " 👩‍🏫Lecturer";
            lblLecturer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCourse
            // 
            pnlCourse.BackColor = Color.White;
            pnlCourse.BorderStyle = BorderStyle.FixedSingle;
            pnlCourse.Controls.Add(lblCourseDesc);
            pnlCourse.Controls.Add(lblCourse);
            pnlCourse.Cursor = Cursors.Hand;
            pnlCourse.Location = new Point(339, 227);
            pnlCourse.Margin = new Padding(4, 3, 4, 3);
            pnlCourse.Name = "pnlCourse";
            pnlCourse.Size = new Size(250, 125);
            pnlCourse.TabIndex = 4;
            pnlCourse.Click += pnlCourse_Click;
            // 
            // lblCourseDesc
            // 
            lblCourseDesc.AutoSize = true;
            lblCourseDesc.ForeColor = Color.Gray;
            lblCourseDesc.Location = new Point(43, 60);
            lblCourseDesc.Name = "lblCourseDesc";
            lblCourseDesc.Size = new Size(140, 23);
            lblCourseDesc.TabIndex = 8;
            lblCourseDesc.Text = "Manage Courses";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.BorderStyle = BorderStyle.FixedSingle;
            lblCourse.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCourse.Location = new Point(43, 7);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(118, 30);
            lblCourse.TabIndex = 7;
            lblCourse.Text = "  📚Course";
            lblCourse.Click += pnlCourse_Click;
            // 
            // pnlModule
            // 
            pnlModule.BackColor = Color.White;
            pnlModule.BorderStyle = BorderStyle.FixedSingle;
            pnlModule.Controls.Add(lblModule);
            pnlModule.Controls.Add(lblModuleDesc);
            pnlModule.Location = new Point(648, 227);
            pnlModule.Name = "pnlModule";
            pnlModule.Size = new Size(296, 125);
            pnlModule.TabIndex = 5;
            pnlModule.Click += pnlModule_Click;
            // 
            // lblModule
            // 
            lblModule.AutoSize = true;
            lblModule.BorderStyle = BorderStyle.FixedSingle;
            lblModule.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModule.Location = new Point(73, 10);
            lblModule.Name = "lblModule";
            lblModule.Size = new Size(120, 30);
            lblModule.TabIndex = 1;
            lblModule.Text = "📖 Module";
            lblModule.Click += pnlModule_Click;
            // 
            // lblModuleDesc
            // 
            lblModuleDesc.AutoSize = true;
            lblModuleDesc.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModuleDesc.ForeColor = Color.Gray;
            lblModuleDesc.Location = new Point(61, 64);
            lblModuleDesc.Name = "lblModuleDesc";
            lblModuleDesc.Size = new Size(147, 23);
            lblModuleDesc.TabIndex = 0;
            lblModuleDesc.Text = "Manage Modules";
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.DimGray;
            pnlFooter.Controls.Add(lblFooter);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 503);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1570, 50);
            pnlFooter.TabIndex = 6;
            // 
            // lblFooter
            // 
            lblFooter.BackColor = Color.Teal;
            lblFooter.Dock = DockStyle.Fill;
            lblFooter.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFooter.ForeColor = Color.White;
            lblFooter.Location = new Point(0, 0);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(1570, 50);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "© 2026 Eva Tsatsi - College Management System";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            BackgroundImage = Properties.Resources.DashboardBg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1570, 553);
            Controls.Add(pnlStudents);
            Controls.Add(pnlCourse);
            Controls.Add(pnlModule);
            Controls.Add(pnlLecturer);
            Controls.Add(pnlDepartment);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            Cursor = Cursors.AppStarting;
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4, 3, 4, 3);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "College Management System";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlStudents.ResumeLayout(false);
            pnlStudents.PerformLayout();
            pnlDepartment.ResumeLayout(false);
            pnlDepartment.PerformLayout();
            pnlLecturer.ResumeLayout(false);
            pnlLecturer.PerformLayout();
            pnlCourse.ResumeLayout(false);
            pnlCourse.PerformLayout();
            pnlModule.ResumeLayout(false);
            pnlModule.PerformLayout();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlHeader;
        private Label label1;
        private Label label6;
        private Panel pnlStudents;
        private Button button1;
        private Label lblStudents;
        private Label lblStudentsDesc;
        private Panel pnlDepartment;
        private Label lblDepartmentDesc;
        private Label lblDepartment;
        private Panel pnlLecturer;
        private Label lblLecturerDesc;
        private Label lblLecturer;
        private Panel pnlCourse;
        private Label lblCourseDesc;
        private Label lblCourse;
        private Panel pnlModule;
        private Label lblModule;
        private Label lblModuleDesc;
        private Panel pnlFooter;
        private Label lblFooter;
    }
}