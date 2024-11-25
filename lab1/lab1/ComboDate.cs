using System;
using System.Windows.Forms;

namespace lab1
{
    public partial class ComboDate : Form
    {
        public ComboDate()
        {
            InitializeComponent();
        }

        private void yearcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateDay();
        }


        private void CreateDay()
        {
            int month = monthcombo.SelectedIndex + 1;
            int year = int.Parse(yearcombo.SelectedItem+ "");
            
            if (month >= 1)
            {
                int maxday = DateTime.DaysInMonth(year, month);
                daycombo.Items.Clear();
                for (int i = 1; i <= maxday; i++)
                {
                    daycombo.Items.Add(i);
                }
                int oldday;

                if(daycombo.Text!= "")
                {
                    oldday = int.Parse(daycombo.Text);
                    if(daycombo.Items.IndexOf(oldday) < 0)
                    {
                        daycombo.SelectedItem = maxday;
                    }
                }
            }
            
        }

        private void ComboDate_Load(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            for(int i = year - 200; i <= year+200; i++)
            {
                yearcombo.Items.Add(i);
            }
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            yearcombo.SelectedItem = year;
            monthcombo.SelectedIndex = month - 1;
            daycombo.SelectedItem = day;
        }

        private void monthcombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CreateDay();
        }
    }
}
