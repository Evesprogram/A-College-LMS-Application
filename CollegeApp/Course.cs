using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace CollegeApp
{
    public partial class CourseForm : Form
    {
        private int selectedCourseID = 0;

        public CourseForm()
        {
            InitializeComponent();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            LoadDepartments();
            LoadCourses();
        }

        private void LoadDepartments()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT DepartmentID, DepartmentName FROM Department", con);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbDepartment.DataSource = dt;
                    cmbDepartment.DisplayMember = "DepartmentName";
                    cmbDepartment.ValueMember = "DepartmentID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading departments: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCourses()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    string query = @"SELECT CourseID, CourseName, DepartmentName 
                                     FROM Course 
                                     INNER JOIN Department ON Course.DepartmentID = Department.DepartmentID";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvCourse.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCourseName.Text))
            {
                MessageBox.Show("Please enter a course name.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbDepartment.SelectedValue == null)
            {
                MessageBox.Show("Please select a department.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    string query = "INSERT INTO Course (CourseName, DepartmentID) VALUES (@Name, @Dept)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtCourseName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Dept", cmbDepartment.SelectedValue);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Course added successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadCourses();        // Refresh grid
                txtCourseName.Clear(); // Optional: clear after add
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding course: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCourseID == 0)
            {
                MessageBox.Show("Please select a course to update first.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCourseName.Text))
            {
                MessageBox.Show("Please enter a course name.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    string query = "UPDATE Course SET CourseName=@Name, DepartmentID=@Dept WHERE CourseID=@ID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtCourseName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Dept", cmbDepartment.SelectedValue ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ID", selectedCourseID);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Course updated successfully.", "Success");
                            LoadCourses();
                        }
                        else
                        {
                            MessageBox.Show("No course was updated.", "Warning");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating course: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCourseID == 0)
            {
                MessageBox.Show("Please select a course to delete first.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this course?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM Course WHERE CourseID=@ID", con))
                        {
                            cmd.Parameters.AddWithValue("@ID", selectedCourseID);

                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Course deleted successfully.", "Success");
                    LoadCourses();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting course: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtCourseName.Clear();
            cmbDepartment.SelectedIndex = -1;
            selectedCourseID = 0;
        }

        private void dgvCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvCourse.Rows[e.RowIndex];

                    selectedCourseID = Convert.ToInt32(row.Cells["CourseID"].Value);
                    txtCourseName.Text = row.Cells["CourseName"].Value?.ToString() ?? "";

                    // Optional improvement: Select correct department in combo box
                    if (row.Cells["DepartmentName"].Value != null)
                    {
                        // This is tricky with joined data - we'll improve this later if needed
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error selecting course: " + ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();   // Simple close is fine for now
        }
    }
}