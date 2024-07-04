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
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        int index_Row;

        private void button4_Click(object sender, EventArgs e)
        {
            Loginpage obj = new Loginpage();
            obj.Show();
            this.Hide();
        }

        private void Book_Load(object sender, EventArgs e)
        {
           Book_grid.ColumnCount = 6;
            Book_grid.Columns[0].Name = "Book No:";
            Book_grid.Columns[1].Name = " Book NAME";
            Book_grid.Columns[2].Name = "Book Type";
            Book_grid.Columns[3].Name = "Authur Name";
            Book_grid.Columns[4].Name = "Issue Date";
            Book_grid.Columns[5].Name = "Return Date";
            Book_grid.Rows.Add(new object[] { 1, "PF", "Programming", "TONY GADDIS", "04-09-23", "08-09-23" });
            Book_grid.Rows.Add(new object[] { 2, "AICT", "Hardware", "J.Glen", "12-09-23", "17-09-23" });
            Book_grid.Rows.Add(new object[] { 3, "CAG", "Mathematics", "Thomas", "23-10-23", "28-10-23" });
            Book_grid.Rows.Add(new object[] { 4, "English","Language", "John Eastwood", "07-11-23", "12-11-23" });
        }

        private void STD_add_Click(object sender, EventArgs e)
        {
            Book_grid.Rows.Add(new object[] { text1.Text, text2.Text, text3.Text, text4.Text, text5.Text, text6.Text });
        }

        private void New_Click(object sender, EventArgs e)
        {

            text1.Text = String.Empty;
            text2.Text = String.Empty;
            text3.Text = String.Empty;
            text4.Text = String.Empty;
            text5.Text = String.Empty;
            text6.Text = String.Empty;
        }

        private void Book_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            index_Row = e.RowIndex;
            DataGridViewRow row = Book_grid.Rows[index_Row];
            text1.Text = row.Cells[0].Value.ToString();
            text2.Text = row.Cells[1].Value.ToString();
            text3.Text = row.Cells[2].Value.ToString();
            text4.Text = row.Cells[3].Value.ToString();
            text5.Text = row.Cells[4].Value.ToString();
            text6.Text = row.Cells[5].Value.ToString();
        }

        private void Std_update_Click(object sender, EventArgs e)
        {

            DataGridViewRow update = Book_grid.Rows[index_Row];
            update.Cells[0].Value = text1.Text;
            update.Cells[1].Value = text2.Text;
            update.Cells[2].Value = text3.Text;
            update.Cells[3].Value = text4.Text;
            update.Cells[4].Value = text5.Text;
            update.Cells[5].Value = text6.Text;
        }

        private void Std_delete_Click(object sender, EventArgs e)
        {
            index_Row = Book_grid.CurrentCell.RowIndex;
            Book_grid.Rows.RemoveAt(index_Row);
        }

        private void button1_Click(object sender, EventArgs e)
        {
                MAIN_PAGE ss = new MAIN_PAGE();
                ss.Show();
                this.Hide();
           
        }

        private void text_1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
