using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Asignment_2
{
    public partial class LibraryDashboard : Form
    {
        // ✅ Make this static so all forms share same list
        public static List<Book> Books = new List<Book>();

        public LibraryDashboard()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.ShowDialog();
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            BorrowBookForm borrowBookForm = new BorrowBookForm();
            borrowBookForm.ShowDialog();
        }

        private void btnViewBorrowedBooks_Click(object sender, EventArgs e)
        {
            ViewBorrowedBooksForm viewBorrowedBooksForm = new ViewBorrowedBooksForm();
            viewBorrowedBooksForm.ShowDialog();
        }
        private void btnViewBorrowed_Click(object sender, EventArgs e)
        {
            ViewBorrowedBooksForm viewForm = new ViewBorrowedBooksForm();
            viewForm.ShowDialog();
        }

    }
}
