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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
            cnn.Open();
            String query = "select * from BlanketPurchaseAgreement ORDER BY BPANo ASC;";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataAdapter ada = new MySqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];

                ListViewItem listitem = new ListViewItem(dr["BPANo"].ToString());
                listitem.SubItems.Add(dr["RequestNo"].ToString());
                listitem.SubItems.Add(dr["PurchaseOrderRevision"].ToString());
                listitem.SubItems.Add(dr["CreationDate"].ToString());
                listitem.SubItems.Add(dr["EffectiveDate"].ToString());
                listitem.SubItems.Add(dr["BuyerName"].ToString());
                listitem.SubItems.Add(dr["BillingAddress"].ToString());
                listitem.SubItems.Add(dr["AmountAgreed"].ToString());
                listitem.SubItems.Add(dr["Currency"].ToString());
                listitem.SubItems.Add(dr["TermsAndCondition"].ToString());
                listitem.SubItems.Add(dr["SupplierNo"].ToString());

                listView1.Items.Add(listitem);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BPAAdd BPAAdd = new BPAAdd();
            BPAAdd.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TypeofAgreementMenu menu = new TypeofAgreementMenu();
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {   
            
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
            cnn.Open();
            String query = "select * from BlanketPurchaseAgreement ORDER BY BPANo ASC;";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataAdapter ada = new MySqlDataAdapter(query, cnn);

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
                BPAEdit bPAEdit = new BPAEdit(this, listView1);
                bPAEdit.ShowDialog();
            }

        }

        public string bpaNo
        {
           get { return listView1.SelectedItems[0].Text; }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
            cnn.Open();
            String query = "select * from BlanketPurchaseAgreement ORDER BY BPANo ASC;";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataAdapter ada = new MySqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];

                ListViewItem listitem = new ListViewItem(dr["BPANo"].ToString());
                listitem.SubItems.Add(dr["RequestNo"].ToString());
                listitem.SubItems.Add(dr["PurchaseOrderRevision"].ToString());
                listitem.SubItems.Add(dr["CreationDate"].ToString());
                listitem.SubItems.Add(dr["EffectiveDate"].ToString());
                listitem.SubItems.Add(dr["BuyerName"].ToString());
                listitem.SubItems.Add(dr["BillingAddress"].ToString());
                listitem.SubItems.Add(dr["AmountAgreed"].ToString());
                listitem.SubItems.Add(dr["Currency"].ToString());
                listitem.SubItems.Add(dr["TermsAndCondition"].ToString());
                listitem.SubItems.Add(dr["SupplierNo"].ToString());

                listView1.Items.Add(listitem);
            }
        }
    }
}
