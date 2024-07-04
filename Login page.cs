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
    public partial class MAIN_PAGE : Form
    {
        public MAIN_PAGE()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
        }

        private void MAIN_PAGE_Load(object sender, EventArgs e)
        {

        }

        private void Student_btn_Click(object sender, EventArgs e)
        {
            Student_page obj = new Student_page();
            obj.Show();
            this.Hide();
        }

        private void Book_btn_Click(object sender, EventArgs e)
        {
            Book obj = new Book();
            obj.Show();
            this.Hide();
        }

        private void librarian_btn_Click(object sender, EventArgs e)
        {
            Librarian obj = new Librarian();
            obj.Show();
            this.Hide();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Loginpage obj = new Loginpage();
            obj.Show();
            this.Hide();

        }
    }
}
