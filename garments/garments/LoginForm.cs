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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegisterForm().Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            try
            {
                
                string dbname = "Garments";
                string servsername = "DESKTOP-8G86QJP";
                DataConnection.ConnectionDB(servsername, dbname);
                string sqlc = "select * from tbllogin";
                SqlCommand sql = new SqlCommand(sqlc, DataConnection.DataCon);
                SqlDataReader reader = sql.ExecuteReader();
                string user_name = txtusername.Text;
                string password = txtpassword.Text;
                bool loginSuccess = false;

                while (reader.Read())
                {
                    if (user_name.Equals(reader[1].ToString()) && password.Equals(reader[2].ToString()))
                    {
                        loginSuccess = true;
                        break;
                    }
                }

                if (loginSuccess)
                {
                    MessageBox.Show("Login Successfully", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new Garments().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusername.Focus();
                }
                
                reader.Close();
                sql.Dispose();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
