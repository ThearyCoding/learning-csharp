using System;
using System.Windows.Forms;

namespace lab1
{
    public partial class TaxSalary : Form
    {
        public TaxSalary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salary = double.Parse(txtsalary.Text);
            double bonus = double.Parse(txtbonus.Text);
            int spouse = int.Parse(txtspouse.Text);
            int child = int.Parse(txtchil.Text);
            double tax = 0.0;
            double lastsalary = 0.0;

            if(salary >= 0 && bonus >= 0)
            {
                if (spouse >= 1)
                {
                    spouse = 1;
                }
                else
                {
                    spouse = 0;
                }

                if (child >= 9)
                {
                    child = 9;
                }
                else if (child <= 0)
                {
                    child = 0;
                }
                txtspouse.Text = spouse.ToString();
                txtchil.Text = child.ToString();
                double family = 150000 * (spouse + child);
                salary -= family;
                salary -= bonus;
                if (salary >= 0 && salary <= 1200000)
                {
                    tax = 0;
                }
                else if (salary >= 1200001 && salary <= 2000000)
                {
                    tax = salary * 0.05 - 60000;
                }
                else if (salary >= 2000001 && salary <= 8500000)
                {
                    tax = salary * 0.1 - 160000;
                }
                else if (salary >= 8500001 && salary <= 12500000)
                {
                    tax = salary * 0.15 - 585000;
                }
                else
                {
                    tax = salary * 0.2 - 1210000;
                }
                
                
                tax += bonus * 0.2;
                lastsalary = (salary + family + bonus) - tax;
                lbtax.Text = $"{tax:#,##0.## R}";
                lblastsalary.Text = $"{lastsalary:#,##0.## R}";
            }
            else
            {
                MessageBox.Show("Invalid Input ");
            }
        }

        private void lbtax_Click(object sender, EventArgs e)
        {

        }
    }
}
