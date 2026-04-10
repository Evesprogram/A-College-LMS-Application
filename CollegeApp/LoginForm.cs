using System;
using System.Drawing;
using System.Windows.Forms;

namespace CollegeApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "College Management System - Login";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Simple credentials (you can later move this to DB with hashed passwords)
            bool isValid = (username == "admin" && password == "admin") ||
                           (username == "lecturer" && password == "lecturer");

            if (isValid)
            {
                MessageBox.Show($"Welcome, {username.ToUpper()}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DashboardForm dashboard = new DashboardForm();
                this.Hide();
                dashboard.ShowDialog();
                this.Close(); // close login after dashboard is closed
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}