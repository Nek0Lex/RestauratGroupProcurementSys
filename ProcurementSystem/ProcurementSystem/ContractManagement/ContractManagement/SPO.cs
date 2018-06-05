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
    public partial class SPO : Form
    {
        public SPO()
        {
            InitializeComponent();
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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TypeofAgreementMenu menu = new TypeofAgreementMenu();
            this.Close();
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
        }
    }
}
