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
    public partial class WHViewDPI : Form
    {
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
        public WHViewDPI(Menu m)
        {
            InitializeComponent();
            MySqlDataAdapter sda = new MySqlDataAdapter("select DISTINCT DesID, RequestNo,CreationDate,Status from DespatchInstruction;", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem listitem = new ListViewItem(dr["DesID"].ToString());
                listitem.SubItems.Add(dr["RequestNo"].ToString());
                listitem.SubItems.Add(dr["CreationDate"].ToString());
                listitem.SubItems.Add(dr["Status"].ToString());
                listViewDes.Items.Add(listitem);
            }
        }

        private void WHViewDPI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listViewDes.SelectedItems.Count >= 1)
            {
                String iId = listViewDes.SelectedItems[0].SubItems[0].Text;
                WHGenerateDN dn = new WHGenerateDN(iId);
                dn.Show();
            }
            else
            {
                MessageBox.Show("Please select the supplier \n that you want to delete.", "Select Supplier!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
