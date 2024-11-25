using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Lab2
{
    public partial class ProductOrdersListVIew : Form
    {
        public ProductOrdersListVIew()
        {
            InitializeComponent();
            listView.FullRowSelect = true;
            StartPosition = FormStartPosition.CenterScreen;
        }
        public double total = 0;
        public List<int> listId = new List<int>();
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtid.Text) || string.IsNullOrWhiteSpace(txtname.Text) ||
                string.IsNullOrWhiteSpace(txtprice.Text) || string.IsNullOrWhiteSpace(categorycombo.Text) ||
                string.IsNullOrWhiteSpace(txtqty.Text))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }

            int product_id;
            string product_name;
            double discount = 0;

            product_id = int.Parse(txtid.Text);

            if (listId.Contains(product_id))
            {
                MessageBox.Show("Duplicate product ID. Please enter a different ID.");
                return;

            }
           
            product_name = txtname.Text;
            double product_price = double.Parse(txtprice.Text);
            string category = categorycombo.Text;
            int qty = int.Parse(txtqty.Text);

            if (discount5.Checked == true)
                discount = 5;
            else if (discount10.Checked)
                discount = 10;

            double subtotal = qty * product_price - qty * product_price * discount / 100;

            txtsubtotal.Text = subtotal.ToString("$0.00");
            listId.Add(product_id);

            total += subtotal;
            txttotal.Text = total.ToString("$0.00");

            // Load image
            Image im = picBox.Image;
            imageList.Images.Add(im);
            string[] rowitem = {"", product_id.ToString("D3"), product_name, category, product_price.ToString("$0.00"), qty + "", discount + "%" , subtotal.ToString("$0.00")};

            ListViewItem item = new ListViewItem(rowitem);
            item.ImageIndex = imageList.Images.Count - 1;
            //item.SubItems.Add(product_name);
            //item.SubItems.Add(category);
            //item.SubItems.Add("$" + product_price);
            //item.SubItems.Add(qty.ToString());
            //item.SubItems.Add(discount + "%");
         


            //item.SubItems.Add("$" + subtotal);
            listView.Items.Add(item);
           picBox.Image = Properties.Resources.noimage;
           discount5.Checked = false;
            discount10.Checked = false; 
        }


        private void ProductOrdersListVIew_Load(object sender, EventArgs e)
        {
            categorycombo.SelectedIndex = 0;
            txtsubtotal.Enabled = false;
            txttotal.Enabled = false;
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must select an item , before to remove");
                return;
            }
               

  
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int i = listView.SelectedIndices[0];
                int productIdToRemove = int.Parse(listView.Items[i].SubItems[1].Text);
                double subtotalToRemove = double.Parse(listView.Items[i].SubItems[7].Text.Replace("$", ""));

 
                    listId.Remove(productIdToRemove);
                total -= subtotalToRemove;

                txttotal.Text = total.ToString("$0.00");
                listView.Items.RemoveAt(i);
            }
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg|All files (*.*)|*.*";
            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                Image img = Image.FromFile(ofd.FileName);
                picBox.Image = img;
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }
    }
}
