using System;
using System.Windows.Forms;

namespace C__Sql_Server
{
    public partial class frmAuthentication : Form
    {
        public frmAuthentication()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void frmAuthentication_Load(object sender, EventArgs e)
        {
            cboauthentication.SelectedIndex = 0;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                string ip = txtip.Text;
                string dbname = "DBSU44";
                string username = txtusername.Text.Trim();
                string password = txtpassword.Text;
                int index = cboauthentication.SelectedIndex;
                if (index == 0)
                {
                    // window authentication
                    DBConnection.ConnectionDB(ip, dbname);

                }
                else
                {
                    // sql server authentication 
                    DBConnection.ConnectionDB(ip, dbname, username, password);
                }
               this.Hide();
                new OptioneMenu().Show();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboauthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboauthentication.SelectedIndex;
            if (index == 0)
            {
                txtusername.Enabled = false;
                txtpassword.Enabled = false;


            }
            else
            {


                txtusername.Enabled = true;
                txtpassword.Enabled = true;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAuthentication_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
