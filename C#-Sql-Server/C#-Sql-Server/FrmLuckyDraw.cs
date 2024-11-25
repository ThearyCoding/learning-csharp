using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace C__Sql_Server
{
    public partial class FrmLuckyDraw : Form
    {
        public FrmLuckyDraw()
        {
            InitializeComponent();
        }
        private List<People> peoples;
        private int index;
        private List<People> winner = new List<People>();
        private void btnstart_Click(object sender, EventArgs e)
        {
            if (peoples.Count == 0)
            {
                MessageBox.Show("No more People");
                return;
            }
            try
            {
                string start = btnstart.Text;

                if (start == "Start")
                {
                    timer1.Start();
                    btnstart.Text = "Stop";
                }
                else
                {
                    timer1.Stop();
                    btnstart.Text = "Start";
                  


                    if (winner.Count < 3)
                    {
                        winner.Add(peoples[index]);
                        lstwinner.Items.Add(peoples[index].phone);
                        peoples.RemoveAt(index);
                        txtgenerate.Clear();
                    }
                    else
                    {
                        btnstart.Enabled = false;
                        txtgenerate.Clear();
                   //     MessageBox.Show("You can only win three times.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void loadPeople()
        {
            try
            {
                peoples = new List<People>();
                string sql = "select * from tbl_people";
                SqlCommand cmd = new SqlCommand(sql, DBConnection.DataCon);
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    string id = r[0] + "";
                    string name = r[1] + "";
                    string gender = r[2] + "";
                    string phone = r[3] + "";
                    string email = r[4] + "";

                    People p = new People(id, name, gender,phone, email);
                    peoples.Add(p);
                   
                }
                r.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        private void FrmLuckyDraw_Load(object sender, EventArgs e)
        {
            loadPeople();
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (peoples == null || peoples.Count == 0)
            {
                return;
            }
            Random rand = new Random();
            index = rand.Next(peoples.Count);
            string phone = peoples[index].phone;
            txtgenerate.Text = phone;
        }

        private void lstwinner_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lstwinner.SelectedIndex;
            string id = winner[i].id;
            string name = winner[i].name;
            string gender = winner[i].gender;
            string phone = winner[i].phone;
            string email = winner[i].email;
            dgvpeople.Rows.Clear();
            dgvpeople.Rows.Add(id, name, gender, email);
        }
    }
}
