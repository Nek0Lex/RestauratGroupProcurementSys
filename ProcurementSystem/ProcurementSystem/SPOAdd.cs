using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProcurementSystem
{
    public partial class SPOAdd : Form
    {
        String requestNo;
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
        public SPOAdd()
        {
            InitializeComponent();
            cnn.Open();
        }
        public SPOAdd(string getSPONo, string getSupplierNo, string getRestNo, string itemName, string itemQty, string RequestNo)
        {
            InitializeComponent();
            cnn.Open();
            SPONo.Text = getSPONo;
            SupplierNo.Text = getSupplierNo;
            RestNo.Text = getRestNo;
            dataGridView1.Rows.Add(itemName, itemQty);
            requestNo = RequestNo;
        }

        private void SPUAdd_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (BillingAddress.Text == "" || BuyerAccount.Text == "" || BuyerName.Text == "" || TAC.Text == "" || dataGridView1.Rows[0].Cells[2].Value == null || dataGridView1.Rows[0].Cells[3].Value == null)
            {
                MessageBox.Show("Check Your Input!");
            }
            else
            {
                try
                {
                    DateTime today = DateTime.Today;
                    String spoNo = "SPO" + SPONo.Text;
                    String supplierNo = "S" + SupplierNo.Text;
                    String creationDate = CreationDate.Value.ToString("yyyy-MM-dd");
                    String effectiveDate = EffectiveDate.Value.ToString("yyyy-MM-dd");
                    String edd = ExpectedDeliveryDate.Value.ToString("yyyy-MM-dd");
                    String billAddress = BillingAddress.Text;
                    int buyerAccount = int.Parse(BuyerAccount.Text);
                    String buyerName = BuyerName.Text;
                    String restNo = "R" + RestNo.Text;
                    String tac = TAC.Text;


                    if (string.IsNullOrWhiteSpace(spoNo) || string.IsNullOrWhiteSpace(supplierNo) || string.IsNullOrWhiteSpace(restNo) || string.IsNullOrWhiteSpace(billAddress))
                    {
                        MessageBox.Show("You must input all fields", "Check Your Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        String query = "INSERT INTO SPO (SPONo, SupplierNo, CreationDate, EffectiveDate, BuyerName, BillingAddress, BuyerAccount, RestNo, ExpectedDeliveryDate, TermsAndCondition)VALUES('" + spoNo + "', '" + supplierNo + "', '" + creationDate + "', '" + effectiveDate + "', '" + buyerName + "', '" + billAddress + "', '" + buyerAccount + "', '" + restNo + "', '" + edd + "', '" + tac + "'); ";
                        MySqlCommand cmd = new MySqlCommand(query, cnn);
                        MySqlDataAdapter ada = new MySqlDataAdapter(query, cnn);
                        cmd.ExecuteNonQuery();
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells[0].Value != null)
                            {
                                MySqlCommand cmd3 = new MySqlCommand("SELECT SupplierItemID FROM Item i,SupplierItem si  WHERE i.ItemID = si.ItemID AND ItemDescription = '" + row.Cells[0].Value.ToString() + "';", cnn);
                                string itemID = cmd3.ExecuteScalar().ToString();
                                double amount = int.Parse(row.Cells[1].Value.ToString()) * int.Parse(row.Cells[3].Value.ToString());
                                if (amount != 0 && itemID != null)
                                {
                                    MySqlCommand cmd2 = new MySqlCommand("INSERT INTO SPOLines (SPONo, SupplierItemID, Quantity, UOM, Price, Amount) VALUES ('" + spoNo + "', '" + itemID + "', '" + row.Cells[1].Value.ToString() + "', '" + row.Cells[2].Value.ToString() + "', '" + row.Cells[3].Value.ToString() + "', '" + amount + "');", cnn);
                                    cmd2.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                break;
                            }
                        }

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells[0].Value != null)
                            {
                                MySqlCommand cmd3 = new MySqlCommand("SELECT ItemID FROM Item WHERE ItemDescription = '" + row.Cells[0].Value.ToString() + "';", cnn);
                                String itemID = cmd3.ExecuteScalar().ToString();
                                MySqlCommand cmd4 = new MySqlCommand("SELECT VItemID FROM VItem WHERE ItemID = '" + itemID + "';", cnn);
                                String VItemID = cmd4.ExecuteScalar().ToString();
                                MySqlCommand changeStatus = new MySqlCommand("UPDATE PurchaseRequest " +
                                    "SET Status = 'SPO', MappingDate ='" + today.ToString("yyyy-MM-dd") +
                                    "' WHERE RequestNo = '" + requestNo + "' AND VItemID = '" + VItemID + "' ;", cnn);
                                changeStatus.ExecuteNonQuery();
                            }
                            else
                            {
                                break;
                            }

                        }


                        MessageBox.Show("Add successful");
                        this.Close();
                    }
                }
                catch (Exception exx)
                {
                    MessageBox.Show("Recheck your input!");
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            SetClearControls(groupBox1.Controls);
        }

        private void SetClearControls(Control.ControlCollection controlCollection)
        {
            if (controlCollection == null)
            {
                return;
            }
            foreach (DateTimePicker d in controlCollection.OfType<DateTimePicker>())
            {
                continue;
            }
            foreach (ComboBox c in controlCollection.OfType<ComboBox>())
            {
                c.Text = "";
            }
            foreach (TextBoxBase c in controlCollection.OfType<TextBoxBase>())
            {
                if (!c.ReadOnly)
                {
                    c.Text = "";
                }
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
