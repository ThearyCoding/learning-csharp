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
    public partial class Garments : Form
    {
        public Garments()
        {
            InitializeComponent();
        }
        string dbname = "Garments";
        string servsername = "DESKTOP-8G86QJP";
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            this.Close();
            new AddStoke().ShowDialog();
        }

        private void Garments_Load(object sender, EventArgs e)
        {
            try
            {


                DataConnection.ConnectionDB(servsername, dbname);
                string sql = "select * from tblgarments";
                SqlCommand sqlCommand = new SqlCommand(sql, DataConnection.DataCon);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                dataviewgarments.Rows.Clear();
                while (reader.Read())
                {
                    string id = reader[0].ToString();
                    string name = reader[1].ToString();
                    string brand_id= reader[2].ToString();
                    string price = reader[3].ToString();
                    string size = reader[4].ToString();
                    string color = reader[5].ToString();
                    string material = reader[6].ToString();

                    dataviewgarments.Rows.Add(id, name, brand_id, price, size, color, material);
                }
                reader.Close();
                sqlCommand.Dispose();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
