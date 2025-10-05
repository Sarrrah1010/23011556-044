namespace Asignment_2
{
    partial class HomePage
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
            lblWelcome = new Label();
            btnProfile = new Button();
            btnSettings = new Button();
            btnLogout = new Button();
            btnOpenLibrary = new Button();
            btnOpenCalculator = new Button();
            btnOpenStudentManagement = new Button(); // Declare here
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.BurlyWood;
            lblWelcome.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(502, 319);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Padding = new Padding(30, 20, 20, 30);
            lblWelcome.Size = new Size(233, 95);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "WELCOME";
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.BurlyWood;
            btnProfile.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProfile.Location = new Point(300, 103);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(162, 55);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = false;
         //   btnProfile.Click += btnProfile_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Tan;
            btnSettings.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSettings.Location = new Point(113, 101);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(156, 57);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = false;
           // btnSettings.Click += btnSettings_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Tan;
            btnLogout.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(1029, 76);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(143, 67);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnOpenLibrary
            // 
            btnOpenLibrary.BackColor = Color.Tan;
            btnOpenLibrary.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnOpenLibrary.Location = new Point(78, 537);
            btnOpenLibrary.Name = "btnOpenLibrary";
            btnOpenLibrary.Size = new Size(239, 75);
            btnOpenLibrary.TabIndex = 4;
            btnOpenLibrary.Text = "Open Library System";
            btnOpenLibrary.UseVisualStyleBackColor = false;
            btnOpenLibrary.Click += btnOpenLibrary_Click;
            // 
            // btnOpenCalculator
            // 
            btnOpenCalculator.BackColor = Color.Tan;
            btnOpenCalculator.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnOpenCalculator.Location = new Point(406, 537);
            btnOpenCalculator.Name = "btnOpenCalculator";
            btnOpenCalculator.Size = new Size(265, 75);
            btnOpenCalculator.TabIndex = 5;
            btnOpenCalculator.Text = "Open Calculator";
            btnOpenCalculator.UseVisualStyleBackColor = false;
            btnOpenCalculator.Click += btnOpenCalculator_Click;
            // 
            // btnOpenStudentManagement
            // 
            btnOpenStudentManagement.BackColor = Color.Tan;
            btnOpenStudentManagement.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnOpenStudentManagement.Location = new Point(720, 537); // adjust position
            btnOpenStudentManagement.Name = "btnOpenStudentManagement";
            btnOpenStudentManagement.Size = new Size(265, 75);
            btnOpenStudentManagement.TabIndex = 6;
            btnOpenStudentManagement.Text = "Open Student Management";
            btnOpenStudentManagement.UseVisualStyleBackColor = false;
            btnOpenStudentManagement.Click += btnOpenStudentManagement_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2025_11_01_at_13_34_45_2089e557;
            ClientSize = new Size(1232, 725);
            Controls.Add(btnOpenStudentManagement);
            Controls.Add(btnOpenCalculator);
            Controls.Add(btnOpenLibrary);
            Controls.Add(btnLogout);
            Controls.Add(btnSettings);
            Controls.Add(btnProfile);
            Controls.Add(lblWelcome);
            Name = "HomePage";
            Text = "HomePage";
            //Load += HomePage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLogout;
        private Button btnOpenLibrary;
        private Button btnOpenCalculator;
        private Button btnOpenStudentManagement; // Declaration
    }
}
