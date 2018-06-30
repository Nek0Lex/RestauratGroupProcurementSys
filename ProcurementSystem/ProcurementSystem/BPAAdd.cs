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
    public partial class BPAAdd : Form
    {
        private PRMapping prmapping;
        public BPAAdd()
        {
            InitializeComponent();
        }
        public BPAAdd(PRMapping prmapping, string BPAno, string[] requestNoList, string supplierNo, string[] ItemList, string[] QtyList)
        {
            InitializeComponent();
            BPANo.Text = BPAno;
            this.prmapping = prmapping;
            foreach(string genRequestNo in requestNoList)
            {
                if (RequestNo.Text == "")
                    RequestNo.Text += genRequestNo;
                else
                    RequestNo.Text += ", " + genRequestNo;
            }
            SupplierNo.Text = supplierNo;
            for(int i=0; i<ItemList.Length; i++)
            {
                dataGridView1.Rows.Add(ItemList[i].ToString(), QtyList[i].ToString());
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            SetClearControls(groupBox1.Controls);
        }

        private void BPAAdd_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd2;
            MySqlCommand cmd3;
            try
            {
                String bpaNo = "BPA" + BPANo.Text;
                String requestNo = RequestNo.Text;
                String por = PurchaseOrderRevision.Text;
                String creationDate = CreationDate.Value.ToString("yyyy-MM-dd");
                String effectiveDate = Effective.Value.ToString("yyyy-MM-dd");
                String buyerName = BuyerName.Text;
                String billAddress = BillingAddress.Text;
                String supplierNo = "S" + SupplierNo.Text;
                String Currency = currency.Text;
                Double amount = Double.Parse(Amount.Text);
                String tac = TAC.Text;
                string itemID;
                if (!string.IsNullOrWhiteSpace(billAddress) || !string.IsNullOrWhiteSpace(requestNo) || !string.IsNullOrWhiteSpace(supplierNo))
                {
                    MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
                    cnn.Open();
                    String query = "INSERT INTO BlanketPurchaseAgreement (BPANo, RequestNo, PurchaseOrderRevision, CreationDate, EffectiveDate, BuyerName, BillingAddress, AmountAgreed, Currency, TermsAndCondition, SupplierNo)VALUES('" + bpaNo + "', '" + requestNo + "', '" + por + "', '" + creationDate + "', '" + effectiveDate + "', '" + buyerName + "', '" + billAddress + "', '" + amount + "', '" + Currency + "', '" + tac + "', '" + supplierNo + "'); ";
                    MySqlCommand cmd = new MySqlCommand(query, cnn);
                    MySqlDataAdapter ada = new MySqlDataAdapter(query, cnn);
                    cmd.ExecuteNonQuery();
                    foreach (DataGridViewRow row in dataGridView1.Rows) {
                        if (row.Cells[0].Value.ToString() != null)
                        {
                            cmd3 = new MySqlCommand("SELECT ItemID FROM Item WHERE ItemDescription = '" + row.Cells[0].Value.ToString() + "';", cnn);
                            itemID = cmd3.ExecuteScalar().ToString();
                            cmd2 = new MySqlCommand("INSERT INTO BPALines (BPANo, ItemID, PromisedQuantity, UOM, MoQ, Price, Amount) VALUES ('" + bpaNo + "', '" + itemID + "', '" + row.Cells[1].Value.ToString() + "', '" + row.Cells[2].Value.ToString() + "', '" + row.Cells[3].Value.ToString() + "', '" + row.Cells[4].Value.ToString() + "', '" + row.Cells[1].Value.ToString() + "');", cnn);
                            cmd2.ExecuteNonQuery();
                        }
                     }
                    MessageBox.Show("Add successful");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cant be null of info you submit!", "ERROR");
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Please input the amount OR other info!", "ERROR");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Check your Input Again!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void currency_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BPANo_TextChanged(object sender, EventArgs e)
        {

        }

        private void SupplierNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Amount_TextChanged(object sender, EventArgs e)
        {
            
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
    }
}
