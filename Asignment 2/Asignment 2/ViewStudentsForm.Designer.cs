using System.Windows.Forms;
using System.Drawing;

namespace Asignment_2
{
    partial class ViewStudentsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvStudents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();

            dgvStudents.Location = new Point(20, 20);
            dgvStudents.Size = new Size(500, 300);
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.ClientSize = new Size(550, 350);
            this.Controls.Add(dgvStudents);
            this.Text = "View Students";
            this.Load += ViewStudentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
        }

        private DataGridView dgvStudents;
    }
}
