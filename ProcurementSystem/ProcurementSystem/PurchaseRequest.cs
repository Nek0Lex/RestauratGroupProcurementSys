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
    public partial class PurchaseRequest : Form
    {
        private Menu m;
        public PurchaseRequest(Menu m, String restNo)
        {
            InitializeComponent();
            this.m = m;
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;");
            MySqlDataAdapter sda = new MySqlDataAdapter("select * from PurchaseRequest where RestNo = '"+restNo+"'", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows) {
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
            CreatePurchaseRequest cpr = new CreatePurchaseRequest(this);
            this.Hide();
            cpr.Show();
        }
    }
}
