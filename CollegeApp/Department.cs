using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace CollegeApp
{
    public partial class DepartmentForm : Form
    {
        private int selectedDepartmentID = 0;

        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            LoadDepartments();           // Auto load when form opens
        }

        private void LoadDepartments()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    string query = "SELECT DepartmentID, DepartmentName, Building FROM Department";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvDepartment.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading departments: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDepartmentName.Text))
            {
                MessageBox.Show("Please enter a department name.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    string query = "INSERT INTO Department (DepartmentName, Building) VALUES (@Name, @Building)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtDepartmentName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Building", txtBuilding.Text.Trim());

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Department added successfully!", "Success");
                LoadDepartments();     // Refresh grid
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding department: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedDepartmentID == 0)
            {
                MessageBox.Show("Please select a department to update first.", "Warning");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    string query = @"UPDATE Department 
                                     SET DepartmentName = @Name, Building = @Building 
                                     WHERE DepartmentID = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtDepartmentName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Building", txtBuilding.Text.Trim());
                        cmd.Parameters.AddWithValue("@ID", selectedDepartmentID);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Department updated successfully!", "Success");
                LoadDepartments();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating department: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedDepartmentID == 0)
            {
                MessageBox.Show("Please select a department to delete first.", "Warning");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this department?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM Department WHERE DepartmentID=@ID", con))
                        {
                            cmd.Parameters.AddWithValue("@ID", selectedDepartmentID);
                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Department deleted successfully!", "Success");
                    LoadDepartments();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting department: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvDepartment.Rows[e.RowIndex];

                    selectedDepartmentID = Convert.ToInt32(row.Cells["DepartmentID"].Value);
                    txtDepartmentName.Text = row.Cells["DepartmentName"].Value?.ToString() ?? "";
                    txtBuilding.Text = row.Cells["Building"].Value?.ToString() ?? "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading row: " + ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtDepartmentName.Clear();
            txtBuilding.Clear();
            selectedDepartmentID = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}