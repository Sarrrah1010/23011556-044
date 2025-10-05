using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class DashboardForm : Form
    {
        public static List<Student> Students = new List<Student>();

        public DashboardForm()
        {
            InitializeComponent();

            // Event linking safely
            btnAddStudent.Click += btnAddStudent_Click;
            btnViewStudent.Click += btnViewStudents_Click;
            btnExit.Click += btnExit_Click;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm addForm = new AddStudentForm();
            addForm.ShowDialog();
        }

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            ViewStudentsForm viewForm = new ViewStudentsForm();
            viewForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
