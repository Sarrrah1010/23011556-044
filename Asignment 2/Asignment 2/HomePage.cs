using System;
using System.Windows.Forms;

namespace Asignment_2
{
    public partial class HomePage : Form
    {
        private LoginForm loginForm;

        public HomePage(LoginForm login, string username)
        {
            InitializeComponent();
            loginForm = login;
            lblWelcome.Text = "Welcome, " + username + "!";
        }

        private void btnOpenStudentManagement_Click(object sender, EventArgs e)
        {
            StudentDashboardForm dashboard = new StudentDashboardForm();
            dashboard.Show();
        }

        private void btnOpenCalculator_Click(object sender, EventArgs e)
        {
            CalculatorForm calc = new CalculatorForm();
            calc.Show();
        }

        private void btnOpenLibrary_Click(object sender, EventArgs e)
        {
            LibraryLoginForm libLogin = new LibraryLoginForm();
            libLogin.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }
    }
}
