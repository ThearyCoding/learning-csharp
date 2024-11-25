using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Midterm_Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string photo;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                photo = ofd.FileName;
                Image img = Image.FromFile(ofd.FileName);
                picturebox.Image = img;
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtid.Text.Trim();
                string barcode = txtbarcode.Text;
                string name = txtname.Text;
                string unitprice = txtunitprice.Text;
                string category = comboCatagory.Text;





                string im = photo;
                string[] rows = { id,barcode,name,unitprice,category,im};

                ListViewItem newItem = new ListViewItem(rows);

                
                listviewItem.Items.Add(newItem);

            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter numeric values for ID, Barcode, and Unit Price.");
            }
            finally
            {
                txtid.Clear();
                txtbarcode.Clear();
                txtname.Clear();
                txtunitprice.Clear();
                comboCatagory.SelectedIndex = 0;
                picturebox.Image = Properties.Resources.noimage;
            }
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            comboCatagory.SelectedIndex = 0;
        }

        private void listviewItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listviewItem.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = listviewItem.SelectedItems[0];

                txtid.Text = selectedRow.SubItems[0].Text;
                txtbarcode.Text = selectedRow.SubItems[1].Text;
                txtname.Text = selectedRow.SubItems[2].Text;
                txtunitprice.Text = selectedRow.SubItems[3].Text;
                comboCatagory.Text = selectedRow.SubItems[4].Text;

                
                string imagePath = selectedRow.SubItems[5].Text;

                
                    picturebox.Image = Image.FromFile(imagePath);
               
            }
        }


        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (listviewItem.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = listviewItem.SelectedItems[0];


                selectedRow.SubItems[0].Text = txtid.Text;
                selectedRow.SubItems[1].Text = txtbarcode.Text;
                selectedRow.SubItems[2].Text = txtname.Text;
                selectedRow.SubItems[3].Text = txtunitprice.Text;
                selectedRow.SubItems[4].Text = comboCatagory.Text;
                selectedRow.SubItems[5].Text = photo;
                txtid.Clear();
                txtbarcode.Clear();
                txtname.Clear();
                txtunitprice.Clear();
                comboCatagory.SelectedIndex = 0;
                picturebox.Image = Properties.Resources.noimage;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (listviewItem.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = listviewItem.SelectedItems[0];

                listviewItem.Items.Remove(selectedRow);

                txtid.Clear();
                txtbarcode.Clear();
                txtname.Clear();
                txtunitprice.Clear();
                comboCatagory.SelectedIndex = 0;
                picturebox.Image = Properties.Resources.noimage;

            }
        }

       
    }
}
