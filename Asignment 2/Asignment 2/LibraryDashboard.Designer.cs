namespace Asignment_2
{
    partial class LibraryDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnAddBook;
        private Button btnBorrowBook;
        private Button btnViewBorrowed;

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
            btnAddBook = new Button();
            btnBorrowBook = new Button();
            btnViewBorrowed = new Button();
            SuspendLayout();
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new System.Drawing.Point(40, 30);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new System.Drawing.Size(200, 40);
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += new EventHandler(btnAddBook_Click);
            // 
            // btnBorrowBook
            // 
            btnBorrowBook.Location = new System.Drawing.Point(40, 90);
            btnBorrowBook.Name = "btnBorrowBook";
            btnBorrowBook.Size = new System.Drawing.Size(200, 40);
            btnBorrowBook.Text = "Borrow Book";
            btnBorrowBook.UseVisualStyleBackColor = true;
            btnBorrowBook.Click += new EventHandler(btnBorrowBook_Click);
            // 
            // btnViewBorrowed
            // 
            btnViewBorrowed.Location = new System.Drawing.Point(40, 150);
            btnViewBorrowed.Name = "btnViewBorrowed";
            btnViewBorrowed.Size = new System.Drawing.Size(200, 40);
            btnViewBorrowed.Text = "View Borrowed Books";
            btnViewBorrowed.UseVisualStyleBackColor = true;
            btnViewBorrowed.Click += new EventHandler(btnViewBorrowed_Click);
            // 
            // LibraryDashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(300, 230);
            Controls.Add(btnAddBook);
            Controls.Add(btnBorrowBook);
            Controls.Add(btnViewBorrowed);
            Name = "LibraryDashboard";
            Text = "Library Dashboard";
            ResumeLayout(false);
        }
    }
}
