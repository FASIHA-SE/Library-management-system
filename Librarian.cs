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
    public partial class Librarian : Form
    {
        public Librarian()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        int index_Row;

        private void button4_Click(object sender, EventArgs e)
        {
           MAIN_PAGE obj = new MAIN_PAGE();
            obj.Show();
            this.Hide();
        }

        private void Librarian_Load(object sender, EventArgs e)
        {
            Librarian_grid.ColumnCount = 6;
            Librarian_grid.Columns[0].Name = "ID";
            Librarian_grid.Columns[1].Name = "BOOK";
            Librarian_grid.Columns[2].Name = "JOURNEL";
            Librarian_grid.Columns[3].Name = "MAGAZINES";
            Librarian_grid.Columns[4].Name = "NEWSPAPER";
            Librarian_grid.Columns[5].Name = "ACADEMIC BOOKS";
            Librarian_grid.Rows.Add(new object[] { 1, "Digital Book Index","ACOUSTIC", "ENIGMA", "The New York Times", "ZINES IN LIBRARIES" });
            Librarian_grid.Rows.Add(new object[] { 2, "Pakistan Research Repository", "ADOLESCENTS", "DAILY NOTIFIER","THE WASHINGTON POST" , "PROGRAMING FUNDAMENTAL" });
            Librarian_grid.Rows.Add(new object[] { 3, "Australian Digital Thesis", "AEROBIOLOGY", "ZOO WORLD","LOS ANGELES TIMES", "AICT" });
            Librarian_grid.Rows.Add(new object[] { 4, "Bartleby Great Books ","AEROSPACE", "MIND FLOSS","DAWN", "DISCREET MATH" });
        }

        private void STD_add_Click(object sender, EventArgs e)
        {
            Librarian_grid.Rows.Add(new object[] { text1.Text, text2.Text, text3.Text, text4.Text, text5.Text, text6.Text });
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

        private void Librarian_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index_Row = e.RowIndex;
            DataGridViewRow row = Librarian_grid.Rows[index_Row];
            text1.Text = row.Cells[0].Value.ToString();
            text2.Text = row.Cells[1].Value.ToString();
            text3.Text = row.Cells[2].Value.ToString();
            text4.Text = row.Cells[3].Value.ToString();
            text5.Text = row.Cells[4].Value.ToString();
            text6.Text = row.Cells[5].Value.ToString();
                            
                
                
         }

        private void Std_update_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = Librarian_grid.Rows[index_Row];
            newdata.Cells[0].Value = text1.Text;
            newdata.Cells[1].Value = text2.Text;
            newdata.Cells[2].Value = text3.Text;
            newdata.Cells[3].Value = text4.Text;
            newdata.Cells[4].Value = text5.Text;
            newdata.Cells[5].Value = text6.Text;
        }

        private void Std_delete_Click(object sender, EventArgs e)
        {
            index_Row = Librarian_grid.CurrentCell.RowIndex;
            Librarian_grid.Rows.RemoveAt(index_Row);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
