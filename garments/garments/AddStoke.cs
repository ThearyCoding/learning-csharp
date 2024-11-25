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

namespace garments
{
    public partial class AddStoke : Form
    {
        public AddStoke()
        {
            InitializeComponent();
        }
        string dbname = "Garments";
        string servsername = "DESKTOP-8G86QJP";
        private List<string> brand_id = new List<string>();
        private void AddStoke_Load(object sender, EventArgs e)
        {
            try
            {

                
                DataConnection.ConnectionDB(servsername, dbname);
                string sql = "select * from tblbrands";
                SqlCommand sqlCommand = new SqlCommand(sql, DataConnection.DataCon);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    string bid = reader[0].ToString();
                    string bname = reader[1].ToString();
                    brand_id.Add(bid);

                    cboBrandName.Items.Add(bname);
                    
                }
                reader.Close();
                sqlCommand.Dispose();
                cboBrandName.SelectedIndex = 0;
                cbosize.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboBrandName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               int index = cboBrandName.SelectedIndex;
                txtbid.Text = brand_id[index];
            }catch(Exception ex)
            {
                MessageBox.Show("error : ", ex.Message);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
               string name = txtname.Text;
               string bid = txtbid.Text;
               string price = txtprice.Text;
                string color = txtcolor.Text;
                string material = txtmaterial.Text;
                string size = cbosize.Text;
                DataConnection.ConnectionDB(servsername, dbname);
                string sql = "insert into tblgarments (name,brand_id,price,sizes,color,material) values ('"+name+"',"+bid+","+price+",'"+size+"','"+color+"','"+material+"');";
                SqlCommand sqlCommand = new SqlCommand(sql, DataConnection.DataCon);

                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();

                MessageBox.Show("Add to stoke successfully");
            }
            catch(Exception ex )
            {
                MessageBox.Show( "Error : ",ex.Message);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            new Garments().Show();
        }
    }
}
