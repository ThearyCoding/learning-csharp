using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OOP_C__WindForm
{
    public partial class OrderProduct : Form
    {
        public OrderProduct()
        {
            InitializeComponent();
            tableLayoutPanel1.AutoScroll = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] fileName = Directory.GetFiles("C:\\Users\\MSI\\Desktop\\photo");
            int y = 1;
            int x = 0;
            Random random = new Random();
            int id = 0;
            ProductControl.data = orderView.getrow();
            orderView.CalculateTotalAmount();
            foreach (var item in fileName)
            {
                Image im = Image.FromFile(item);
                string pname = Path.GetFileNameWithoutExtension(item);
                double price = random.NextDouble() * 4 + 1;
                id++;
                ProductControl p = new ProductControl(im, pname, price, id,orderView); // Pass the ViewOrder reference
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tableLayoutPanel1.Controls.Add(p, y, x);
                y++;
                if (y >= 5)
                {
                    y = 1;
                    x++;
                }
            }
        }

        ViewOrder orderView = new ViewOrder();

        private void vIewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderView.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
