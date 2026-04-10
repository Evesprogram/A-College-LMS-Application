using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CollegeApp
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

            this.BackgroundImage = Properties.Resources.DashboardBg;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Panel styling
            SetupPanelColorsAndHover();

            // Make labels clickable too
            lblStudents.Click += pnlStudents_Click;
            lblStudentsDesc.Click += pnlStudents_Click;
            // ... (repeat for all other labels like before)

            LoadDashboardStats();   // ← New
        }

        private void SetupPanelColorsAndHover()
        {
            // Reset colors
            pnlStudents.BackColor = Color.White;
            pnlCourse.BackColor = Color.White;
            pnlModule.BackColor = Color.White;
            pnlLecturer.BackColor = Color.White;
            pnlDepartment.BackColor = Color.White;

            // Hover events (fixed - subscriptions only once!)
            pnlStudents.MouseEnter += Panel_MouseEnter;
            pnlStudents.MouseLeave += Panel_MouseLeave;
            pnlCourse.MouseEnter += Panel_MouseEnter;
            pnlCourse.MouseLeave += Panel_MouseLeave;
            pnlModule.MouseEnter += Panel_MouseEnter;
            pnlModule.MouseLeave += Panel_MouseLeave;
            pnlLecturer.MouseEnter += Panel_MouseEnter;
            pnlLecturer.MouseLeave += Panel_MouseLeave;
            pnlDepartment.MouseEnter += Panel_MouseEnter;
            pnlDepartment.MouseLeave += Panel_MouseLeave;
        }

        private void LoadDashboardStats()
        {
            using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                con.Open();
                var cmd = new SqlCommand(@"
                    SELECT 
                        (SELECT COUNT(*) FROM Student) AS TotalStudents,
                        (SELECT COUNT(*) FROM Course) AS TotalCourses,
                        (SELECT COUNT(*) FROM Module) AS TotalModules,
                        (SELECT COUNT(*) FROM Lecturer) AS TotalLecturers,
                        (SELECT COUNT(*) FROM Department) AS TotalDepartments", con);

                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        // You can add these labels in the designer if you want, or just use MessageBox for now
                        // For now we'll show in footer for simplicity
                        lblFooter.Text = $"© 2026 Eva Tsatsi - College Management System | " +
                                         $"Students: {r["TotalStudents"]} | " +
                                         $"Courses: {r["TotalCourses"]} | " +
                                         $"Modules: {r["TotalModules"]}";
                    }
                }
            }
        }

        // Hover methods (unchanged)
        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Panel p) p.BackColor = Color.FromArgb(230, 240, 255);
        }

        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Panel p) p.BackColor = Color.White;
        }

        // Click events remain the same...
        private void pnlStudents_Click(object? sender, EventArgs e) => new Student().Show();
        private void pnlCourse_Click(object sender, EventArgs e) => new CourseForm().Show();
        private void pnlModule_Click(object sender, EventArgs e) => new ModuleForm().Show();
        private void pnlLecturer_Click(object? sender, EventArgs e) => new LecturerForm().Show();
        private void pnlDepartment_Click(object? sender, EventArgs e) => new DepartmentForm().Show();
    }
}