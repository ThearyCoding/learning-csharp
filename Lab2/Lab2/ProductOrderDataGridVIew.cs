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
    public partial class ProductOrderDataGridVIew : Form
    {
        public ProductOrderDataGridVIew()
        {
            InitializeComponent();

            txttotal.Text = total.ToString();
        }

        private void ProductOrderDataGridVIew_Load(object sender, EventArgs e)
        {
            categorycombo.SelectedIndex = 0;
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg|All files (*.*)|*.*";
            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                im = Image.FromFile(ofd.FileName);
                picBox.Image = im;
            }
        }
        Image im;
        public double total = 0;
        public List<int> listId = new List<int>();
        private void btnadd_Click(object sender, EventArgs e)
        {


            int product_id = int.Parse(txtid.Text);
            if (listId.Contains(product_id))
            {
                MessageBox.Show("Duplicate product ID. Please enter a different ID.");
                return;

            }

            string product_name = txtname.Text;
            double product_price = double.Parse(txtprice.Text);
            string category = categorycombo.Text;
            int qty = int.Parse(txtqty.Text);
            double discount = 0;
            if (discount5.Checked == true)
                discount = 5;
            else if (discount10.Checked)
                discount = 10;

            double sub_total = qty * product_price - qty * product_price * discount / 100;

            txtsubtotal.Text = sub_total.ToString("$0.00");
            listId.Add(product_id);

            total += sub_total;
            txttotal.Text = total.ToString("$0.00");
            dgvProduct.Rows.Add(product_id.ToString("D3"), product_name, category, product_price.ToString("$0.00"), qty, discount, sub_total.ToString("$0.00"), im);
                
            txtid.Clear();
            txtname.Clear();
            categorycombo.SelectedIndex = 0;
            txtprice.Clear();
            txtqty.Clear();
            txtsubtotal.Clear();
            discount10.Checked = false;
            discount5.Checked = false;
            dgvProduct.ClearSelection();
            picBox.Image = Properties.Resources.noimage;


        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

           
        }
        private void dgvProduct_SelectionChanged(object sender, EventArgs e)
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

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                OpenFileDialog of = new OpenFileDialog();
                DialogResult dr = new DialogResult();
                dr = of.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Image im = Image.FromFile(of.FileName);
                    int i = e.RowIndex;
                    dgvProduct.Rows[i].Cells[7].Value = im;
                }
            }
        }

        private void btngotoedit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmUpdate(dgvProduct.Rows, listId, total, this).Show();
        }

        private void btngotoremove_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmRemove(dgvProduct.Rows, listId, total, this).Show();
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to remove.");
                return;
            }


            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            DataGridViewRow dr = new DataGridViewRow();
            if (result == DialogResult.Yes)
            {
                dr = dgvProduct.CurrentRow;
                double subtotalToRemove = double.Parse(dr.Cells[6].Value.ToString().Replace("$", ""));
                int listidToRemove = int.Parse(dr.Cells[0].Value.ToString());
                total -= subtotalToRemove;
                listId.Remove(listidToRemove);
                txttotal.Text = total.ToString("$0.00");
                dgvProduct.Rows.Remove(dr);

                txtid.Clear();
                txtname.Clear();
                categorycombo.SelectedIndex = 0;
                txtprice.Clear();
                txtqty.Clear();
                txtsubtotal.Clear();
                discount10.Checked = false;
                discount5.Checked = false;
                dgvProduct.ClearSelection();
                picBox.Image = Properties.Resources.noimage;
            }
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
