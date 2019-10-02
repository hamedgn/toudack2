using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace toudack1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void paswbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void userbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginbtn1_Click(object sender, EventArgs e)
        {
           ///enter to admin to specefic page by username
           ///
           

           ///hide form 1 and go to form 2
            wisposh form2 = new wisposh();
            form2.Show();
            this.Hide();
        }
    }
}
