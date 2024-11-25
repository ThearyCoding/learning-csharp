using System;
using System.Windows.Forms;

namespace lab1
{
    public partial class NewCon : Form
    {
        public NewCon()
        {
            InitializeComponent();
        }
        private bool isExist(string newCountry)
        {
            for(int i = 0; i < combcountry.Items.Count; i++)
            {
                string oldcountry = combcountry.Items[i].ToString();

                if(oldcountry.ToLower() == newCountry.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            string newcon = txtcon.Text.Trim();
            if(newcon != "")
            {
                if (isExist(newcon))
                {
                    MessageBox.Show("is alread have in combobox");
                }
                else
                {
                    combcountry.Items.Add(newcon);
                    MessageBox.Show("add to combobox successfullly");

                }
            }
            else
            {
                MessageBox.Show("Please enter a country");
            }

            txtcon.Clear();
            
        }

        private void NewCon_Load(object sender, EventArgs e)
        {

            combcountry.SelectedIndex = 1;
        }
    }
}
