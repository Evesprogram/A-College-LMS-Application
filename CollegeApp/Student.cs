using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CollegeApp
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            LoadStudents();

            // Grid styling
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.MultiSelect = false;
            dgvStudents.ReadOnly = true;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.RowHeadersVisible = false;

            dgvStudents.EnableHeadersVisualStyles = false;
            dgvStudents.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgvStudents.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvStudents.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgvStudents.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvStudents.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvStudents.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvStudents.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
        }

        private void LoadStudents()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    string query = "SELECT StudentID, FirstName, LastName, Age, CourseName FROM Student";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvStudents.DataSource = table;
                    UpdateTotalStudents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First Name is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    string query = @"INSERT INTO Student (FirstName, LastName, Age, CourseName) 
                                     VALUES (@first, @last, @age, @course)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@first", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@last", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@age", string.IsNullOrWhiteSpace(txtAge.Text) ? DBNull.Value : txtAge.Text.Trim());
                        cmd.Parameters.AddWithValue("@course", txtCourseName.Text.Trim());

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Student added successfully!", "Success");
                LoadStudents();        // Refresh + update total
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding student: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                MessageBox.Show("Please select a student to update first.", "Warning");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    string query = @"UPDATE Student 
                                     SET FirstName=@first, LastName=@last, Age=@age, CourseName=@course 
                                     WHERE StudentID=@id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", txtStudentID.Text);
                        cmd.Parameters.AddWithValue("@first", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@last", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@age", string.IsNullOrWhiteSpace(txtAge.Text) ? DBNull.Value : txtAge.Text.Trim());
                        cmd.Parameters.AddWithValue("@course", txtCourseName.Text.Trim());

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Student updated successfully!", "Success");
                LoadStudents();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                MessageBox.Show("Please select a student to delete first.", "Warning");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this student?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM Student WHERE StudentID=@id", conn))
                        {
                            cmd.Parameters.AddWithValue("@id", txtStudentID.Text);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Student deleted successfully!", "Success");
                    LoadStudents();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting student: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

                    txtStudentID.Text = row.Cells["StudentID"].Value?.ToString() ?? "";
                    txtFirstName.Text = row.Cells["FirstName"].Value?.ToString() ?? "";
                    txtLastName.Text = row.Cells["LastName"].Value?.ToString() ?? "";
                    txtAge.Text = row.Cells["Age"].Value?.ToString() ?? "";
                    txtCourseName.Text = row.Cells["CourseName"].Value?.ToString() ?? "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error selecting student: " + ex.Message);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                LoadStudents();
            }
            else
            {
                SearchStudent();
            }
        }

        private void SearchStudent()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    string query = @"SELECT StudentID, FirstName, LastName, Age, CourseName FROM Student
                                     WHERE FirstName LIKE @search 
                                        OR LastName LIKE @search 
                                        OR CourseName LIKE @search";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text.Trim() + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dgvStudents.DataSource = table;
                    }
                }

                UpdateTotalStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching students: " + ex.Message, "Error");
            }
        }

        private void UpdateTotalStudents()
        {
            int total = dgvStudents.Rows.Count;
            if (dgvStudents.AllowUserToAddRows && total > 0)
                total--;

            lblTotal.Text = $"Total Students: {total}";
        }

        private void ClearFields()
        {
            txtStudentID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAge.Clear();
            txtCourseName.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}