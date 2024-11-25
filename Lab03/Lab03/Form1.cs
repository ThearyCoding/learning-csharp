using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         Employee emp = new Employee();
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            this.emp.Id = int.Parse(txtid.Text);
            this.emp.Name = txtname.Text;
            this.emp.gender = cbogender.SelectedItem.ToString();
            this.emp.houre = double.Parse(txtwage.Text);
            this.emp.dob = DateTime.Parse(pickerdate.Text);
            this.emp.wage = double.Parse(txtwage.Text);
            double salary = emp.calculateSalary(this.emp.wage, this.emp.houre);
            dataGridView.Rows.Add(emp.Id,emp.Name,emp.gender,emp.dob.ToString("dd-MM-yy"), emp.wage,emp.houre,salary);
        }
    }
}
