using System;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            button1.Click += button1_Click; // login button event link
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Simple login check
            if (username == "admin" && password == "123")
            {
                // Hide login and show dashboard
                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();
                this.Hide(); // Login form hide ho jata hai
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
