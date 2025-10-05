using System.Windows.Forms;
using System.Drawing;

namespace Asignment_2
{
    partial class StudentDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnAddStudent = new Button();
            btnViewStudents = new Button();
            btnExit = new Button();
            SuspendLayout();

            // btnAddStudent
            btnAddStudent.Text = "Add Student";
            btnAddStudent.Size = new Size(200, 50);
            btnAddStudent.Location = new Point(50, 30);
            btnAddStudent.Click += btnAddStudent_Click;

            // btnViewStudents
            btnViewStudents.Text = "View Students";
            btnViewStudents.Size = new Size(200, 50);
            btnViewStudents.Location = new Point(50, 100);
            btnViewStudents.Click += btnViewStudents_Click;

            // btnExit
            btnExit.Text = "Exit";
            btnExit.Size = new Size(200, 50);
            btnExit.Location = new Point(50, 170);
            btnExit.Click += btnExit_Click;

            this.ClientSize = new Size(300, 250);
            this.Controls.Add(btnAddStudent);
            this.Controls.Add(btnViewStudents);
            this.Controls.Add(btnExit);
            this.Text = "Student Dashboard";
            ResumeLayout(false);
        }

        private Button btnAddStudent;
        private Button btnViewStudents;
        private Button btnExit;
    }
}
