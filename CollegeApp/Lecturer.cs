using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace CollegeApp
{
    public partial class LecturerForm : Form
    {
        private int selectedLecturerID = 0;

        public LecturerForm()
        {
            InitializeComponent();
        }

        private void LecturerForm_Load(object sender, EventArgs e)
        {
            LoadLecturers();        // Auto load when form opens
        }

        private void LoadLecturers()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    string query = "SELECT LecturerID, FirstName, LastName FROM Lecturer";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvLecturer.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading lecturers: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter both First Name and Last Name.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    string query = "INSERT INTO Lecturer (FirstName, LastName) VALUES (@F, @L)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@F", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@L", txtLastName.Text.Trim());

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Lecturer added successfully!", "Success");
                LoadLecturers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding lecturer: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedLecturerID == 0)
            {
                MessageBox.Show("Please select a lecturer to update first.", "Warning");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter both First Name and Last Name.", "Validation");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    string query = "UPDATE Lecturer SET FirstName=@F, LastName=@L WHERE LecturerID=@ID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@F", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@L", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@ID", selectedLecturerID);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Lecturer updated successfully!", "Success");
                LoadLecturers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating lecturer: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedLecturerID == 0)
            {
                MessageBox.Show("Please select a lecturer to delete first.", "Warning");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this lecturer?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM Lecturer WHERE LecturerID=@ID", con))
                        {
                            cmd.Parameters.AddWithValue("@ID", selectedLecturerID);
                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Lecturer deleted successfully!", "Success");
                    LoadLecturers();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting lecturer: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvLecturer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvLecturer.Rows[e.RowIndex];

                    selectedLecturerID = Convert.ToInt32(row.Cells["LecturerID"].Value);
                    txtFirstName.Text = row.Cells["FirstName"].Value?.ToString() ?? "";
                    txtLastName.Text = row.Cells["LastName"].Value?.ToString() ?? "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error selecting lecturer: " + ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            selectedLecturerID = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}