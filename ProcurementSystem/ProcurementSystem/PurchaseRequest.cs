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
    public partial class PurchaseRequest : Form
    {
        private String staffNo;
        private Menu m;
        private String restName;
        private String restNo;
        private String staffName;
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;");
        public PurchaseRequest(Menu m, String restNo, String staffNo)
        {
            cnn.Open();
            InitializeComponent();
            this.m = m;
            this.staffNo = staffNo;
            this.restNo = restNo;
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter("select pr.RequestNo, FirstName, LastName, RestName, sr.RestNo, sr.StaffNo from Staff as s, PurchaseRequest as pr, StaffRestaurant as sr, Restaurant as r where pr.RestNo = '"+restNo+ "' and pr.RestNo = sr.RestNo and sr.StaffNo = s.StaffNo and sr.RestNo = r.RestNo Group by pr.RequestNo;", cnn);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows) {
                staffName = dr["FirstName"].ToString()+dr["LastName"].ToString();
                restName = dr["RestName"].ToString();
                purchaseRequestList.Items.Insert(0, dr["RequestNo"].ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void purchaseRequestList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void prBack_Click(object sender, EventArgs e)
        {
            this.Close();
            m.Show();
        }

        private void edditPRbtn_Click(object sender, EventArgs e)
        {
            EditPurchaseRequest epr = new EditPurchaseRequest(this);
            this.Hide();
            epr.Show();
        }

        private void createPRbtn_Click_1(object sender, EventArgs e)
        {
            CreatePurchaseRequest cpr = new CreatePurchaseRequest(this, staffNo, restNo, staffName, restName);
            this.Hide();
            cpr.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void deletePRbtn_Click(object sender, EventArgs e) {
            MySqlCommand del;
            foreach (Object item in purchaseRequestList.CheckedItems)
            {
                del = new MySqlCommand("Delete form PurchaseRequest where RequestNo = '" + item.ToString() + "'", cnn);
                del.ExecuteNonQuery();
            }
        }
    }
}
