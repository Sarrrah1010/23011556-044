namespace Asignment_2
{
    partial class BorrowBookForm
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
            cmbBooks = new ComboBox();
            label1 = new Label();
            btnBorrow = new Button();
            SuspendLayout();
            // 
            // cmbBooks
            // 
            cmbBooks.FormattingEnabled = true;
            cmbBooks.Location = new Point(346, 176);
            cmbBooks.Name = "cmbBooks";
            cmbBooks.Size = new Size(182, 33);
            cmbBooks.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 179);
            label1.Name = "label1";
            label1.Size = new Size(193, 25);
            label1.TabIndex = 1;
            label1.Text = "Select Book TO Borrow";
            // 
            // btnBorrow
            // 
            btnBorrow.Location = new Point(583, 174);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(112, 34);
            btnBorrow.TabIndex = 2;
            btnBorrow.Text = "Borrow";
            btnBorrow.UseVisualStyleBackColor = true;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // BorrowBookForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBorrow);
            Controls.Add(label1);
            Controls.Add(cmbBooks);
            Name = "BorrowBookForm";
            Text = "BorrowBookForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBooks;
        private Label label1;
        private Button btnBorrow;
    }
}