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
    public partial class BlanketPurchaseRelease : Form
    {
        public BlanketPurchaseRelease()
        {
            InitializeComponent();
        }
        public BlanketPurchaseRelease(string getBPANo, string getReleaseNo, string getRestNo, string ItemName, string ItemQty, string getRequestNo)
        {
            InitializeComponent();
            BPANo.Text = getBPANo;
            releaseNo.Text = getReleaseNo;
            restNo.Text = getRestNo;
            requestNo.Text = getRequestNo;
            dataGridView1.Rows.Add(ItemName);
            quantity.Text = ItemQty;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void requestNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void actualAmount_TextChanged(object sender, EventArgs e)
        {

        }


        private void confirm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", null, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                String bpaNo = BPANo.Text;
                String ReleaseNo = releaseNo.Text;
                String RestNo = restNo.Text;
                String RequestNo = requestNo.Text;
                String CreationDate = creationDate.Value.ToString("yyyy-MM-dd");
                String DeliveryDate = deliveryDate.Value.ToString("yyyy-MM-dd");
                String ac = account.Text;
                String Amount = actualAmount.Text;
                String Quantity = quantity.Text;
                String result;

                MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
                cnn.Open();
                /*
                String query = "UPDATE BlanketPurchaseRelease " +
                    "SET CreationDate = '"+CreationDate+"'," +
                        "DeliveryDate = '"+DeliveryDate+"', " +
                        "RestNo = '"+RestNo+"', " +
                        "Account = '"+ac+"', " +
                        "ActualAmount ='"+Amount+"', " +
                        "ActualQuantity = '"+Quantity+"'" +
                    "WHERE ReleaseNo = '"+ReleaseNo+"'; ";
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                cmd.ExecuteNonQuery();*/
                String queryI = "INSERT INTO BlanketPurchaseRelease (ReleaseNo, RequestNo, BPANo, CreationDate, RestNo, DeliveryDate, Account, ActualAmount, ActualQuantity)" +
                    "VALUES('" + ReleaseNo + "', '" + RequestNo + "', '" + bpaNo + "', '" + CreationDate + "', '" + RestNo + "', '" + DeliveryDate + "', '" + ac +"', '" + Amount + "', '" + Quantity + "');";
                MySqlCommand cmd = new MySqlCommand(queryI, cnn);
                cmd.ExecuteNonQuery();

                //trans itemname to itemid
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        MySqlCommand cmd3 = new MySqlCommand("SELECT ItemID FROM Item WHERE ItemDescription = '" + row.Cells[0].Value.ToString() + "';", cnn);
                        String itemID = cmd3.ExecuteScalar().ToString();
                        MySqlCommand cmd2 = new MySqlCommand("INSERT INTO BPReleaseLines (ReleaseNo, ItemID, Quantity) " +
                            "VALUES('" + ReleaseNo + "' , '" + itemID + "', '" + Quantity + "');", cnn);
                        cmd2.ExecuteNonQuery();
                        MySqlCommand cmd4 = new MySqlCommand("SELECT VItemID FROM VItem WHERE ItemID = '" + itemID + "';", cnn);
                        String VItemID = cmd4.ExecuteScalar().ToString();
                        MySqlCommand changeStatus = new MySqlCommand("UPDATE PurchaseRequest " +
                            "SET Status = 'BPA' " +
                            "WHERE RequestNo = '" + RequestNo + "' AND VItemID = '" + VItemID + "' ;", cnn);
                        changeStatus.ExecuteNonQuery();
						MySqlCommand updateBPAQty = new MySqlCommand("UPDATE BPALines SET PromisedQuantity = (PromisedQuantity-" + Quantity + ") WHERE BPANo = '" + bpaNo + "';", cnn);
						updateBPAQty.ExecuteNonQuery();
					}
                    else 
                    {
                        break;
                    }

                }



                MessageBox.Show("Change successfully!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void forwardToAdd_Click(object sender, EventArgs e)
        {
            BlanketPurchaseReleaseAdd blanketPurchaseReleaseAdd = new BlanketPurchaseReleaseAdd();
            blanketPurchaseReleaseAdd.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
