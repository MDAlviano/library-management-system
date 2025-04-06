using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esemka_library
{
    public partial class NewBorrowingForm : Form
    {

        Form1 form1;
        EsemkaLibraryDataClassesDataContext dataContext;

        public NewBorrowingForm(Form1 mainForm)
        {
            InitializeComponent();

            this.form1 = mainForm;

            string connString = ConfigurationManager.ConnectionStrings["esemka_library.Properties.Settings.EsemkaLibraryConnectionString"].ConnectionString;
            dataContext = new EsemkaLibraryDataClassesDataContext(connString);

            this.FormClosed += (s, e) => mainForm.Show();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            var bookTitle = tbBookTitle.Text;
            if (string.IsNullOrWhiteSpace(bookTitle))
            {
                MessageBox.Show("Please fill all fields!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                loadBooks(bookTitle);
            }
        }

        private void loadBooks(string bookTitle)
        {
            try
            {
                int bookId = getBookIdByBookTitle(bookTitle);

                dgBooks.Columns.Clear();

                if (bookId > 0)
                {
                    int rowData = 0;

                    var books = (from bg in dataContext.BookGenres
                                 join b in dataContext.Books on bg.book_id equals b.id
                                 join g in dataContext.Genres on bg.genre_id equals g.id
                                 where bg.book_id.Equals(bookId)
                                 select new
                                 {
                                     bookId = b.id,
                                     bookTitle = b.title,
                                     genre = g.name,
                                     author = b.author,
                                     pubDate = b.publish_date,
                                     stock = b.stock
                                 }).ToList();

                    var formattedBooks = books
                        .GroupBy(b => new
                        {
                            b.bookId,
                            b.bookTitle,
                            b.author,
                            b.pubDate,
                            b.stock
                        })
                        .Select(g => new
                        {
                            id = g.Key.bookId,
                            title = g.Key.bookTitle,
                            genres = string.Join(", ", g.Select(b => b.genre)),
                            author = g.Key.author,
                            pubDate = g.Key.pubDate,
                            stock = g.Key.stock
                        }).ToList();

                    if (books != null)
                    {
                        DataGridViewLinkColumn linkColumn = new DataGridViewLinkColumn
                        {
                            HeaderText = "Action",
                            Name = "action",
                            Text = "Borrow",
                            UseColumnTextForLinkValue = true
                        };

                        dgBooks.Columns.Add(linkColumn);

                        for (int i = 0; i <= formattedBooks.Count - 1; i++)
                        {
                            rowData = dgBooks.Rows.Add();
                            dgBooks.Rows[rowData].Cells[0].Value = formattedBooks[i].id;
                            dgBooks.Rows[rowData].Cells[1].Value = formattedBooks[i].title;
                            dgBooks.Rows[rowData].Cells[2].Value = formattedBooks[i].genres;
                            dgBooks.Rows[rowData].Cells[3].Value = formattedBooks[i].author;
                            dgBooks.Rows[rowData].Cells[4].Value = formattedBooks[i].pubDate.HasValue ? formattedBooks[i].pubDate.Value.ToString("dd MMMM yyyy") : "-";
                            dgBooks.Rows[rowData].Cells[5].Value = formattedBooks[i].stock == 0 ? dgBooks.Rows[rowData].DefaultCellStyle.BackColor = Color.Red : dgBooks.Rows[rowData].DefaultCellStyle.BackColor = Color.White;
                        }
                    }
                } else
                {
                    MessageBox.Show("Book Not Found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private int getBookIdByBookTitle(string bookTitle)
        {
            int bookId = 0;
            var book = dataContext.Books.FirstOrDefault(b => b.title.Contains(bookTitle));
            if (book != null)
            {
                bookId = book.id;
            }
            return bookId;
        }

        private void dgBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var bookId = (int)dgBooks.Rows[e.RowIndex].Cells["bookId"].Value;
                    var book = dataContext.Books.FirstOrDefault(b => b.id.Equals(bookId));
                    if (book != null)
                    {

                        if (book.stock <= 0)
                        {
                            MessageBox.Show("Stock is empty", "Notification", MessageBoxButtons.OK);
                            return;
                        }

                        var form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                        int memberId = getMemberIdByMemberName(form1.tbMemberName.Text);

                        var newBorrowing = new Borrowing
                        {
                            member_id = memberId,
                            book_id = bookId,
                            borrow_date = DateTime.Now,
                            return_date = DateTime.Now.AddDays(7),
                            fine = 0,
                            created_at = DateTime.Now,
                            deleted_at = null
                        };

                        dataContext.Borrowings.InsertOnSubmit(newBorrowing);

                        book.stock -= 1;

                        dataContext.SubmitChanges();

                        MessageBox.Show($@"Success borrow '{book.title}'.
Due date is 7 days from today.", "Notification", MessageBoxButtons.OK);

                        loadBooks(tbBookTitle.Text);

                    }
                    else
                    {
                        MessageBox.Show("Book not found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private int getMemberIdByMemberName(string text)
        {
            int memberId = 0;
            var selectedMember = dataContext.Members.FirstOrDefault(m => m.name.Contains(memberName));
            if (selectedMember != null)
            {
                memberId = selectedMember.id;
            }
            return memberId;
        }

        private void tbBookTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearchBook.PerformClick();
            }
        }
    }
}
