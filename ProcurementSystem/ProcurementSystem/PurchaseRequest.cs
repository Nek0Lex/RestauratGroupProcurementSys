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
        private int selCount;
        private String selectedRequest;
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;");
        public PurchaseRequest(Menu m, String restNo, String staffNo)
        {
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
            selCount = 0;
            string createStaffName=null;
            string createStaffId=null;
            string creationDate = null;
            for (int i = 0; i < purchaseRequestList.Items.Count; i++)
            {
                if (purchaseRequestList.GetItemChecked(i))
                {
                    selCount++;
                    selectedRequest = purchaseRequestList.Items[i].ToString();
                }
            }
            if (selCount !=1)
            {
                errorEditMsg.Text = "Please select only ONE request!";
            }
            else
            {
                MySqlDataAdapter getRequest = new MySqlDataAdapter("SELECT pr.RequestNo, FirstName, LastName, RestName, pr.RestNo, pr.StaffNo, pr.CreationDate from Staff as s, PurchaseRequest as pr, StaffRestaurant as sr, Restaurant as r where pr.RequestNo = '" + selectedRequest + "' and pr.RestNo = sr.RestNo and sr.StaffNo = s.StaffNo and sr.RestNo = r.RestNo Group by pr.RequestNo;", cnn);
                DataTable dt2 = new DataTable();
                getRequest.Fill(dt2);
                foreach (DataRow dr2 in dt2.Rows) {
                    createStaffName = dr2["FirstName"].ToString() + dr2["LastName"].ToString();
                    createStaffId = dr2["StaffNo"].ToString();
                    creationDate = Convert.ToDateTime(dr2["CreationDate"]).ToString("dd-MM-yyyy");
                }
                EditPurchaseRequest epr = new EditPurchaseRequest(this, createStaffId, restNo, createStaffName, restName, selectedRequest,creationDate);
                this.Hide();
                epr.Show();
            }

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
            errorMsg.Text = "";
            cnn.Open();

            for (int i = 0; i < purchaseRequestList.Items.Count; i++)
            {
                try
                {
                    if (purchaseRequestList.GetItemChecked(i))
                    {
                        del = new MySqlCommand("Delete from PurchaseRequest where RequestNo = '" + purchaseRequestList.Items[i].ToString() + "'", cnn);
                        del.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    errorMsg.Text = "Some of the request is handled, Cannot Edit of delete!";
                    break;
                }
                //purchaseRequestList.Items.RemoveAt(i);
                finally
                {
                    this.Refresh();
                }
            }
        }
    }
}
