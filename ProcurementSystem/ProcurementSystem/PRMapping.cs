﻿using System;
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
    public partial class PRMapping : Form
    {
        private Menu m;
        private string selectedRequest;
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;");
        public PRMapping(Menu m)
        {
            InitializeComponent();
            this.m = m;
            cnn.Open();
            MySqlDataAdapter findRequestList = new MySqlDataAdapter("Select RequestNo, CreationDate From PurchaseRequest where status='NEW' Group BY RequestNo;", cnn);
            DataTable dt = new DataTable();
            findRequestList.Fill(dt);
            foreach (DataRow dr in dt.Rows) {
                requestList.Rows.Add(dr["RequestNo"].ToString(), Convert.ToDateTime(dr["CreationDate"]).ToString("dd-MM-yyyy"));
            }
        }
            private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            m.Show();
        }

        private void itemList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void requestList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            itemList.Rows.Clear();
            int i;
            i = requestList.SelectedCells[0].RowIndex;
            selectedRequest = tbRequestID.Text = requestList.Rows[i].Cells[0].Value.ToString();
            tbCreateDate.Text = Convert.ToDateTime(requestList.Rows[i].Cells[1].Value.ToString()).ToString("dd-MM-yyyy");
            MySqlDataAdapter item = new MySqlDataAdapter("SELECT i.ItemName, pr.Quantity FROM VItem v,Item i ,Category c,PurchaseRequest pr WHERE v.category_id = c.category_id AND v.ItemID = i.ItemID AND pr.VItemID = v.VItemID AND pr.category_id = v.category_id AND pr.RequestNo = '" + selectedRequest + "';", cnn);
            DataTable dt2 = new DataTable();
            item.Fill(dt2);
            foreach (DataRow dr in dt2.Rows)
            {
                 itemList.Rows.Add(dr["itemName"].ToString(), dr["Quantity"].ToString());
            }
            itemList.Refresh();
        }
    }
}
