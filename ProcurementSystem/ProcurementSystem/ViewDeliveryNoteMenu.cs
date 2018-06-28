using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcurementSystem
{
    public partial class ViewDeliveryNoteMenu : Form
    {
        private String restNo;
        private Menu m;
        public ViewDeliveryNoteMenu(Menu m, String restNo)
        {
            InitializeComponent();
            this.m = m;
            this.restNo = restNo;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewDeliveryNoteMenu_Load(object sender, EventArgs e)
        {

        }

        private void loadData()
        {
            MySqlDataAdapter sda = new MySqlDataAdapter("select * from DeliveryNote dn, PurchaseRequest pr Where dn.RequestNo=pr.RequestNo and pr.restNo='"+restNo+"';", cnn);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem listitem = new ListViewItem(dr["StaffNo"].ToString());
                listitem.SubItems.Add(dr["FirstName"].ToString());
                listitem.SubItems.Add(dr["LastName"].ToString());
                listitem.SubItems.Add(dr["DeptCode"].ToString());
                listitem.SubItems.Add(dr["Password"].ToString());
                listViewUser.Items.Add(listitem);
            }
        }
    }
}
