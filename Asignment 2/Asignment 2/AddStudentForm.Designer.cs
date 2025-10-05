using System.Windows.Forms;
using System.Drawing;

namespace Asignment_2
{
    partial class AddStudentForm
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
            this.txtName = new TextBox();
            this.txtClass = new TextBox();
            this.txtAge = new TextBox();
            this.btnSave = new Button();
            this.SuspendLayout();

            // txtName
            this.txtName.Location = new Point(50, 50);
            this.txtName.Size = new Size(200, 30);
            this.txtName.PlaceholderText = "Name";

            // txtClass
            this.txtClass.Location = new Point(50, 100);
            this.txtClass.Size = new Size(200, 30);
            this.txtClass.PlaceholderText = "Class";

            // txtAge
            this.txtAge.Location = new Point(50, 150);
            this.txtAge.Size = new Size(200, 30);
            this.txtAge.PlaceholderText = "Age";

            // btnSave
            this.btnSave.Location = new Point(50, 200);
            this.btnSave.Size = new Size(200, 40);
            this.btnSave.Text = "Save";
            this.btnSave.Click += btnSave_Click;

            // AddStudentForm
            this.ClientSize = new Size(300, 300);
            this.Controls.Add(txtName);
            this.Controls.Add(txtClass);
            this.Controls.Add(txtAge);
            this.Controls.Add(btnSave);
            this.Text = "Add Student";
            this.ResumeLayout(false);
        }

        private TextBox txtName;
        private TextBox txtClass;
        private TextBox txtAge;
        private Button btnSave;
    }
}
