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
    public partial class ViewRequest : Form
    {
        private string staffNo;
        private string restNo;
        private string restHierarchy;
        private PurchaseRequest pr;
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;");
        public ViewRequest(PurchaseRequest pr, string staffNo, string restNo, string staffName, string restName, string selectedRequest, string createDate, string status)
        {
            InitializeComponent();
            cnn.Open();
            StfId.Text = staffNo;
            StfName.Text = staffName;
            RestId.Text = restNo;
            RestName.Text = restName;
            CreateDate.Text = createDate.Substring(0, 10);
            this.status.Text = status;
            this.pr = pr;
            this.restNo = restNo;
            this.staffNo = staffNo;
            title.Text = "Purchase Request " + selectedRequest;
            MySqlDataAdapter showList = new MySqlDataAdapter("SELECT i.ItemName, pr.Quantity, v.VItemID, c.category_id FROM VItem v,Item i ,Category c,PurchaseRequest pr WHERE v.category_id = c.category_id AND v.ItemID = i.ItemID AND pr.VItemID = v.VItemID AND pr.category_id = v.category_id AND pr.RequestNo = '" + selectedRequest + "';", cnn);
            DataTable dt = new DataTable();
            showList.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                purchaseList2.Rows.Add(dr["itemName"].ToString(), dr["Quantity"].ToString(), dr["VItemID"].ToString(), dr["Category_id"].ToString());
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            pr.Show();
        }
    }
}
