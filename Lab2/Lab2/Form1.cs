using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lstEmployee.Items.Add("James");
            lstEmployee.Items.Add("David");
            lstEmployee.Items.Add("Henry");
            lstEmployee.Sorted = true;
            lstEmployee.SelectionMode = SelectionMode.MultiExtended;
            lstEmployee.Items.Clear();
            //lstEmployee.MultiColumn = true; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int id;
            string name, gender, benRet, benMed;
            id = int.Parse(txtEmpID.Text);
            name = txtEmpName.Text;
            if (radFemale.Checked == true)
                gender = "Female";
            else if (radMale.Checked)
                gender = "Male";
            else
                gender = "Others";

            if (chkRetirement.Checked)
                benRet = "Yes";
            else
                benRet = "No";
            if (chkMedical.Checked)
                benMed = "Yes";
            else
                benMed = "No";

            string itm = id + "\t" + name + "\t\t" + gender + "\t\t" + benRet + "\t" + benMed;
            lstEmployee.Items.Add(itm);
        }
        private void btnremove_Click(object sender, EventArgs e)
        {
            List<Object> itemsToRemove = new List<Object>();

            foreach (var selectedItem in lstEmployee.SelectedItems)
            {
                itemsToRemove.Add(selectedItem);
            }

            foreach (var itemToRemove in itemsToRemove)
            {
                lstEmployee.Items.Remove(itemToRemove);
            }
            //string itm = lstEmployee.SelectedItem+"";
    //lstEmployee.Items.Remove(itm);
    int i = lstEmployee.SelectedIndex;
    if (i!=-1)
        lstEmployee.Items.RemoveAt(i);

            //ListBox.SelectedObjectCollection selectedItems = lstEmployee.SelectedItems;

            //while (selectedItems.Count > 0)
            //{
            //    lstEmployee.Items.Remove(selectedItems[0]);
            //}
        }
    }
}
