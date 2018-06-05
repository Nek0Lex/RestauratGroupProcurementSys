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
    public partial class BPAAdd : Form
    {
        public BPAAdd()
        {
            InitializeComponent();
            

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

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Refresh();
        }

        private void BPAAdd_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String bpaNo = BPANo.Text;
            String requestNo = RequestNo.Text;
            String por = PurchaseOrderRevision.Text;
            String creationDate = CreationDate.Value.ToString("yyyy-MM-dd");
            String effectiveDate = Effective.Value.ToString("yyyy-MM-dd");
            String buyerName = BuyerName.Text;
            String billAddress = BillingAddress.Text;
            String supplierNo = SupplierNo.Text;
            String Currency = currency.Text;
            Double amount = Double.Parse(Amount.Text);
            String tac = TAC.Text;
            try
            {
                MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
                cnn.Open();
                //String query = "INSERT INTO BlanketPurchaseAgreement (BPANo, RequestNo, PurchaseOrderRevision, CreationDate, EffectiveDate, BuyerName, BillingAddress, AmountAgreed, Currency, TermsAndCondition, SupplierNo)VALUES(bpaNo, requestNo, por, creationDate, effectiveDate, buyerName, billingAddress, amount, Currency, tac, supplierNo); ";
                String query = "INSERT INTO BlanketPurchaseAgreement (BPANo, RequestNo, PurchaseOrderRevision, CreationDate, EffectiveDate, BuyerName, BillingAddress, AmountAgreed, Currency, TermsAndCondition, SupplierNo)VALUES("+bpaNo+","+ requestNo+","+ por+","+ creationDate+","+ effectiveDate+","+ buyerName+","+ billAddress+","+ amount+","+ Currency+","+ tac+","+ supplierNo+"); ";
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                //MySqlDataAdapter ada = new MySqlDataAdapter(query, cnn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void currency_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
