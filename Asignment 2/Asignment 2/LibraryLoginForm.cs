using System;
using System.Windows.Forms;

namespace Asignment_2
{
    public partial class LibraryLoginForm : Form
    {
        public LibraryLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "123")
            {
                MessageBox.Show("Login Successful!");
                LibraryDashboard dash = new LibraryDashboard();
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }
        }

        private void LibraryLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
