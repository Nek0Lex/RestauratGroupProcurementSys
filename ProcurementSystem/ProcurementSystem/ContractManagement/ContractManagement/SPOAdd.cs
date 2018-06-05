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
    public partial class SPOAdd : Form
    {
        public SPOAdd()
        {
            InitializeComponent();
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
            String spoNo = SPONo.Text;
            String supplierNo = SupplierNo.Text;
            String creationDate = CreationDate.Value.ToString("yyyy-MM-dd");
            String effectiveDate = EffectiveDate.Value.ToString("yyyy-MM-dd");
            String edd = ExpectedDeliveryDate.Value.ToString("yyyy-MM-dd");
            String billAddress = BillingAddress.Text;
            int buyerAccount = int.Parse(BuyerAccount.Text);
            String buyerName = BuyerName.Text;
            String restNo = RestNo.Text;
            String tac = TAC.Text;


            if (string.IsNullOrWhiteSpace(spoNo) || string.IsNullOrWhiteSpace(supplierNo) || string.IsNullOrWhiteSpace(restNo) || string.IsNullOrWhiteSpace(billAddress))
            {
                MessageBox.Show("You must input all fields", "Check Your Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
                cnn.Open();
                String query = "INSERT INTO SPO (SPONo, SupplierNo, CreationDate, EffectiveDate, BuyerName, BillingAddress, BuyerAccount, RestNo, ExpectedDeliveryDate, TermsAndCondition)VALUES('" + spoNo + "', '" + supplierNo + "', '" + creationDate + "', '" + effectiveDate + "', '" + buyerName + "', '" + billAddress + "', '" + buyerAccount + "', '" + restNo + "', '" + edd + "', '" + tac + "'); ";
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                MySqlDataAdapter ada = new MySqlDataAdapter(query, cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add successful");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


    }
}
