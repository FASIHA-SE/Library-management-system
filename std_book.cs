using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_page
{
    public partial class std_book : Form
    {
        public std_book()
        {
            InitializeComponent();
        }

        private void std_book_Load(object sender, EventArgs e)
        {
            Book_grid.ColumnCount = 6;
            Book_grid.Columns[0].Name = "Book No:";
            Book_grid.Columns[1].Name = " Book NAME";
            Book_grid.Columns[2].Name = "Book Type";
            Book_grid.Columns[3].Name = "Authur Name";
            Book_grid.Columns[4].Name = "Issue Date";
            Book_grid.Columns[5].Name = "Return Date";
            Book_grid.Rows.Add(new object[] { 1, "Clean Code", "SOFTWARE", "ROBERT C.MARTIN", "04-09-23", "08-09-23" });
            Book_grid.Rows.Add(new object[] { 2, "DESIGN PATTERN", "SE", "ERIC GAMA", "12-09-23", "17-09-23" });
            Book_grid.Rows.Add(new object[] { 3, "CAG", "Mathematics", "Thomas", "23-10-23", "28-10-23" });
            Book_grid.Rows.Add(new object[] { 4, "English", "Language", "John Eastwood", "07-11-23", "12-11-23" });
            Book_grid.Rows.Add(new object[] { 5, " The Art of Computer Programming", "PROGRAMING", "Donald Knuth", "15-11-23", "20-11-23" });

        }

        private void stdBack_btn_Click(object sender, EventArgs e)
        {
            STD__REG uew = new STD__REG();
            uew.Show();
            this.Hide();
        }
    }
}
