using System;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class ViewStudentsForm : Form
    {
        public ViewStudentsForm()
        {
            InitializeComponent();
        }

        private void ViewStudentsForm_Load(object sender, EventArgs e)
        {
            // DataGridView refresh karwana
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DashboardForm.Students;
        }
    }
}
