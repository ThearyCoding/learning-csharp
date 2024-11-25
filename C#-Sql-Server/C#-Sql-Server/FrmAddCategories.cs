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
    public partial class FrmAddCategories : Form
    {
        public FrmAddCategories()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        public void loadCategories()
        {
            try
            {
                datagridcategories.Rows.Clear();
                string sql = "select * from tblcategories;";
                SqlCommand cmd = new SqlCommand(sql, DBConnection.DataCon);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    string cid = r[0] + "";
                    string cname = r[1] + "";
                    datagridcategories.Rows.Add(cid, cname);
                }
                r.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Load Categories : {ex.Message}");
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            string cname = txtcname.Text;

            string sql = "insert into tblcategories values('"+cname+"');";
            SqlCommand cmd = new SqlCommand(sql, DBConnection.DataCon);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            MessageBox.Show("Categories is Affolded");
            loadCategories();
        }

        private void FrmAddCategories_Load(object sender, EventArgs e)
        {
            loadCategories();
        }

        private void FrmAddCategories_FormClosed(object sender, FormClosedEventArgs e)
        {
            new OptioneMenu().Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new OptioneMenu().Show();
        }
    }
}
