using System;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_C__WindForm
{
    public partial class ProductControl : UserControl
    {
        private double _price;
        private ViewOrder viewOrder;

        public ProductControl(Image im, string name, double price, int id, ViewOrder viewOrder)
        {
            InitializeComponent();
            this.id = id;
            this.im = im;
            this.name = name;
            this.Price = price;
            this.viewOrder = viewOrder; // Set the reference to ViewOrder
            btncancel.Visible = false;
        }

        public int qty { get; set; }

        public Image im
        {
            set => pic.Image = value;
            get => pic.Image;
        }

        public string name
        {
            set => txtname.Text = value;
            get => txtname.Text;
        }

        public int id { get; set; }

        public double Price
        {
            get => _price;
            set
            {
                _price = value;
                txtprice.Text = _price.ToString("$0.00");
            }
        }

        public static DataGridViewRowCollection data;

        public int FindRowIndex(int id)
        {
            for (int i = 0; i < data.Count; i++)
            {
                int idorder = int.Parse(data[i].Cells[0].Value.ToString());
                if (idorder == id)
                {
                    return i;
                }
            }
            return -1;
        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            btncancel.Visible = true;
            qty++;
            double amount = Price * qty;
            if (qty > 0)
            {
                btnorder.Text = $"Order({qty})";
                int rowIndex = FindRowIndex(id);
                if (rowIndex == -1)
                {
                    data.Add(id, name, Price, qty, amount.ToString("$0.00"));
                }
                else
                {
                    data[rowIndex].Cells[3].Value = qty;
                    data[rowIndex].Cells[4].Value = amount.ToString("$0.00");
                }

                viewOrder.CalculateTotalAmount(); // Update the total amount
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            qty--;
            int rowIndex = FindRowIndex(id);
            double amount = Price * qty;
            if (rowIndex != -1)
            {
                if (qty < 1)
                {
                    data.RemoveAt(rowIndex);
                    btnorder.Text = "Order";
                    btncancel.Visible = false;
                }
                else
                {
                    data[rowIndex].Cells[3].Value = qty;
                    data[rowIndex].Cells[4].Value = amount.ToString("$0.00");
                    btnorder.Text = $"Order({qty})";
                }

                viewOrder.CalculateTotalAmount(); // Update the total amount
            }
        }
    }
}
