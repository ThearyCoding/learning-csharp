using System;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace accesswithC_
{
    public partial class Product : Form
    {
        byte[] imageBytes;
        string selectedImagePath;

        public Product()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MSI\source\repos\accesswithC#\accesswithC#\bin\Debug\su44.mdb;Persist Security Info=False;"))
                {
                    conn.Open();
                    MessageBox.Show("Successfully connected to the database.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Assuming you have a DataGridView named 'viewlist' with the necessary columns already defined
        // Assuming you have a DataGridView named 'viewlist' with the necessary columns already defined
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MSI\source\repos\accesswithC#\accesswithC#\bin\Debug\su44.mdb;Persist Security Info=False;"))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Product";
                    OleDbCommand cmd = new OleDbCommand(sql, conn);
                    viewlist.Rows.Clear();

                    using (OleDbDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            string id = rd["product_id"].ToString();
                            string name = rd["product_name"].ToString();
                            string price = rd["product_price"].ToString();
                            string qty = rd["product_qty"].ToString();

                            object imageObject = rd["product_image"];

                            Image image = null;
                            if (imageObject != DBNull.Value)
                            {
                                image = ByteArrayToImage((byte[])imageObject);
                            }

                            viewlist.Rows.Add(id, name, price, qty, image);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Convert byte array to Image
        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }


        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
                openFileDialog.Title = "Select an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog.FileName;
                    imageBytes = File.ReadAllBytes(selectedImagePath);

                    if (guna2ImageButton1.Image == null)
                    {
                        guna2ImageButton1.Image = Image.FromFile(selectedImagePath);
                    }
                    else
                    {
                        MessageBox.Show("Image already set. Clear or replace the existing image.");
                    }
                }
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MSI\source\repos\accesswithC#\accesswithC#\bin\Debug\su44.mdb;Persist Security Info=False;"))
                {
                    conn.Open();

                    string sqlStatement = "INSERT INTO Product (product_name, product_price, product_qty, product_image) VALUES (@product_name, @product_price, @product_qty, @product_image)";
                    using (OleDbCommand cmd = new OleDbCommand(sqlStatement, conn))
                    {
                        try
                        {
                            // Assuming conn is your OleDbConnection object

                            // Add parameters with actual values
                            cmd.Parameters.AddWithValue("@product_name", txtname.Text);
                            cmd.Parameters.AddWithValue("@product_price", txtprice.Text);
                            cmd.Parameters.AddWithValue("@product_qty", int.Parse(txtqty.Text));

                            // Add the image data as a parameter
                            cmd.Parameters.AddWithValue("@product_image", imageBytes);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Insert successful!");
                            }
                            else
                            {
                                MessageBox.Show("Insert failed!");
                            }

                            txtname.Clear();
                            txtprice.Clear();
                            txtqty.Clear();
                            viewlist.Rows.Add( );
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
