using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esemka_library
{
    public partial class Form1 : Form
    {

        EsemkaLibraryDataClassesDataContext dataContext;

        public Form1()
        {
            InitializeComponent();

            string connString = ConfigurationManager.ConnectionStrings["esemka_library.Properties.Settings.EsemkaLibraryConnectionString"].ConnectionString;
            dataContext = new EsemkaLibraryDataClassesDataContext(connString);
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            string memberName = tbMemberName.Text;

            if (string.IsNullOrWhiteSpace(memberName))
            {
                MessageBox.Show("Please enter member name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                loadMemberBorrowedBooks(memberName);
            }

        }

        private void loadMemberBorrowedBooks(string memberName)
        {
            try
            {
                int memberId = getMemberIdByMemberName(memberName);

                dgMemberBorrowedBooks.Rows.Clear();

                if (memberId > 0)
                {
                    int rowData = 0;

                    var memberBorrowedBooks = (from bw in dataContext.Borrowings
                                               join b in dataContext.Books on bw.book_id equals b.id
                                               where bw.member_id.Equals(memberId)
                                               select new
                                               {
                                                   bw.id,
                                                   bookTitle = b.title,
                                                   bw.borrow_date,
                                                   bw.return_date,
                                                   bw.fine
                                               }).ToList();

                    if (memberBorrowedBooks.Count > 3)
                    {
                        btnToNewBorrowing.Enabled = false;
                    }

                    if (memberBorrowedBooks != null)
                    {
                        DataGridViewLinkColumn linkColumn = new DataGridViewLinkColumn
                        {
                            HeaderText = "Action",
                            Name = "action",
                            Text = "Return",
                            UseColumnTextForLinkValue = true    
                        };

                        dgMemberBorrowedBooks.Columns.Add(linkColumn);

                        for (int i = 0; i <= memberBorrowedBooks.Count - 1; i++)
                        {
                            rowData = dgMemberBorrowedBooks.Rows.Add();
                            dgMemberBorrowedBooks.Rows[rowData].Cells[0].Value = memberBorrowedBooks[i].id;
                            dgMemberBorrowedBooks.Rows[rowData].Cells[1].Value = memberBorrowedBooks[i].bookTitle;
                            dgMemberBorrowedBooks.Rows[rowData].Cells[2].Value = memberBorrowedBooks[i].borrow_date.ToString("dd MMMM yyyy");
                            dgMemberBorrowedBooks.Rows[rowData].Cells[3].Value = memberBorrowedBooks[i].return_date.HasValue ? memberBorrowedBooks[i].return_date.Value.ToString("dd MMMM yyyy") : "-";
                            dgMemberBorrowedBooks.Rows[rowData].Cells[4].Value = memberBorrowedBooks[i].fine.HasValue ? (int)memberBorrowedBooks[i].fine.Value / 2000 : 0;
                        }
                    }
                } else
                {
                    MessageBox.Show("Member Not Found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private int getMemberIdByMemberName(string memberName)
        {
            int memberId = 0;
            var selectedMember = dataContext.Members.FirstOrDefault(m => m.name.Contains(memberName));
            if (selectedMember != null)
            {
                memberId = selectedMember.id;
            } 
            return memberId;
        }

        private void tbMemberName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearchMember.PerformClick();
            }
        }

        private void dgMemberBorrowedBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    string bookTitle = (string)dgMemberBorrowedBooks.Rows[e.RowIndex].Cells["borrowedBookTitle"].Value;
                    int fine = (int)dgMemberBorrowedBooks.Rows[e.RowIndex].Cells["overdueDays"].Value;
                    var book = dataContext.Books.FirstOrDefault(b => b.title.Equals(bookTitle));
                    if (book != null)
                    {

                        var selectedBorrowedBook = dataContext.Borrowings.FirstOrDefault(bw => bw.id.Equals(book.id));

                        dataContext.Borrowings.DeleteOnSubmit(selectedBorrowedBook);
                        book.stock += 1;

                        dataContext.SubmitChanges();

                        MessageBox.Show($@"Success return '{bookTitle}.'
Member needs to pay fine: {(fine * 2000)} IDR.");

                        loadMemberBorrowedBooks(tbMemberName.Text);

                    }
                    else
                    {
                        MessageBox.Show("Borrowing data found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnToNewBorrowing_Click(object sender, EventArgs e)
        {
            NewBorrowingForm newBorrowingForm = new NewBorrowingForm(this);
            newBorrowingForm.Show();
            this.Hide();
        }
    }
}
