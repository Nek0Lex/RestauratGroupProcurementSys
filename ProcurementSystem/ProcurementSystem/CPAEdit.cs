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
    public partial class CPAEdit : Form
    {
        Form CPA;
        ListView lv;
        public CPAEdit(CPA CPA, ListView listView1)
        {
            this.CPA = CPA;
            this.lv = listView1;
            InitializeComponent();
            ContractNo.Text = lv.SelectedItems[0].Text;
            SupplierNo.Text = lv.SelectedItems[0].SubItems[1].Text;
            CreationDate.Text = lv.SelectedItems[0].SubItems[2].Text;
            EffectiveDate.Text = lv.SelectedItems[0].SubItems[3].Text;
            BuyerName.Text = lv.SelectedItems[0].SubItems[4].Text;
            BillingAddress.Text = lv.SelectedItems[0].SubItems[5].Text;
            TAC.Text = lv.SelectedItems[0].SubItems[6].Text;
            ItemID.Text = lv.SelectedItems[0].SubItems[7].Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            String contractNo = ContractNo.Text;
            String supplierNo = SupplierNo.Text;
            String creationDate = CreationDate.Value.ToString("yyyy-MM-dd");
            String effectiveDate = EffectiveDate.Value.ToString("yyyy-MM-dd");
            String buyerName = BuyerName.Text;
            String billAddress = BillingAddress.Text;
            String itemID = ItemID.Text;
            String tac = TAC.Text;

            MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
            cnn.Open();
            String delete = "DELETE FROM CPA WHERE ContractNo = '" + contractNo + "'; ";
            MySqlCommand cmd = new MySqlCommand(delete, cnn);
            cmd.ExecuteNonQuery();
            String add = "INSERT INTO CPA (ContractNo, SupplierNo, CreationDate, EffectiveDate, BuyerName, BillingAddress, TermsAndCondition, ItemID)VALUES('" + contractNo + "', '" + supplierNo + "', '" + creationDate + "', '" + effectiveDate + "', '" + buyerName + "', '" + billAddress + "', '" + tac + "', '" + itemID + "'); ";
            MySqlCommand cmd2 = new MySqlCommand(add, cnn);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Change successful");
            this.Close();
        }
    }
}
