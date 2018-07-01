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
            String query = "INSERT INTO BlanketPurchaseAgreement (ReleaseNo, RequestNo, BPANo, CreationDate, RestNo, DeliveryDate, Account, ActualAmount, ActualQuantity)" +
                "VALUES ('" + ReleaseNo + "', '" + RequestNo + ", '" + bpaNo + "', '" + CreationDate + "', '" + restNo + "', '" + DeliveryDate + "', '" + Account + "', '" + Amount + "', '" + Quantity + "');";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            cmd.ExecuteNonQuery();

            

        }
    }
}
