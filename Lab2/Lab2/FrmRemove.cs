using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab2
{
    public partial class FrmRemove : Form
    {
        public DataGridViewRowCollection Rows;
        public ProductOrderDataGridVIew form;
        public FrmRemove(DataGridViewRowCollection rows, List<int> listID, double total, ProductOrderDataGridVIew form)
        {
            InitializeComponent();
            this.Rows = rows;
            this.form = form;
            this.listId = listID;
            this.total = total;
            txttotal.Text = total.ToString("$0.00");
            foreach (DataGridViewRow temp in Rows)
            {
                int id = int.Parse(temp.Cells[0].Value.ToString());
                string name = temp.Cells[1].Value.ToString();
                string category = temp.Cells[2].Value.ToString();
                double price = double.Parse(temp.Cells[3].Value.ToString().Replace("$", ""));
                int qty = int.Parse(temp.Cells[4].Value.ToString());
                int discount = int.Parse(temp.Cells[5].Value.ToString());
                double subtotal = double.Parse(temp.Cells[6].Value.ToString().Replace("$", ""));
                Image im = (Image)temp.Cells[7].Value;
                dgvProduct.Rows.Add(id.ToString("D3"), name, category, price.ToString("$0.00"), qty, discount, subtotal.ToString("$0.00"), im);
            }
        }
        public double total = 0;
        public List<int> listId = new List<int>();
        private void btnremove_Click(object sender, EventArgs e)
        {
            // Check if any row is selected for removal
            if (dgvProduct.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to remove.");
                return;
            }

            // Ask for confirmation before deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If user confirms deletion
            if (result == DialogResult.Yes)
            {
                // Get the currently selected row
                DataGridViewRow dr = dgvProduct.CurrentRow;

                // Calculate the subtotal to remove from the total
                double subtotalToRemove = double.Parse(dr.Cells[6].Value.ToString().Replace("$", ""));

                // Get the ID of the item to remove from the list
                int listidToRemove = int.Parse(dr.Cells[0].Value.ToString());

                // Subtract the subtotal of the removed item from the total
                total -= subtotalToRemove;

                // Remove the ID of the removed item from the list of IDs
                listId.Remove(listidToRemove);

                // Update the total displayed in the textbox
                txttotal.Text = total.ToString("$0.00");

                // Remove the selected row from the DataGridView
                dgvProduct.Rows.Remove(dr);

                // Remove the selected row from the main form's DataGridView
                foreach (DataGridViewRow mainFormRow in form.dgvProduct.Rows)
                {
                    // Check if the ID of the row in the main form matches the ID of the removed row
                    if (mainFormRow.Cells[0].Value.ToString() == dr.Cells[0].Value.ToString())
                    {
                        // Remove the row from the main form's DataGridView
                        form.dgvProduct.Rows.Remove(mainFormRow);

                        // Clear the search textbox
                        txtsearch.Clear();

                        // Exit the loop after the removal
                        break;
                    }
                }
            }
        }



        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            // Get the search text entered by the user
            string searchText = txtsearch.Text.Trim().ToLower();

            // Clear the DataGridView before performing the search
            dgvProduct.Rows.Clear();

            // Initialize the total to zero before starting the search
            total = 0;

            // Iterate through each row in the Rows collection in mainform
            foreach (DataGridViewRow row in Rows)
            {
                // Get the ID and Name values from the cells of the current row
                string id = row.Cells[0].Value.ToString().ToLower();
                string name = row.Cells[1].Value.ToString().ToLower();

                // Check if either the ID or the Name contains the search text
                bool containsSearchText = id.Contains(searchText) || name.Contains(searchText);

                // If the search text is found in either ID or Name, add the row to the DataGridView
                if (containsSearchText)
                {
                    // Add a new row to the DataGridView and populate it with cell values from the current row
                    int newRowIdx = dgvProduct.Rows.Add();
                    DataGridViewRow newRow = dgvProduct.Rows[newRowIdx];
                    newRow.Cells[0].Value = row.Cells[0].Value; // ID
                    newRow.Cells[1].Value = row.Cells[1].Value; // Name
                    newRow.Cells[2].Value = row.Cells[2].Value; // Category
                    newRow.Cells[3].Value = row.Cells[3].Value; // Price
                    newRow.Cells[4].Value = row.Cells[4].Value; // Quantity
                    newRow.Cells[5].Value = row.Cells[5].Value; // Discount
                    newRow.Cells[6].Value = row.Cells[6].Value; // Subtotal
                    newRow.Cells[7].Value = row.Cells[7].Value; // Image

                    // Select the newly added row
                    newRow.Selected = true;

                    // Calculate the new total by adding the subtotal of the newly added row to the existing total
                    total += double.Parse(newRow.Cells[6].Value.ToString().Replace("$", ""));

                    // Set the text of txttotal to the updated total value formatted as currency
                    txttotal.Text = total.ToString("$0.00");
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Dispose();
            form.total = total;
            form.txttotal.Text = total.ToString("$0.00");
            form.Show();
        }
    }
}
