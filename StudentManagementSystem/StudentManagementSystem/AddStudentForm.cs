using System;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
            btnsave.Click += btnsave_Click; // Save button ka event
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            // Textboxes se data lena
            string name = txtName.Text.Trim();
            string ageText = txtAge.Text.Trim();
            string studentClass = txtClass.Text.Trim();

            // Validation check
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(ageText) || string.IsNullOrEmpty(studentClass))
            {
                MessageBox.Show("Please fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Age ko number me convert karna
            if (!int.TryParse(ageText, out int age))
            {
                MessageBox.Show("Age must be a valid number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Student object banana
            Student newStudent = new Student
            {
                Name = name,
                Age = age,
                Class = studentClass
            };

            // List me add karna (DashboardForm ki static list)
            DashboardForm.Students.Add(newStudent);

            MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Fields clear karna
            txtName.Clear();
            txtAge.Clear();
            txtClass.Clear();
        }
    }
}
