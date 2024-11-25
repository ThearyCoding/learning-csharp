using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
namespace accesswithC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void names_Table()
        {
            string filepaht = txtpath.Text;
            string connstr;
            if (filepaht.EndsWith(".mdb"))
            {
                connstr = string.Format("Provider=Microsoft.jet.oledb.4.0;Data Source = " + filepaht);
            }
            else
            {
                connstr = string.Format("Provider=Microsoft.ace.oledb.12.0;Data Source = " + filepaht);
            }

            using (var conn = new OleDbConnection(connstr))
            {
                conn.Open();
                var dt = conn.GetSchema("Tables", new string[] { null, null, null, "Table" });
                guna2ComboBox1.DataSource = dt;
                guna2ComboBox1.DisplayMember = "table_name";
                guna2ComboBox1.ValueMember = "table_name";
                conn.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ace.oledb.12.0;Data Source=C:\Users\MSI\source\repos\accesswithC#\Database1.accdb;Persist Security Info=False;";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection opened successfully.");

                    // Perform database operations here...

                }
                catch (OleDbException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                        Console.WriteLine("Connection closed.");
                    }
                }
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "access|*.accdb;*.mdb";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtpath.Text = Path.GetFullPath(openFileDialog1.FileName);
                names_Table();
            }
            else
            {
                MessageBox.Show("Please select file");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string filepaht = txtpath.Text;
            string connstr;
            if (filepaht.EndsWith(".mdb"))
            {
                connstr = string.Format("Provider=Microsoft.jet.oledb.4.0;Data Source = " + filepaht);
            }
            else
            {
                connstr = string.Format("Provider=Microsoft.ace.oledb.12.0;Data Source = " + filepaht);
            }

            using (var conn = new OleDbConnection(connstr))
            {
                OleDbCommand cmd = new OleDbCommand(guna2TextBox2.Text);
                OleDbDataAdapter da = new OleDbDataAdapter();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                try
                {
                    da.Fill(dt);
                }catch (Exception ex)
                {
                    MessageBox.Show("Please select type correct code");
                }


                guna2DataGridView1.DataSource = dt;
            }


        }
    }
}
