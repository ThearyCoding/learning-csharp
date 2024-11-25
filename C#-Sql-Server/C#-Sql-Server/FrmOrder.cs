using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Sql_Server
{
    public partial class FrmOrder : Form
    {
        List<OrderedItem> items = new List<OrderedItem>();
        private int checkPid (int pid)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (pid == items[i].PID)
                    return i;
            }
            return -1;
        }
        public string insertOrder()
        {

            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string time = DateTime.Now.ToString("HH:mm:ss");
            string orderSql = "insert into tblOrder (ordDate,ordTime) values ('" + date + "','" + time + "');";

            SqlCommand s = new SqlCommand(orderSql, DBConnection.DataCon);
            s.ExecuteNonQuery();
            orderSql = "SELECT SCOPE_IDENTITY()";
            s = new SqlCommand(orderSql, DBConnection.DataCon);
            SqlDataReader r = s.ExecuteReader();
            string ordID = "";
            if (r.Read())
            {
                ordID = r[0].ToString();
            }
            r.Close();
            s.Dispose();
            return ordID;
        }
        public void updateStock(string qty, string pid)
        {
            string sql = "update tblproduct set Qty-=" + qty + "where id = " + pid;
            SqlCommand s = new SqlCommand(sql, DBConnection.DataCon);
            s.ExecuteNonQuery();
            s.Dispose();
        }
        public FrmOrder()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        public bool OrderProduct(string barcode)
        {
            string sql = "select * from tblproduct where barcode = "+barcode+";";
            SqlCommand cmd = new SqlCommand(sql,DBConnection.DataCon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int num = dgvorder.Rows.Count + 1;
                string pname = dr[2].ToString();
                int id = int.Parse(dr[0].ToString());
                int index = checkPid(id);
                int qty = 1;
                double price = double.Parse(dr[5].ToString());
                double amount = qty * price;
                if (index >= 0)
                {
                    qty = items[index].Qty + 1;
                    amount = qty * price;
                    dgvorder.Rows[index].Cells[2].Value = qty;
                    dgvorder.Rows[index].Cells[4].Value = amount;
                    items[index].Qty = qty;
                }
                else
                {
                    OrderedItem item = new OrderedItem(id,qty,price);
                    items.Add(item);
                    dgvorder.Rows.Add(num, pname, qty, price, amount);
                }
                
                
                dr.Close();
                cmd.Dispose();
                return true;
            }
            else
            {
                dr.Close (); cmd.Dispose();  return false;
            }
            
        }

        public double TotalOrdered()
        {
            double total = 0;
            foreach (var item in items)
            {
                total += item.Qty * item.Price;
            }
            return total;
        }
        private void txtbarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                string barcode = txtbarcode.Text;
                if (OrderProduct(barcode))
                {
                    txtbarcode.Clear();
                    txttotal.Text = TotalOrdered().ToString();
                    MessageBox.Show("Product in stock");
                }
                else
                {
                    txtbarcode.Clear();
                    MessageBox.Show("Product not in database");
                }
            }
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {

        }

        private void FrmOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            new OptioneMenu().Show();
        }
    }
}
