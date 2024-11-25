using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class FrmUpdate : Form
    {
        
        
        public FrmUpdate()
        {
            InitializeComponent();
        }
        public DataGridViewRowCollection Rows;
        public ProductOrderDataGridVIew form;
        public FrmUpdate(DataGridViewRowCollection rows,List<int> listID,double total , ProductOrderDataGridVIew form)
        {
            InitializeComponent();
            this.Rows = rows;
            this.form = form;
            this.listId = listID;
            this.total = total;
            txttotal.Text = total.ToString("$0.00");
            foreach (DataGridViewRow temp in  Rows)
            {
                int id = int.Parse(temp.Cells[0].Value.ToString());
                string name = temp.Cells[1].Value.ToString();
                string category = temp.Cells[2].Value.ToString();
                double price = double.Parse(temp.Cells[3].Value.ToString().Replace("$",""));
                int qty = int.Parse(temp.Cells[4].Value.ToString());
                int discount = int.Parse(temp.Cells[5].Value.ToString());
                double subtotal = double.Parse(temp.Cells[6].Value.ToString().Replace("$", ""));
                Image im = (Image)temp.Cells[7].Value;
                dgvProduct.Rows.Add(id.ToString("D3"), name, category, price.ToString("$0.00"), qty,discount, subtotal.ToString("$0.00"), im);
            }
        }
        public double total = 0;
        public List<int> listId = new List<int>();
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }
            double product_price = double.Parse(txtprice.Text);
            int qty = int.Parse(txtqty.Text);
            int discount = 0;

            if (discount5.Checked)
                discount = 5;
            else if (discount10.Checked)
                discount = 10;

            double subtotal = qty * product_price - qty * product_price * discount / 100;

            int productid = int.Parse(txtid.Text);

            if (listId.Contains(productid))
            {
                MessageBox.Show("Duplicated id");
                return;
            }

            DataGridViewRow selectedRow = dgvProduct.CurrentRow;

            selectedRow.Cells[1].Value = txtname.Text;
            selectedRow.Cells[2].Value = categorycombo.Text;
            selectedRow.Cells[3].Value = product_price.ToString("$0.00");
            selectedRow.Cells[4].Value = txtqty.Text;
            selectedRow.Cells[5].Value = discount;
            total -= double.Parse(selectedRow.Cells[6].Value.ToString().Replace("$", ""));
            total += double.Parse(subtotal.ToString());
            selectedRow.Cells[7].Value = picBox.Image;
            listId.Remove(int.Parse(selectedRow.Cells[0].Value.ToString()));
            listId.Add(int.Parse(txtid.Text));
            txttotal.Text = total.ToString("$0.00");
            selectedRow.Cells[0].Value = txtid.Text;
            selectedRow.Cells[6].Value = subtotal.ToString("$0.00");

            int row = dgvProduct.CurrentRow.Index;

            Rows[row].Cells[0].Value = txtid.Text;
            Rows[row].Cells[1].Value = txtname.Text;
            Rows[row].Cells[2].Value = categorycombo.Text;
            Rows[row].Cells[3].Value = txtprice.Text;
            Rows[row].Cells[4].Value = txtqty.Text;
            Rows[row].Cells[5].Value = discount;
            Rows[row].Cells[6].Value = subtotal;
            Rows[row].Cells[7].Value = picBox.Image;


            txtid.Clear();
            txtname.Clear();
            categorycombo.SelectedIndex = 0;
            txtprice.Clear();
            txtqty.Clear();
            txtsubtotal.Clear();
            picBox.Image = Properties.Resources.noimage;
            discount10.Checked = false;
            discount5.Checked = false;
            dgvProduct.ClearSelection();
        
        }

        private void dgvProduct_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvProduct.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProduct.CurrentRow;

                txtid.Text = selectedRow.Cells[0].Value.ToString();
                txtname.Text = selectedRow.Cells[1].Value.ToString();
                categorycombo.Text = selectedRow.Cells[2].Value.ToString();
                txtprice.Text = selectedRow.Cells[3].Value.ToString().Replace("$", "");
                txtqty.Text = selectedRow.Cells[4].Value.ToString();

                txtsubtotal.Text = selectedRow.Cells[6].Value.ToString();
                picBox.Image = (Image)selectedRow.Cells[7].Value;
                int discount = int.Parse(selectedRow.Cells[5].Value.ToString());
                if (discount == 5)
                    discount5.Checked = true;
                else if (discount == 10)
                    discount10.Checked = true;
                else
                {
                    discount5.Checked = false;
                    discount10.Checked = false;
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
            form.total = total;
            form.txttotal.Text = total.ToString("$0.00l");  
            form.Show();
        }
       

        private void FrmUpdate_Load(object sender, EventArgs e)
        {
           
        }
    }
}
