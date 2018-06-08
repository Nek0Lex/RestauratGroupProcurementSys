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
    public partial class BPAEdit : Form
    {
        Form f1;
        ListView lv;
        public BPAEdit(Form1 f1, ListView listView1)
        {
            this.f1 = f1;
            this.lv = listView1;
            InitializeComponent();
            BPANo.Text = lv.SelectedItems[0].Text;
            RequestNo.Text = lv.SelectedItems[0].SubItems[1].Text;
            PurchaseOrderRevision.Text = lv.SelectedItems[0].SubItems[2].Text;
            CreationDate.Text = lv.SelectedItems[0].SubItems[3].Text;
            Effective.Text = lv.SelectedItems[0].SubItems[4].Text;
            BuyerName.Text = lv.SelectedItems[0].SubItems[5].Text;
            BillingAddress.Text = lv.SelectedItems[0].SubItems[6].Text;
            Amount.Text = lv.SelectedItems[0].SubItems[7].Text;
            currency.Text = lv.SelectedItems[0].SubItems[8].Text;
            TAC.Text = lv.SelectedItems[0].SubItems[9].Text;
            SupplierNo.Text = lv.SelectedItems[0].SubItems[10].Text;
        }

        private void BPANo_TextChanged(object sender, EventArgs e)
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
            if (!string.IsNullOrWhiteSpace(billAddress) || !string.IsNullOrWhiteSpace(requestNo) || !string.IsNullOrWhiteSpace(supplierNo))
            {
                MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
                cnn.Open();
                String delete = "DELETE FROM BlanketPurchaseAgreement WHERE BPANo = '" + bpaNo + "'; ";
                MySqlCommand cmd = new MySqlCommand(delete, cnn);
                cmd.ExecuteNonQuery();
                String add = "INSERT INTO BlanketPurchaseAgreement (BPANo, RequestNo, PurchaseOrderRevision, CreationDate, EffectiveDate, BuyerName, BillingAddress, AmountAgreed, Currency, TermsAndCondition, SupplierNo)VALUES('" + bpaNo + "', '" + requestNo + "', '" + por + "', '" + creationDate + "', '" + effectiveDate + "', '" + buyerName + "', '" + billAddress + "', '" + amount + "', '" + Currency + "', '" + tac + "', '" + supplierNo + "'); ";
                MySqlCommand cmd2 = new MySqlCommand(add, cnn);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Change successful");
                this.Close();
            } else
            {
                MessageBox.Show("Cant be null of info you submit!", "ERROR");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
