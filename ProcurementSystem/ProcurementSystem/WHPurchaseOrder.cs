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

            if (!String.IsNullOrWhiteSpace(BPANoSelection.Text))
            {
                dbtoListview();
            }
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
            listView1.Items.Clear();
            String querypara = BPANoSelection.Text;
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
            cnn.Open();
            String query = "SELECT * from BPALines WHERE BPANo = '" + querypara + "';";
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
            cnn.Close();
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

        private void BPANoSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbtoListview();
        }

        private void search_TextChanged(object sender, EventArgs e)  //wait to improve
        {
            if (search.Text != "")
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.Text.ToLower().Contains(search.Text.ToLower()))
                    {
                        item.Selected = true;
                    }
                    else
                    {
                        listView1.Items.Remove(item);
                    }
                }
            }
        }
    }
}
