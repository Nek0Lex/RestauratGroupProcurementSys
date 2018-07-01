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
                String CreationDate = creationDate.Value.ToString("yyyy-MM-dd");
                String DeliveryDate = deliveryDate.Value.ToString("yyyy-MM-dd");
                String Restno = restNo.Text;
                String ac = account.Text;
                String Amount = actualAmount.Text;
                String Quantity = quantity.Text;

                MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
                cnn.Open();
                String query = "UPDATE BlanketPurchaseRelease " +
                    "SET CreationDate = '"+CreationDate+"'," +
                        "DeliveryDate = '"+DeliveryDate+"', " +
                        "RestNo = '"+RestNo+"', " +
                        "Account = '"+ac+"', " +
                        "ActualAmount ='"+Amount+"', " +
                        "ActualQuantity = '"+Quantity+"'" +
                    "WHERE ReleaseNo = '"+ReleaseNo+"'; ";
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                cmd.ExecuteNonQuery();

                //trans itemname to itemid
                foreach (DataGridViewRow row in dataGridView1.Rows)
                { 
                    String item = row.Cells["Item Name"].Value.ToString();
                }
                
                

            }
;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
