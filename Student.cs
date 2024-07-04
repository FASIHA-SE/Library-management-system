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
    public partial class Student_page : Form
    {
        public Student_page()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        int index_Row;

        private void std_name_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           Loginpage obj = new Loginpage();
            obj.Show();
            this.Hide();
        }

        private void students_grpbox_Enter(object sender, EventArgs e)
        {

        }

        private void Student_page_Load(object sender, EventArgs e)
        {
            Student_Grid.ColumnCount = 6;
            Student_Grid.Columns[0].Name = "ID";
            Student_Grid.Columns[1].Name = " Student NAME";
            Student_Grid.Columns[2].Name = "Age";
            Student_Grid.Columns[3].Name = "Roll";
            Student_Grid.Columns[4].Name = "Phone";
            Student_Grid.Columns[5].Name = "Email";
            Student_Grid.Rows.Add(new object[] { 1, "Cherish", 18,  10, 0322313311, "Cherish@gmail.com" });
            Student_Grid.Rows.Add(new object[] { 2, "Iris", 19,  11, 0321231313, "Iris21@gmail.com" });
            Student_Grid.Rows.Add(new object[] { 3, "Jhon", 20,  12, 0323131313, "jHonabc@gmail.com" });
            Student_Grid.Rows.Add(new object[] { 4, "Alex", 21,  13, 0313133133, "abcd@gmail.com" });
        }

        private void STD_add_Click(object sender, EventArgs e)
        {
           Student_Grid.Rows.Add(new object[] { text1.Text, text2.Text, text3.Text, text4.Text, text5.Text, text6.Text });
        }

        private void New_Click(object sender, EventArgs e)
        {
            text1.Text = "";
            text2.Text = String.Empty;
            text3.Text = String.Empty;
            text4.Text = String.Empty;
            text5.Text = String.Empty;
            text6.Text = String.Empty;
        }

        private void Student_Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            index_Row = e.RowIndex;
            DataGridViewRow row = Student_Grid.Rows[index_Row];
            text1.Text = row.Cells[0].Value.ToString();
            text2.Text = row.Cells[1].Value.ToString();
            text3.Text = row.Cells[2].Value.ToString();
            text4.Text = row.Cells[3].Value.ToString();
            text5.Text = row.Cells[4].Value.ToString();
            text6.Text = row.Cells[5].Value.ToString();
        }

        private void Std_update_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = Student_Grid.Rows[index_Row];
            newdata.Cells[0].Value = text1.Text;
            newdata.Cells[1].Value = text2.Text;
            newdata.Cells[2].Value = text3.Text;
            newdata.Cells[3].Value = text4.Text;
            newdata.Cells[4].Value = text5.Text;
            newdata.Cells[5].Value = text6.Text;
        }

        private void Std_delete_Click(object sender, EventArgs e)
        {
            index_Row = Student_Grid.CurrentCell.RowIndex;
            Student_Grid.Rows.RemoveAt(index_Row);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                MAIN_PAGE ss = new MAIN_PAGE();
                ss.Show();
                this.Hide();
          
        }

        private void text1_KeyPress(object sender, KeyPressEventArgs e)
        {
        //    Amount_bx.MaxLength = 6;
        //    if (char.IsDigit(e.KeyChar) || e.KeyChar == 8) { e.Handled = false; }
        //    else { e.Handled = true; }
        }
    }
}
