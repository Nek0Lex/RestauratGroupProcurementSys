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
using MySql.Data;

namespace ProcurementSystem
{
    public partial class ScheduleRelease : Form
    {
        public ScheduleRelease()
        {

        }
        public ScheduleRelease(string getPPONo)
        {
            InitializeComponent();
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
            cnn.Open();
            String SRno="";
            textBox8.Text = getPPONo;
            String query = "select MAX(sr.SRNo) from SheduleRelease sr, SheduleReleaseLines srl where sr.SRNo = srl.SRNo AND srl.PPONo ='"+getPPONo+"'";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            SRno = cmd.ExecuteScalar().ToString();
            textBox3.Text = SRno;
            String query2 = "select * from SheduleRelease where SRNo = '" + SRno + "';";
            MySqlDataAdapter cmd2 = new MySqlDataAdapter(query2, cnn);
            DataTable dt = new DataTable();
            cmd2.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                shippingAddress.Text = dr["DeliveryAddress"].ToString();
                DateTime creationdate = Convert.ToDateTime(dr["CreationDate"].ToString());
                creationDate.Value = creationdate;
                DateTime effectivedate = Convert.ToDateTime(dr["EffectiveDate"].ToString());
                effectiveDate.Value = effectivedate;
            }
        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    String srno = SRNo.Text;
        //    MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
        //    cnn.Open();
        //    String query = "select * from SheduleRelease where SRNo = '"+srno+"';";
        //    MySqlCommand cmd = new MySqlCommand(query, cnn);
        //    MySqlDataReader dr =  cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        shippingAddress.Text = dr.GetString("DeliveryAddress");
        //        DateTime creationdate = dr.GetDateTime("CreationDate");
        //        creationDate.Value = creationdate;
        //        DateTime effectivedate = dr.GetDateTime("EffectiveDate");
        //        effectiveDate.Value = effectivedate;
        //    }
        //}

        private void ScheduleRelease_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void requestNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            String CreationDate = creationDate.Value.ToString("yyyy-MM-dd");
            String EffectiveDate = effectiveDate.Value.ToString("yyyy-MM-dd");
            String ShippingAddress = shippingAddress.Text;
            String srno = textBox3.Text;
        
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
            cnn.Open();
            String query = "UPDATE SheduleRelease SET CreationDate = '"+CreationDate+"', " +
                "EffectiveDate = '" + EffectiveDate + "'" +
                "DeliveryAddress = '"+ShippingAddress+"' WHERE SRNo = '"+srno+"' ;";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlCommand insertPPOLine = new MySqlCommand("INSERT" , cnn);
            cnn.Close();

            MessageBox.Show("Change successfully!");
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
