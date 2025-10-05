using LoginApp;
using System;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class HomePage : Form
    {
        private string username;

        public HomePage(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + username + "!";
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Profile Page - coming soon!");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings Page - coming soon!");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close(); // Close HomePage
        }
    }
}
