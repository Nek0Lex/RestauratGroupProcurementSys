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
    public partial class confirmRequest : Form
    {
        public confirmRequest(string RestNo)
        {
            InitializeComponent();
            listView1.Items.Clear();
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none;allow zero datetime = true");
            cnn.Open();
            String query = "SELECT * from PurchaseRequest WHERE RestNo = '" + RestNo + "' AND Status !='PSS';";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataAdapter ada = new MySqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];

                ListViewItem listitem = new ListViewItem(dr["RequestNo"].ToString());
                listitem.SubItems.Add(dr["CreationDate"].ToString());
                listitem.SubItems.Add(dr["MappingDate"].ToString());
                listitem.SubItems.Add(dr["Quantity"].ToString());
                listitem.SubItems.Add(dr["DeliveryDate"].ToString());
                listitem.SubItems.Add(dr["Status"].ToString());
                listView1.Items.Add(listitem);
            }
            cnn.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
                String delete = "UPDATE PurchaseRequest SET Status = 'COM' where RequestNo = '" + deleteitem + "'; ";
                MySqlCommand cmd = new MySqlCommand(delete, cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Confirm success!");
                refreshFunction("R001");
            }
        }

        private void refreshFunction(string RestNo)
        {
            listView1.Items.Clear();
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none;allow zero datetime = true");
            cnn.Open();
            String query = "SELECT * from PurchaseRequest WHERE RestNo = '" + RestNo + "';";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataAdapter ada = new MySqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];

                ListViewItem listitem = new ListViewItem(dr["RequestNo"].ToString());
                listitem.SubItems.Add(dr["CreationDate"].ToString());
                listitem.SubItems.Add(dr["MappingDate"].ToString());
                listitem.SubItems.Add(dr["Quantity"].ToString());
                listitem.SubItems.Add(dr["DeliveryDate"].ToString());
                listitem.SubItems.Add(dr["Status"].ToString());
                listView1.Items.Add(listitem);
            }
            cnn.Close();
        }
    }
}
