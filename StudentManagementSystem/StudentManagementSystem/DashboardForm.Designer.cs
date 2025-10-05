namespace StudentManagementSystem
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnAddStudent = new Button();
            btnViewStudent = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnAddStudent
            // 
            btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            btnAddStudent.Location = new System.Drawing.Point(74, 96);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new System.Drawing.Size(248, 62);
            btnAddStudent.TabIndex = 0;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // btnViewStudent
            // 
            btnViewStudent.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            btnViewStudent.Location = new System.Drawing.Point(469, 99);
            btnViewStudent.Name = "btnViewStudent";
            btnViewStudent.Size = new System.Drawing.Size(218, 59);
            btnViewStudent.TabIndex = 1;
            btnViewStudent.Text = "View Student";
            btnViewStudent.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            btnExit.Location = new System.Drawing.Point(343, 263);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(112, 59);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnViewStudent);
            Controls.Add(btnAddStudent);
            Name = "DashboardForm";
            Text = "Student System by Sarah";
            ResumeLayout(false);
        }

        private Button btnAddStudent;
        private Button btnViewStudent;
        private Button btnExit;
    }
}
