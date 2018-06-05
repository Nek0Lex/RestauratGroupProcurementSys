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

namespace ContractManagement
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
            String ppoNo = PPONo.Text;
            String supplierNo = SupplierNo.Text;
            String creationDate = CreationDate.Value.ToString("yyyy-MM-dd");
            String effectiveDate = EffectiveDate.Value.ToString("yyyy-MM-dd");
            String billAddress = BillingAddress.Text;
            String purchaseOrderRevision = PurchaseOrderRevision.Text;
            int buyerAccount = int.Parse(BuyerAccount.Text);
            String buyerName = BuyerName.Text;
            String srNo = SRNo.Text;
            int amount = int.Parse(Amount.Text);
            String currency = Currency.Text;
            String tac = TAC.Text;


            if (string.IsNullOrWhiteSpace(ppoNo) || string.IsNullOrWhiteSpace(supplierNo) || string.IsNullOrWhiteSpace(currency) || string.IsNullOrWhiteSpace(billAddress))
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
    }
}
