using System;
using System.Linq;
using System.Windows.Forms;

namespace Asignment_2
{
    public partial class BorrowBookForm : Form
    {
        public BorrowBookForm()
        {
            InitializeComponent();
            this.Load += BorrowBookForm_Load;
        }

        private void BorrowBookForm_Load(object sender, EventArgs e)
        {
            if (LibraryDashboard.Books == null || LibraryDashboard.Books.Count == 0)
            {
                MessageBox.Show("No books available in the library.");
                return;
            }

            cmbBooks.DataSource = LibraryDashboard.Books
                .Where(b => b.IsAvailable)
                .Select(b => b.Title)
                .ToList();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (cmbBooks.SelectedItem == null)
            {
                MessageBox.Show("Please select a book to borrow.");
                return;
            }

            string selectedTitle = cmbBooks.SelectedItem.ToString();

            var book = LibraryDashboard.Books.FirstOrDefault(b => b.Title == selectedTitle);

            if (book != null && book.IsAvailable)
            {
                book.IsAvailable = false;
                MessageBox.Show($"Book '{selectedTitle}' borrowed successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Book not available!");
            }
        }
    }
}
