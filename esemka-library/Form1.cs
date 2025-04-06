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
            int memberId = getMemberIdByMemberName(memberName);

            if (memberId > 0)
            {
                var memberBorrowedBooks = (from bw in dataContext.Borrowings
                                           join b in dataContext.Books on bw.book_id equals b.id
                                           where bw.member_id.Equals(memberId)
                                           select new
                                           {
                                               bw.id,
                                               b.title,
                                               bw.borrow_date,
                                               bw.return_date,
                                               bw.fine
                                           }).ToList();

                if (memberBorrowedBooks.Count > 3)
                {
                    btnToNewBorrowing.Enabled = false;
                } 
            }
        }

        private int getMemberIdByMemberName(string memberName)
        {
            int memberId = 0;
            var selectedMember = dataContext.Members.FirstOrDefault(m => m.name.Contains(memberName));
            if (selectedMember != null)
            {
                memberId = selectedMember.id;
            } else
            {
                MessageBox.Show("Member Not Found", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return memberId;
        }

        private void tbMemberName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

            }
        }
    }
}
