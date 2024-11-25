using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Sql_Server
{
    public partial class OptioneMenu : Form
    {
        public OptioneMenu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnpeople_Click(object sender, EventArgs e)
        {
            new FrmLoadPeople().Show();
        }

        private void btngotolucky_Click(object sender, EventArgs e)
        {
            new FrmLuckyDraw().Show();
        }

        private void OptioneMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            new frmAuthentication().Show();
        }

        private void OptioneMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnaddproduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmProduct().ShowDialog();
        }

        private void btngocategories_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmAddCategories().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmOrder().Show();
        }
    }
}
