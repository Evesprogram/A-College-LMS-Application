namespace CollegeApp
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            labelTitle = new Label();
            panelLogin = new Panel();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnCancel = new Button();
            panelLogin.SuspendLayout();
            SuspendLayout();

            // labelTitle
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.Teal;
            labelTitle.Location = new Point(80, 40);
            labelTitle.Size = new Size(340, 45);
            labelTitle.Text = "🏫 College Management System";

            // panelLogin
            panelLogin.BackColor = Color.White;
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(lblUsername);
            panelLogin.Controls.Add(txtUsername);
            panelLogin.Controls.Add(lblPassword);
            panelLogin.Controls.Add(txtPassword);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(btnCancel);
            panelLogin.Location = new Point(100, 120);
            panelLogin.Size = new Size(400, 280);
            panelLogin.TabIndex = 0;

            // lblUsername / lblPassword
            lblUsername.AutoSize = true; lblUsername.Location = new Point(40, 40); lblUsername.Text = "Username";
            lblPassword.AutoSize = true; lblPassword.Location = new Point(40, 110); lblPassword.Text = "Password";

            // txtUsername / txtPassword
            txtUsername.Location = new Point(40, 65); txtUsername.Size = new Size(320, 30);
            txtPassword.Location = new Point(40, 135); txtPassword.Size = new Size(320, 30);
            txtPassword.PasswordChar = '●';

            // buttons
            btnLogin.BackColor = Color.Teal; btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat; btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.Location = new Point(40, 190); btnLogin.Size = new Size(140, 40);
            btnLogin.Text = "LOGIN"; btnLogin.Click += btnLogin_Click;

            btnCancel.BackColor = Color.LightGray;
            btnCancel.Location = new Point(220, 190); btnCancel.Size = new Size(140, 40);
            btnCancel.Text = "CANCEL"; btnCancel.Click += btnCancel_Click;

            // Form
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 248, 255);
            ClientSize = new Size(600, 450);
            Controls.Add(labelTitle);
            Controls.Add(panelLogin);
            Name = "LoginForm";
            panelLogin.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Label labelTitle;
        private Panel panelLogin;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnCancel;
    }
}