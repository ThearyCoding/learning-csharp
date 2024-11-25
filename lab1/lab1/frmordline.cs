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
    public partial class frmordline : Form
    {
        public frmordline()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            int qty = int.Parse(txtqty.Text);
            double price = double.Parse(txtprice.Text);
            double total = qty * price;
            String totalOutput = qty + " + " + price + " = " + total.ToString("C2");
            txttotal.AppendText(totalOutput + "\r\n");

        }
    }
}
