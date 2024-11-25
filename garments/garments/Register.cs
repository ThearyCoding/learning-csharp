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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime currentDate = DateTime.Now;
                string registerDate = currentDate.ToString("yyyy-MM-dd");
                string registerTime = currentDate.ToString("HH:mm:ss");
                string username = txtusername.Text.Trim();
                string password = txtpassword.Text.Trim();
                string confirm = txtconfirm.Text.Trim();
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirm))
                {
                    MessageBox.Show("all in field can't emtpy");
                }
                else
                {

                    if (confirm == password)
                    {
                        string sqlstatement = "INSERT INTO tbllogin (username, password, registerDate, registerTime) VALUES ('" + username + "','" + password + "','" + registerDate + "','" + registerTime + "')";
                        string dbname = "Garments";
                        string serverName = "DESKTOP-8G86QJP";

                        DataConnection.ConnectionDB(serverName, dbname);
                        SqlCommand sqlcommand = new SqlCommand(sqlstatement, DataConnection.DataCon);
                        sqlcommand.ExecuteNonQuery();
                        sqlcommand.Dispose();
                        txtusername.Clear();
                        txtpassword.Clear();
                        txtconfirm.Clear();
                        MessageBox.Show("Register Successful");
                    }
                    else
                    {
                        MessageBox.Show("Password and Confirm Password do not match.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
