using System;
using System.Windows.Forms;

namespace Asignment_2
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtClass.Text))
            {
                MessageBox.Show("Name and Class cannot be empty!");
                return;
            }

            Student student = new Student()
            {
                Name = txtName.Text,
                Class = txtClass.Text,
                Age = int.TryParse(txtAge.Text, out int a) ? a : 0
            };

            StudentData.Students.Add(student);
            MessageBox.Show("Student Added Successfully!");
            this.Close();
        }
    }
}
