namespace Asignment_2
{
    partial class AddBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblAuthor = new Label();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(252, 105);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(90, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Book Title";
           // lblTitle.Click += label1_Click;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(252, 205);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(67, 25);
            lblAuthor.TabIndex = 1;
            lblAuthor.Text = "Author";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(419, 105);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(150, 31);
            txtTitle.TabIndex = 2;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(419, 199);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(150, 31);
            txtAuthor.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(396, 261);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save Book";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;

            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Name = "AddBookForm";
            Text = "AddBookForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblAuthor;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private Button btnSave;
    }
}