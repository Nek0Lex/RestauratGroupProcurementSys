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
    public partial class WHPurchaseOrder : Form
    {
        public WHPurchaseOrder()
        {
            InitializeComponent();
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
            cnn.Open();
            String query = "select * from BlanketPurchaseAgreement;";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                String BPAno = dr.GetString("BPANo");
                BPANoSelection.Items.Add(BPAno);
            }

            dbtoListview();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dbtoListview()
        {
            String querypara = BPANoSelection.Text;
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
            cnn.Open();
            String query = "select BPANo = '" + querypara + "' from BPALines ORDER BY BPANo ASC ;";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataAdapter ada = new MySqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];

                ListViewItem listitem = new ListViewItem(dr["BPANo"].ToString());
                listitem.SubItems.Add(dr["ItemID"].ToString());
                listitem.SubItems.Add(dr["PromisedQuantity"].ToString());
                listitem.SubItems.Add(dr["UOM"].ToString());
                listitem.SubItems.Add(dr["MoQ"].ToString());
                listitem.SubItems.Add(dr["Price"].ToString());
                listitem.SubItems.Add(dr["Amount"].ToString());
                listitem.SubItems.Add(dr["Category"].ToString());
                listitem.SubItems.Add(dr["Reference"].ToString());

                listView1.Items.Add(listitem);
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            dbtoListview();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
