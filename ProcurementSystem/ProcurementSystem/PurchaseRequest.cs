﻿using System;
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
        private String status;
        private int selCount;
        private String selectedRequest;
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;");
        public PurchaseRequest(Menu m, String restNo, String staffNo)
        {
            cnn.Open();
            InitializeComponent();
            this.m = m;
            this.staffNo = staffNo;
            this.restNo = restNo;
            DataTable dt = new DataTable();
            MySqlCommand currentStaff = new MySqlCommand("select LastName from Staff where StaffNo='"+staffNo+"';",cnn);
            MySqlDataAdapter sda = new MySqlDataAdapter("select pr.RequestNo, FirstName, LastName, RestName, sr.RestNo, sr.StaffNo from Staff as s, PurchaseRequest as pr, StaffRestaurant as sr, Restaurant as r where pr.RestNo = '"+restNo+ "' and pr.RestNo = sr.RestNo and sr.StaffNo = s.StaffNo and sr.RestNo = r.RestNo Group by pr.RequestNo;", cnn);
            sda.Fill(dt);
            currentLogin.Text = "Hello, " +(string)currentStaff.ExecuteScalar();
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
                errorEditMsg.Text = "";
                errorMsg.Text = "";
                errorSearchMsg.Text = "";
                MySqlDataAdapter getRequest = new MySqlDataAdapter("SELECT pr.RequestNo, FirstName, LastName, RestName, pr.RestNo, pr.StaffNo, pr.CreationDate, pr.Status from Staff as s, PurchaseRequest as pr, StaffRestaurant as sr, Restaurant as r where pr.RequestNo = '" + selectedRequest + "' and pr.RestNo = sr.RestNo and sr.StaffNo = s.StaffNo and sr.RestNo = r.RestNo Group by pr.RequestNo;", cnn);
                DataTable dt2 = new DataTable();
                getRequest.Fill(dt2);
                foreach (DataRow dr2 in dt2.Rows) {
                    createStaffName = dr2["FirstName"].ToString() + dr2["LastName"].ToString();
                    createStaffId = dr2["StaffNo"].ToString();
                    status = dr2["Status"].ToString();
                    creationDate = Convert.ToDateTime(dr2["CreationDate"]).ToString("dd-MM-yyyy");
                }
                if (status == "NEW")
                {
                    EditPurchaseRequest epr = new EditPurchaseRequest(this, createStaffId, restNo, createStaffName, restName, selectedRequest, creationDate);
                    this.Hide();
                    epr.Show();
                }
                else {
                    ViewRequest vr = new ViewRequest(this, createStaffId, restNo, createStaffName, restName, selectedRequest, creationDate, status);
                    this.Hide();
                    vr.Show();
                }
            }

        }

        private void createPRbtn_Click_1(object sender, EventArgs e)
        {
            errorEditMsg.Text = "";
            errorMsg.Text = "";
            errorSearchMsg.Text = "";
            CreatePurchaseRequest cpr = new CreatePurchaseRequest(this, staffNo, restNo, staffName, restName);
            this.Hide();
            cpr.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void deletePRbtn_Click(object sender, EventArgs e) {
            MySqlCommand del;
            errorEditMsg.Text = "";
            errorMsg.Text = "";
            errorSearchMsg.Text = "";
            for (int i = 0; i < purchaseRequestList.Items.Count; i++)
            {
            try
            {
                MySqlCommand checkNew = new MySqlCommand("Select Status from PurchaseRequest where RequestNo ='"+purchaseRequestList.Items[i]+"';",cnn);
                String checkStatus = checkNew.ExecuteScalar().ToString();
                if (purchaseRequestList.GetItemChecked(i) & checkStatus=="NEW")
                {
                    del = new MySqlCommand("Delete from PurchaseRequest where RequestNo = '" + purchaseRequestList.Items[i].ToString() + "';", cnn);
                    del.ExecuteNonQuery();
                }
            }
                catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                errorMsg.Text = "Some of the selected request have been handled!";
            }
                finally
            {
                this.Refresh();
            }
        }
            btnRefresh_Click(sender, e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            purchaseRequestList.Items.Clear();
            DataTable dt2 = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter("select pr.RequestNo from Staff as s, PurchaseRequest as pr, StaffRestaurant as sr, Restaurant as r where pr.RestNo = '" + restNo + "' and pr.RestNo = sr.RestNo and sr.StaffNo = s.StaffNo and sr.RestNo = r.RestNo Group by pr.RequestNo;", cnn);
            sda.Fill(dt2);
            foreach (DataRow dr in dt2.Rows)
            {
                purchaseRequestList.Items.Insert(0, dr["RequestNo"].ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (searchText.Text == null)
            {
                errorSearchMsg.Text = "Search Item cannot be null";
            }
            else {
                errorEditMsg.Text = "";
                errorMsg.Text = "";
                errorSearchMsg.Text = "";
                if (searchByRequestNo.Checked)
                {
                    MySqlDataAdapter searchRequestNo = new MySqlDataAdapter("Select DISTINCT RequestNo from PurchaseRequest where RequestNo ='" + searchText.Text+ "' Group By RequestNo;", cnn);
                    DataTable result = new DataTable();
                    searchRequestNo.Fill(result);
                    purchaseRequestList.Items.Clear();
                    foreach (DataRow dr in result.Rows)
                    {
                        purchaseRequestList.Items.Insert(0, dr["RequestNo"].ToString());
                    }
                }
                else if (searchByStaffNo.Checked)
                {
                    MySqlDataAdapter searchRequestNo = new MySqlDataAdapter("Select DISTINCT RequestNo from PurchaseRequest where StaffNo ='" + searchText.Text + "';", cnn);
                    DataTable result = new DataTable();
                    searchRequestNo.Fill(result);
                    purchaseRequestList.Items.Clear();
                    foreach (DataRow dr in result.Rows)
                    {
                        purchaseRequestList.Items.Insert(0, dr["RequestNo"].ToString());
                    }
                }
                else if (searchByStatus.Checked) {
                    MySqlDataAdapter searchRequestNo = new MySqlDataAdapter("Select DISTINCT RequestNo from PurchaseRequest where Status ='" + searchText.Text + "';", cnn);
                    DataTable result = new DataTable();
                    searchRequestNo.Fill(result);
                    purchaseRequestList.Items.Clear();
                    foreach (DataRow dr in result.Rows)
                    {
                        purchaseRequestList.Items.Insert(0, dr["RequestNo"].ToString());
                    }
                }
            }
        }

        private void searchByRequestNo_CheckedChanged(object sender, EventArgs e)
        {
            searchText.Text = null;
            searchText.Items.Clear();
            searchText.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void searchByStatus_CheckedChanged(object sender, EventArgs e)
        {
            searchText.Text = null;
            searchText.Items.Clear();
            searchText.DropDownStyle = ComboBoxStyle.DropDownList;
            string[] statusList = {"NEW", "PSS", "DLI", "CAN", "PPO", "SPO", "BPA", "COM" };
            foreach (string status in statusList)
            {
                searchText.Items.Add(status);
            }
        }

        private void searchByStaffNo_CheckedChanged(object sender, EventArgs e)
        {
            searchText.Text = null;
            searchText.Items.Clear();
            searchText.DropDownStyle = ComboBoxStyle.DropDownList;
            MySqlDataAdapter staffList = new MySqlDataAdapter("select sr.StaffNo from Staff as s, StaffRestaurant as sr, Restaurant as r where sr.StaffNo = s.StaffNo and sr.RestNo = r.RestNo and sr.RestNo = '"+restNo+"';", cnn);
            DataTable staff = new DataTable();
            staffList.Fill(staff);
            foreach (DataRow dr in staff.Rows) {
                searchText.Items.Add(dr["StaffNo"].ToString());
            }
        }
    }
}
