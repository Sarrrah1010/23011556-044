using System;
using System.Windows.Forms;

namespace Asignment_2
{
    public partial class StudentDashboardForm : Form
    {
        public StudentDashboardForm()
        {
            InitializeComponent();
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
            this.Close();
        }
    }
}
