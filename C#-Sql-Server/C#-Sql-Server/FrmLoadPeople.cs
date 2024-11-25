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
    public partial class FrmLoadPeople : Form
    {
        public FrmLoadPeople()
        {
            InitializeComponent();
        }
        void loadPeople()
        {
            try
            {
                string sql = "select * from tbl_people";
                SqlCommand cmd = new SqlCommand(sql, DBConnection.DataCon);
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    string id = r[0] + "";
                    string name = r[1] + "";
                    string gender = r[2] + "";
                    string phone = r[3] + "";
                    string email = r[4] + "";
                    dgvpeople.Rows.Add(id, name, gender, phone, email);
                }
                r.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           


        }
        private void FrmLoadPeople_Load(object sender, EventArgs e)
        {
            loadPeople();
        }
    }
}
