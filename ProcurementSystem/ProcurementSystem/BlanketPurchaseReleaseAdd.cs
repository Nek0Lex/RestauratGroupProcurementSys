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
    public partial class BlanketPurchaseReleaseAdd : Form
    {
        public BlanketPurchaseReleaseAdd()
        {
            InitializeComponent();
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
            cnn.Open();
            String query = "select * from BlanketPurchaseAgreement;";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                String BPAno = dr.GetString("BPANo");
                bpaNoSelection.Items.Add(BPAno);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                String bpaNo = bpaNoSelection.Text;
                String ReleaseNo = releaseNo.Text;
                String RequestNo = requestNo.Text;
                String CreationDate = creationDate.Value.ToString("yyyy-MM-dd");
                String DeliveryDate = deliveryDate.Value.ToString("yyyy-MM-dd");
                String RestNo = restNo.Text;
                String Account = account.Text;
                String Amount = actualAmount.Text;
                String Quantity = quantity.Text;

                MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
                cnn.Open();
                String queryI = "INSERT INTO BlanketPurchaseRelease (ReleaseNo, RequestNo, BPANo, CreationDate, RestNo, DeliveryDate, Account, ActualAmount, ActualQuantity)" +
                    "VALUES('" + ReleaseNo + "', '" + RequestNo + "', '" + bpaNo + "', '" + CreationDate + "', '" + RestNo + "', '" + DeliveryDate + "', '" + Account + "', '" + Amount + "', '" + Quantity + "');";
                MySqlCommand cmd = new MySqlCommand(queryI, cnn);
                cmd.ExecuteNonQuery();
                
                //trans itemname to itemid
                /*
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    String item = row.Cells["ItemName"].Value.ToString();
                    queryI = "SELECT * FROM Item WHERE ItemName = '" + item + "'; ";
                    cnn.Open();
                    cmd = new MySqlCommand(queryI, cnn);
                    MySqlCommand cmdI = new MySqlCommand(queryI, cnn);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        String result = dr["ItemID"].ToString();
                        String queryI = "INSERT INTO BPReleaseLines (ReleaseNo, ItemID, Quantity)" +
                            "VALUES ('" + ReleaseNo + "' , '" + result + "', '" + Quantity + ")";
                        MySqlCommand cmdI = new MySqlCommand(queryI, cnn);
                        cmdI.ExecuteNonQuery();
                    }*/

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        MySqlCommand cmd3 = new MySqlCommand("SELECT ItemID FROM Item WHERE ItemDescription = '" + row.Cells[0].Value.ToString() + "';", cnn);
                        String itemID = cmd3.ExecuteScalar().ToString();
                        MySqlCommand cmd2 = new MySqlCommand("INSERT INTO BPReleaseLines (ReleaseNo, ItemID, Quantity) " +
                            "VALUES('" + ReleaseNo + "' , '" + itemID + "', '" + Quantity + "');", cnn);
                        cmd2.ExecuteNonQuery();
                    }
                    else
                    {
                        break;
                    }

                }

                MessageBox.Show("Change successfully!");
        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

