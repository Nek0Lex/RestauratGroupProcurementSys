using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProcurementSystem
{
    public partial class PPOStatus : Form
    {
        Form PPO;
        ListView lv;
        public PPOStatus(PPO ppo, ListView listView1)
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
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
            cnn.Open();
            MySqlDataAdapter getItem = new MySqlDataAdapter("SELECT * FROM PPOLines WHERE PPONo = '" + PPONo.Text + "'", cnn);
            DataTable dt = new DataTable();
            getItem.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                dataGridView1.Rows.Add(dr["ItemDescription"].ToString(), dr["Quantity"].ToString(), dr["UOM"].ToString(), dr["Price"].ToString());
            }
            SetReadonlyControls(groupBox1.Controls);
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetReadonlyControls(Control.ControlCollection controlCollection)
        {
            if (controlCollection == null)
            {
                return;
            }
            foreach (DateTimePicker d in controlCollection.OfType<DateTimePicker>())
            {
                d.Enabled = false;
            }
            foreach (ComboBox c in controlCollection.OfType<ComboBox>())
            {
                c.Enabled = false;
            }
            foreach (TextBoxBase c in controlCollection.OfType<TextBoxBase>())
            {
                c.ReadOnly = true;
                c.BorderStyle = BorderStyle.None;
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
