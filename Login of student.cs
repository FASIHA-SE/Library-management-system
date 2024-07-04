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
    public partial class Login_of_student : Form
    {
        public Login_of_student()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            if (username.Text == "student" && password.Text == "student")
            {
                MAIN_PAGE obj = new MAIN_PAGE();
                obj.Show();
                this.Hide();
            }
            else if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Missing!!!");
            }
            else
            {
                MessageBox.Show("Please input  correct Username and Password");
            }
        }
    }
}
