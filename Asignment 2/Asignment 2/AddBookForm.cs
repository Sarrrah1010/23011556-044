using System;
using System.Windows.Forms;

namespace Asignment_2
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Book newBook = new Book
            {
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                IsAvailable = true
            };

            LibraryDashboard.Books.Add(newBook);
            MessageBox.Show("Book added successfully!");
            this.Close();
        }
    }
}
