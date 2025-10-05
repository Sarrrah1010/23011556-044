using System;
using System.Windows.Forms;

namespace Asignment_2
{
    public partial class ViewStudentsForm : Form
    {
        public ViewStudentsForm()
        {
            InitializeComponent();
        }

        private void ViewStudentsForm_Load(object sender, EventArgs e)
        {
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = StudentData.Students;
        }
    }
}
