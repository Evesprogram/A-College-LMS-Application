using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace CollegeApp
{
    public partial class ModuleForm : Form
    {
        private int selectedModuleID = 0;

        public ModuleForm()
        {
            InitializeComponent();
        }

        private void ModuleForm_Load(object sender, EventArgs e)
        {
            LoadCourses();
            LoadModules();        // Auto load when form opens
        }

        private void LoadCourses()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT CourseID, CourseName FROM Course ORDER BY CourseName", con);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbCourse.DataSource = dt;
                    cmbCourse.DisplayMember = "CourseName";
                    cmbCourse.ValueMember = "CourseID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message, "Database Error");
            }
        }

        private void LoadModules()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    string query = @"
                        SELECT ModuleID, ModuleName, Credits, CourseName 
                        FROM Module 
                        ORDER BY ModuleName";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvModule.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading modules: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtModuleName.Text))
            {
                MessageBox.Show("Please enter a module name.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCourse.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a course.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    string query = @"INSERT INTO Module (ModuleName, Credits, CourseName) 
                                     VALUES (@Name, @Credits, @CourseName)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtModuleName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Credits", 3);                    // You can change default later
                        cmd.Parameters.AddWithValue("@CourseName", cmbCourse.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Module added successfully!", "Success");
                LoadModules();
                txtModuleName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding module: " + ex.Message, "Error");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedModuleID == 0)
            {
                MessageBox.Show("Please select a module to update first.", "Warning");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtModuleName.Text))
            {
                MessageBox.Show("Please enter a module name.", "Validation");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    string query = @"UPDATE Module 
                                     SET ModuleName = @Name, 
                                         Credits = @Credits, 
                                         CourseName = @CourseName 
                                     WHERE ModuleID = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtModuleName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Credits", 3);           // You can make this editable later
                        cmd.Parameters.AddWithValue("@CourseName", cmbCourse.Text);
                        cmd.Parameters.AddWithValue("@ID", selectedModuleID);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Module updated successfully!", "Success");
                LoadModules();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating module: " + ex.Message, "Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedModuleID == 0)
            {
                MessageBox.Show("Please select a module to delete first.", "Warning");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this module?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(DatabaseHelper.ConnectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM Module WHERE ModuleID=@ID", con))
                        {
                            cmd.Parameters.AddWithValue("@ID", selectedModuleID);
                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Module deleted successfully!", "Success");
                    LoadModules();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting module: " + ex.Message, "Error");
                }
            }
        }

        private void dgvModule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvModule.Rows[e.RowIndex];

                    selectedModuleID = Convert.ToInt32(row.Cells["ModuleID"].Value);
                    txtModuleName.Text = row.Cells["ModuleName"].Value?.ToString() ?? "";

                    // Select correct course in ComboBox
                    string courseName = row.Cells["CourseName"].Value?.ToString() ?? "";
                    cmbCourse.Text = courseName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error selecting module: " + ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtModuleName.Clear();
            cmbCourse.SelectedIndex = -1;
            selectedModuleID = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}