using System;
using System.Windows.Forms;

namespace Asignment_2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Null check remove kar do, TextBoxes designer se initialized hain
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "1234")
            {
                HomePage home = new HomePage(this, username);
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
