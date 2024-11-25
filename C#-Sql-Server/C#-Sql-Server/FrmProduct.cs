using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace C__Sql_Server
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private List<string>  categoriesId = new List<string>();

        public void loadCategories()
        {
            try
            {
                string sql = "select * from tblcategories;";
                SqlCommand cmd = new SqlCommand(sql,DBConnection.DataCon);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    string cid = r[0] + "";
                    string cname = r[1] + "";
                    cbocname.Items.Add(cname);
                    categoriesId.Add(cid);
                }
                r.Close();
                cmd.Dispose();
                cbocname.SelectedIndex = 0;
            }catch (Exception ex)
            {
                MessageBox.Show($"Error Load Categories : {ex.Message}");
            }
        }
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string barcode = txtbarcode.Text;
            string pname = txtpname.Text;
            string pricein = txtpricein.Text;
            string priceout = txtpriceout.Text;
            string qty = txtqty.Text;
            string cid = txtcid.Text;

            if(string.IsNullOrEmpty(barcode) || string.IsNullOrEmpty(pname) || string.IsNullOrEmpty(pricein) || string.IsNullOrEmpty(priceout) || string.IsNullOrEmpty(qty))
            {
                MessageBox.Show("all field can not be empty!");
                return;
            }
            string sql = "INSERT INTO tblproduct VALUES ("+barcode+",'"+pname+"',"+qty+","+pricein+","+priceout+","+cid+", '"+destPhoto+"');";

            SqlCommand cmd = new SqlCommand(sql,DBConnection.DataCon);
            File.Copy(sourcePhoto, destPhoto);
            cmd.ExecuteNonQuery();
            cmd.Dispose ();
            txtbarcode.Clear();
            txtpname.Clear();
            txtpricein.Clear();
            txtpriceout.Clear();
            txtqty.Clear();
            cbocname.SelectedIndex = 0;
            MessageBox.Show("Successfully 1 affold");
        }
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            loadCategories();
        }

        private void cbocname_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbocname.SelectedIndex;
            txtcid.Text = categoriesId[index];
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new OptioneMenu().Show();
        }

        private void FrmProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose ();
            new OptioneMenu().Show();
        }
        string destPhoto,sourcePhoto;
        private void picbox_Click(object sender, EventArgs e)
        {
            OpenFileDialog odf = new OpenFileDialog();
            DialogResult result = odf.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = odf.FileName;
                picbox.Image = Image.FromFile(filename);
                destPhoto = "photos\\" + Path.GetFileName(filename);
                sourcePhoto = filename;

            }
        }
    }
}
