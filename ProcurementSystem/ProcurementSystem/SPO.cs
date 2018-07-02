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
    public partial class SPO : Form
    {
        private TypeofAgreementMenu tam;
        public SPO(TypeofAgreementMenu tam)
        {
            InitializeComponent();
            this.tam = tam;
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
            cnn.Open();
            String query = "select * from SPO ORDER BY SPONo ASC;";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataAdapter ada = new MySqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];

                ListViewItem listitem = new ListViewItem(dr["SPONo"].ToString());
                listitem.SubItems.Add(dr["SupplierNo"].ToString());
                listitem.SubItems.Add(dr["CreationDate"].ToString());
                listitem.SubItems.Add(dr["EffectiveDate"].ToString());
                listitem.SubItems.Add(dr["BuyerName"].ToString());
                listitem.SubItems.Add(dr["BillingAddress"].ToString());
                listitem.SubItems.Add(dr["BuyerAccount"].ToString());
                listitem.SubItems.Add(dr["RestNo"].ToString());
                listitem.SubItems.Add(dr["ExpectedDeliveryDate"].ToString());
                listitem.SubItems.Add(dr["TermsAndCondition"].ToString());

                listView1.Items.Add(listitem);
            }
            dateTimeCompare();
        }
        public void dateTimeCompare()
        {
            DateTime now = DateTime.Now;
            DateTime effectiveDate;
            int datecompare;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                effectiveDate = DateTime.Parse(listView1.Items[i].SubItems[3].Text);
                datecompare = DateTime.Compare(now, effectiveDate);
                if (datecompare > 0)
                {
                    listView1.Items[i].BackColor = Color.Yellow;
                }
                else
                    continue;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            tam.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SPO_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SPOAdd SPOAdd = new SPOAdd();
            SPOAdd.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
            cnn.Open();
            String query = "select * from SPO ORDER BY SPONo ASC;";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataAdapter ada = new MySqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];

                ListViewItem listitem = new ListViewItem(dr["SPONo"].ToString());
                listitem.SubItems.Add(dr["SupplierNo"].ToString());
                listitem.SubItems.Add(dr["CreationDate"].ToString());
                listitem.SubItems.Add(dr["EffectiveDate"].ToString());
                listitem.SubItems.Add(dr["BuyerName"].ToString());
                listitem.SubItems.Add(dr["BillingAddress"].ToString());
                listitem.SubItems.Add(dr["BuyerAccount"].ToString());
                listitem.SubItems.Add(dr["RestNo"].ToString());
                listitem.SubItems.Add(dr["ExpectedDeliveryDate"].ToString());
                listitem.SubItems.Add(dr["TermsAndCondition"].ToString());

                listView1.Items.Add(listitem);
            }
            dateTimeCompare();
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
                SPOEdit spoEdit = new SPOEdit(this, listView1);
                spoEdit.ShowDialog();
            }
        }

        private void status_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nothing Selected", "ERROR");
                return;
            }
            else
            {
                SPOStatus spoStatus = new SPOStatus(this, listView1);
                spoStatus.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nothing Selected", "ERROR");
                return;
            }
            else
            {
                MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
                cnn.Open();
                String deleteitem = listView1.SelectedItems[0].SubItems[0].Text;
                String query = "DELETE from SPO where SPONo = '" + deleteitem + "'; ";
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                cmd.ExecuteNonQuery();
                query = "DELETE from SPOLines where SPONo = '" + deleteitem + "'; ";
                cmd = new MySqlCommand(query, cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Remove success!");
                refreshFunction();
            }
        }

        private void refreshFunction()
        {
            listView1.Items.Clear();
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
            cnn.Open();
            String query = "select * from SPO ORDER BY PPONo ASC;";
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
            dateTimeCompare();
        }
    }
}
