using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProcurementSystem
{
    public partial class SRConnector : Form
    {
        public SRConnector()
        {
            InitializeComponent();
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
            cnn.Open();
            String query = "select * from PPO;";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                String ppono = dr.GetString("PPONo");
                pposelection.Items.Add(ppono);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_openSR_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(pposelection.Text)){
                ScheduleRelease scheduleRelease = new ScheduleRelease(pposelection.Text);
                scheduleRelease.Show();
                this.Close();
            }
        }
    }
}
