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
    public partial class CPAAdd : Form
    {
        public CPAAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String contractNo = "CPA" + ContractNo.Text;
                String supplierNo = "S" + SupplierNo.Text;
                String creationDate = CreationDate.Value.ToString("yyyy-MM-dd");
                String effectiveDate = EffectiveDate.Value.ToString("yyyy-MM-dd");
                String buyerName = BuyerName.Text;
                String billAddress = BillingAddress.Text;
                String itemID = ItemID.Text;
                String tac = TAC.Text;

                if (string.IsNullOrWhiteSpace(billAddress) || string.IsNullOrWhiteSpace(contractNo) || string.IsNullOrWhiteSpace(supplierNo))
                {
                    MessageBox.Show("You must input all fields", "Check Your Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
                    cnn.Open();
                    String query = "INSERT INTO CPA (ContractNo, SupplierNo, CreationDate, EffectiveDate, BuyerName, BillingAddress, TermsAndCondition, ItemID)VALUES('" + contractNo + "', '" + supplierNo + "', '" + creationDate + "', '" + effectiveDate + "', '" + buyerName + "', '" + billAddress + "', '" + tac + "', '" + itemID + "'); ";
                    MySqlCommand cmd = new MySqlCommand(query, cnn);
                    MySqlDataAdapter ada = new MySqlDataAdapter(query, cnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Add successful");
                    this.Close();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Recheck your input!");
            }
        }

        private void ContractNo_TextChanged(object sender, EventArgs e)
        {

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
