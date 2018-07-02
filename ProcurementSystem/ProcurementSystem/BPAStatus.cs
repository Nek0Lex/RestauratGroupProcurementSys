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
    public partial class BPAStatus : Form
    {
        Form f1;
        ListView lv;
        public BPAStatus(Form1 BPA, ListView listView1)
        {
            this.f1 = BPA;
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
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
            cnn.Open();
            MySqlDataAdapter getItem = new MySqlDataAdapter("SELECT * FROM BPALines WHERE BPANo = '"+BPANo.Text+"'", cnn);
            DataTable dt = new DataTable();
            getItem.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                MySqlCommand getItemName = new MySqlCommand("SELECT ItemDescription FROM Item where ItemID = '" + dr["ItemID"].ToString() + "'", cnn);
                string itemName = getItemName.ExecuteScalar().ToString();
                dataGridView1.Rows.Add(itemName, dr["PromisedQuantity"].ToString(), dr["UOM"].ToString(), dr["MoQ"].ToString(), dr["Price"].ToString());
            }
            SetReadonlyControls(groupBox1.Controls);
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
