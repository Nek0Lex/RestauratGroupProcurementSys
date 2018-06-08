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
    public partial class PPOAdd : Form
    {
        //MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");

        public PPOAdd()
        {
            InitializeComponent();
        }

        private void PPOAdd_Load(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String ppoNo = "PPO" + PPONo.Text;
            String supplierNo = "S" + SupplierNo.Text;
            String creationDate = CreationDate.Value.ToString("yyyy-MM-dd");
            String effectiveDate = EffectiveDate.Value.ToString("yyyy-MM-dd");
            String billAddress = BillingAddress.Text;
            String purchaseOrderRevision = PurchaseOrderRevision.Text;
            int buyerAccount = int.Parse(BuyerAccount.Text);
            String buyerName = BuyerName.Text;
            String srNo = "SR" + SRNo.Text;
            int amount = int.Parse(Amount.Text);
            String currency = Currency.Text;
            String tac = TAC.Text;


            if (!string.IsNullOrWhiteSpace(ppoNo) || !string.IsNullOrWhiteSpace(supplierNo) || !string.IsNullOrWhiteSpace(currency) || !string.IsNullOrWhiteSpace(billAddress))
            {
                MessageBox.Show("You must input all fields", "Check Your Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
                cnn.Open();
                String query = "INSERT INTO PPO (PPONo, SupplierNo, PurchaseOrderRevision, CreationDate, EffectiveDate, BuyerName, BillingAddress, BuyerAccount, SRNo, Amount, Currency, TermsAndCondition)VALUES('" + ppoNo + "', '" + supplierNo + "', '" + purchaseOrderRevision + "', '" + creationDate + "', '" + effectiveDate + "', '" + buyerName + "', '" + billAddress + "', '" + buyerAccount + "', '" + srNo + "', " + amount + ", '" + currency + "', '" + tac + "'); ";
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                MySqlDataAdapter ada = new MySqlDataAdapter(query, cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add successful");
                this.Close();
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
    }
}
