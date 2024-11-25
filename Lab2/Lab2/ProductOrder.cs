using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab2
{
    public partial class ProductOrder : Form
    {
        public ProductOrder()
        {
            InitializeComponent();
        }
     
        public double  total = 0;
        public List<int> listId = new List<int>();

        private void btnadd_Click(object sender, EventArgs e)
        {
            double subtotal = 0;
            int product_id;
            string product_name;
            double discount = 0;

            product_id = int.Parse(txtid.Text);

            // Check if the product ID already exists in the list
            if (listId.Contains(product_id))
            {
                MessageBox.Show("Duplicate product ID. Please enter a different ID.");
                return; // Exit the method to avoid adding duplicate entries
            }

            product_name = txtname.Text;
            double product_price = double.Parse(txtprice.Text);
            string category = categorycombo.Text;
            int qty = int.Parse(txtqty.Text);

            if (discount5.Checked == true)
                discount = 5;
            else if (discount10.Checked)
                discount = 10;

            subtotal = qty * product_price - qty * product_price * discount / 100;

            txtsubtotal.Text = subtotal.ToString("$0.00");
            listId.Add(product_id);

            string itm = product_id + "\t" + product_name + "\t" + category + "\t" + product_price + "\t" + qty + "\t" + discount + "%\t" + subtotal;
            lstproduct.Items.Add(itm);
            total += subtotal;
            txttotal.Text = total.ToString("$0.00");
        }


        private void btnremove_Click(object sender, EventArgs e)
        {
            if(lstproduct.SelectedIndex != -1)
            {
                string[] data = lstproduct.SelectedItem.ToString().Split('\t');
                int removeProductId = int.Parse(data[0]);
                total -= double.Parse(data[6]);
                listId.Remove(removeProductId);
                txttotal.Text = total.ToString("$0.00");
                lstproduct.Items.Remove(lstproduct.SelectedItem);
            }
           
        }

        private void ProductOrder_Load(object sender, EventArgs e)
        {
            categorycombo.SelectedIndex = 0;
            txtsubtotal.Enabled = false;
            txttotal.Enabled = false;
        }
    }
}
