using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            if(username == "admin")
            {
                if(password == "123")
                {
                    MessageBox.Show("Login Successfully");
                    this.Hide();
                    frmordline orderform = new frmordline();
                    orderform.ShowDialog();
                    this.Dispose();
                    

                }
                

            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}
