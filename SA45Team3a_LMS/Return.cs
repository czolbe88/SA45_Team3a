using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace SA45Team3a_LMS
{
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }

        private void Return_Load(object sender, EventArgs e)
        {
            LMSentities ctx = new LMSentities();
            dataGridView1.DataSource = ctx.LoanRecords.Where(x => x.LoadStatus == "out").Select(x => new { x.LoanNumber, x.ISBN, x.Book.Title, x.Book.Author, x.MemberID, x.Member.MumberName, x.LoadStatus }).ToList();


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //search by book title
            //search by book ISBN
            //search by member name
            //search by member ID


        }

        private void check_in_Click(object sender, EventArgs e)
        {


            LMSentities ctx = new LMSentities();
            int loanNumber = (int)dataGridView1.CurrentRow.Cells[0].Value;
            LoanRecord checkedIn = ctx.LoanRecords.Where(x => x.LoanNumber == loanNumber).First();
            checkedIn.DateReturned = dateTimePicker1.Value;
            checkedIn.LoadStatus = "in";
            ctx.SaveChanges();


        }
       
        public bool isDigitOnly(string aString)
        {
            string x = "1234567890";
            foreach (char c in aString)
            {
                string a = c.ToString();
                x.Contains(a);
            }
            return true;
        }

        private void search_Click(object sender, EventArgs e)
        {
            LMSentities ctx = new LMSentities();
            string searchfield = textBox2.Text;
            

            if (isDigitOnly(searchfield))
            {
                
                int searchNum = Convert.ToInt32(searchfield);
                dataGridView1.DataSource = ctx.LoanRecords.Where(x => x.MemberID == searchNum && x.LoadStatus =="out").Select(x=> new {x.LoanNumber, x.ISBN, x.Book.Title, x.Book.Author, x.MemberID, x.Member.MumberName, x.LoadStatus}).ToList();

            }

            else {

                dataGridView1.DataSource = ctx.LoanRecords.Where(
                   x => x.ISBN == searchfield
                || x.Book.Title == searchfield
                || x.Book.Author == searchfield
                || x.Member.MumberName == searchfield
                
                ).Select(x => new { x.LoanNumber, x.ISBN, x.Book.Title, x.Book.Author, x.MemberID, x.Member.MumberName, x.LoadStatus }).ToList(); 
            }
         



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
