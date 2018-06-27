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
    public partial class PPOEdit : Form
    {
        Form PPO;
        ListView lv;
        public PPOEdit(PPO ppo, ListView listView1)
        {
            this.PPO = ppo;
            this.lv = listView1;
            InitializeComponent();
            PPONo.Text = lv.SelectedItems[0].Text;
            SupplierNo.Text = lv.SelectedItems[0].SubItems[1].Text;
            PurchaseOrderRevision.Text = lv.SelectedItems[0].SubItems[2].Text;
            CreationDate.Text = lv.SelectedItems[0].SubItems[3].Text;
            EffectiveDate.Text = lv.SelectedItems[0].SubItems[4].Text;
            BuyerName.Text = lv.SelectedItems[0].SubItems[5].Text;
            BillingAddress.Text = lv.SelectedItems[0].SubItems[6].Text;
            BuyerAccount.Text = lv.SelectedItems[0].SubItems[7].Text;
            SRNo.Text = lv.SelectedItems[0].SubItems[8].Text;
            Amount.Text = lv.SelectedItems[0].SubItems[9].Text;
            Currency.Text = lv.SelectedItems[0].SubItems[10].Text;
            TAC.Text = lv.SelectedItems[0].SubItems[11].Text;

        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
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

                if (!string.IsNullOrWhiteSpace(billAddress) || !string.IsNullOrWhiteSpace(ppoNo) || !string.IsNullOrWhiteSpace(supplierNo))
                {
                    MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
                    cnn.Open();
                    String delete = "DELETE FROM PPO WHERE ppoNo = '" + ppoNo + "'; ";
                    MySqlCommand cmd = new MySqlCommand(delete, cnn);
                    cmd.ExecuteNonQuery();
                    String add = "INSERT INTO PPO (PPONo, SupplierNo, PurchaseOrderRevision, CreationDate, EffectiveDate, BuyerName, BillingAddress, BuyerAccount, SRNo, Amount, Currency, TermsAndCondition)VALUES('" + ppoNo + "', '" + supplierNo + "', '" + purchaseOrderRevision + "', '" + creationDate + "', '" + effectiveDate + "', '" + buyerName + "', '" + billAddress + "', '" + buyerAccount + "', '" + srNo + "', " + amount + ", '" + currency + "', '" + tac + "'); ";
                    MySqlCommand cmd2 = new MySqlCommand(add, cnn);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Change successful");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You must input all fields", "Check Your Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Recheck your input!");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Currency_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
