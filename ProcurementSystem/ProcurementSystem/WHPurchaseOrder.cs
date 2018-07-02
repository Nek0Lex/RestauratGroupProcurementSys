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
        private Menu m;
        public WHPurchaseOrder(Menu m)
        {
            InitializeComponent();
            this.m = m;
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

            if (BPANoSelection.Text.Equals(""))
            {
                initListview();
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

        private void initListview()
        {
            String querypara = BPANoSelection.Text;
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
            cnn.Open();
            String query = "SELECT * from BPALines";
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
            BPANoSelection.Text = "";
            search.Text = "";
            dbtoListview();
            initListview();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            m.Show();
        }

        private void BPANoSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbtoListview();
        }

        private void search_TextChanged(object sender, EventArgs e)  
        {
            if (search.Text != "")
            {
                for (int i = listView1.Items.Count - 1; i >= 0; i--)
                {
                    var item = listView1.Items[i];
                    if (item.Text.ToLower().Contains(search.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                    else
                    {
                        listView1.Items.Remove(item);
                    }
                }
                if (listView1.SelectedItems.Count == 1)
                {
                    listView1.Focus();
                }
            }
        }
    }
}
