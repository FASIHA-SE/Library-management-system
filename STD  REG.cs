using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Login_page
{
    public partial class STD__REG : Form
    {
        public STD__REG()
        {
            InitializeComponent();
        }

        private void STD__REG_Load(object sender, EventArgs e)
        {

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            if (regname.Text != "student" ||  regpass.Text  != "student")
            {
                MessageBox.Show($"Welcome!!! {regname.Text} in Library");

                std_book std  = new std_book();    
                std.Show();
                this.Hide();
            }
            else if (regname.Text == "" || regpass.Text == "" )
            {
                MessageBox.Show("Missing!!!");
            }
            
            else
            {
                MessageBox.Show("Please input  correct Username and Password");
            }
        }

        private void BACK_std_Click(object sender, EventArgs e)
        {
            Loginpage uew = new Loginpage();
            uew.Show(); 
            this.Hide();
        }
    }
}

