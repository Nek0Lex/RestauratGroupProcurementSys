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
    public partial class SPOEdit : Form
    {
        Form spo;
        ListView lv;
        public SPOEdit(SPO spo, ListView listView1)
        {
            this.spo = spo;
            this.lv = listView1;
            InitializeComponent();
            SPONo.Text = lv.SelectedItems[0].Text;
            SupplierNo.Text = lv.SelectedItems[0].SubItems[1].Text;
            CreationDate.Text = lv.SelectedItems[0].SubItems[2].Text;
            EffectiveDate.Text = lv.SelectedItems[0].SubItems[3].Text;
            BuyerName.Text = lv.SelectedItems[0].SubItems[4].Text;
            BillingAddress.Text = lv.SelectedItems[0].SubItems[5].Text;
            BuyerAccount.Text = lv.SelectedItems[0].SubItems[6].Text;
            RestNo.Text = lv.SelectedItems[0].SubItems[7].Text;
            ExpectedDeliveryDate.Text = lv.SelectedItems[0].SubItems[8].Text;
            TAC.Text = lv.SelectedItems[0].SubItems[9].Text;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submit_Click(object sender, EventArgs e)
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


            if (!string.IsNullOrWhiteSpace(spoNo) || !string.IsNullOrWhiteSpace(supplierNo) || string.IsNullOrWhiteSpace(restNo) || !string.IsNullOrWhiteSpace(billAddress))
            {
                MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
                cnn.Open();
                String delete = "DELETE FROM SPO WHERE SPONo = '" + spoNo + "'; ";
                MySqlCommand cmd = new MySqlCommand(delete, cnn);
                cmd.ExecuteNonQuery();
                String add = "INSERT INTO SPO (SPONo, SupplierNo, CreationDate, EffectiveDate, BuyerName, BillingAddress, BuyerAccount, RestNo, ExpectedDeliveryDate, TermsAndCondition)VALUES('" + spoNo + "', '" + supplierNo + "', '" + creationDate + "', '" + effectiveDate + "', '" + buyerName + "', '" + billAddress + "', '" + buyerAccount + "', '" + restNo + "', '" + edd + "', '" + tac + "'); ";
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
    }
}
