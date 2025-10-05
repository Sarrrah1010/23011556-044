using System;
using System.Linq;
using System.Windows.Forms;

namespace Asignment_2
{
    public partial class ViewBorrowedBooksForm : Form
    {
        public ViewBorrowedBooksForm()
        {
            InitializeComponent();
            this.Load += ViewBorrowedBooksForm_Load;
        }

        private void ViewBorrowedBooksForm_Load(object sender, EventArgs e)
        {
            if (LibraryDashboard.Books == null || LibraryDashboard.Books.Count == 0)
            {
                MessageBox.Show("No books found in library yet.");
                return;
            }

            var borrowedBooks = LibraryDashboard.Books
                .Where(b => b.IsAvailable == false)
                .Select(b => new { b.Title, b.Author })
                .ToList();

            dataGridView1.DataSource = borrowedBooks;

            if (borrowedBooks.Count == 0)
            {
                MessageBox.Show("No borrowed books found.");
            }
        }
    }
}
