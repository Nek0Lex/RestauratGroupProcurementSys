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
    public partial class PPO : Form
    {
        private TypeofAgreementMenu tam;
        public PPO(TypeofAgreementMenu tam)
        {
            InitializeComponent();
            this.tam = tam;
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
            cnn.Open();
            String query = "select * from PPO ORDER BY PPONo ASC;";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataAdapter ada = new MySqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];

                ListViewItem listitem = new ListViewItem(dr["PPONo"].ToString());
                listitem.SubItems.Add(dr["SupplierNo"].ToString());
                listitem.SubItems.Add(dr["PurchaseOrderRevision"].ToString());
                listitem.SubItems.Add(dr["CreationDate"].ToString());
                listitem.SubItems.Add(dr["EffectiveDate"].ToString());
                listitem.SubItems.Add(dr["BuyerName"].ToString());
                listitem.SubItems.Add(dr["BillingAddress"].ToString());
                listitem.SubItems.Add(dr["BuyerAccount"].ToString());
                listitem.SubItems.Add(dr["SRNo"].ToString());
                listitem.SubItems.Add(dr["Amount"].ToString());
                listitem.SubItems.Add(dr["Currency"].ToString());
                listitem.SubItems.Add(dr["TermsAndCondition"].ToString());

                listView1.Items.Add(listitem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            tam.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PPOAdd PPOAdd = new PPOAdd();
            PPOAdd.ShowDialog();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
            cnn.Open();
            String query = "select * from PPO ORDER BY PPONo ASC;";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataAdapter ada = new MySqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];

                ListViewItem listitem = new ListViewItem(dr["PPONo"].ToString());
                listitem.SubItems.Add(dr["SupplierNo"].ToString());
                listitem.SubItems.Add(dr["PurchaseOrderRevision"].ToString());
                listitem.SubItems.Add(dr["CreationDate"].ToString());
                listitem.SubItems.Add(dr["EffectiveDate"].ToString());
                listitem.SubItems.Add(dr["BuyerName"].ToString());
                listitem.SubItems.Add(dr["BillingAddress"].ToString());
                listitem.SubItems.Add(dr["BuyerAccount"].ToString());
                listitem.SubItems.Add(dr["SRNo"].ToString());
                listitem.SubItems.Add(dr["Amount"].ToString());
                listitem.SubItems.Add(dr["Currency"].ToString());
                listitem.SubItems.Add(dr["TermsAndCondition"].ToString());

                listView1.Items.Add(listitem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nothing Selected", "ERROR");
                return;
            }
            else
            {
                PPOEdit ppoEdit = new PPOEdit(this, listView1);
                ppoEdit.ShowDialog();
            }
        }
    }
}
