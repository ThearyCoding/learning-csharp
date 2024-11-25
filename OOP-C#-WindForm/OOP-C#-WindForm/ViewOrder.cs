using System;
using System.Windows.Forms;

namespace OOP_C__WindForm
{
    public partial class ViewOrder : Form
    {
        public ViewOrder()
        {
            InitializeComponent();
            CalculateTotalAmount();
        }

        public DataGridViewRowCollection getrow()
        {
            return dgvorder.Rows;
        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
        }

        public void CalculateTotalAmount()
        {
            double totalAmount = 0;
            foreach (DataGridViewRow row in dgvorder.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    totalAmount += double.Parse(row.Cells[4].Value.ToString().Replace("$",""));
                }
            }

            txttotalamount.Text = totalAmount.ToString("$0.00");
        }
    }
}
