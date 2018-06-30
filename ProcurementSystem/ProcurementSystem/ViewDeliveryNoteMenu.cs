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
    public partial class ViewDeliveryNoteMenu : Form
    {
        private String restNo;
        private Menu m;
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
        public ViewDeliveryNoteMenu(Menu m, String restNo)
        {
            InitializeComponent();
            this.m = m;
            this.restNo = restNo;
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RMConfirmDN vDN = new RMConfirmDN(this, listViewDN.SelectedItems[0].SubItems[0].Text, listViewDN.SelectedItems[0].SubItems[4].Text);
            vDN.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewDeliveryNoteMenu_Load(object sender, EventArgs e)
        {

        }

        public void loadData()
        {
            listViewDN.Items.Clear();
            cnn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("select Distinct DeliveryID, dn.RequestNo, DesID, ArriveDate, dn.Status from DeliveryNote dn, PurchaseRequest pr Where dn.RequestNo=pr.RequestNo and pr.RestNo='"+restNo+"';", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem listitem = new ListViewItem(dr["DeliveryID"].ToString());
                listitem.SubItems.Add(dr["RequestNo"].ToString());
                listitem.SubItems.Add(dr["DesID"].ToString());
                listitem.SubItems.Add(dr["ArriveDate"].ToString());
                listitem.SubItems.Add(dr["Status"].ToString());
                listViewDN.Items.Add(listitem);
            }
            cnn.Close();
        }
    }
}
