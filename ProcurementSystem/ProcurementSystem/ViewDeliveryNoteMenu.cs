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
    public partial class ViewDeliveryNoteMenu : Form
    {
        private String restNo, role;
        private Menu m;
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
        public ViewDeliveryNoteMenu(Menu m, String role, String restNo)
        {
            InitializeComponent();
            this.m = m;
            this.restNo = restNo;
            this.role = role;
            loadData();
        }

        public ViewDeliveryNoteMenu(Menu m, String role)
        {
            InitializeComponent();
            this.m = m;
            this.role = role;
            btnConfirm.Text = "Update Delivery Note";
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (role.Equals("RM"))
            {
                RMConfirmDN vDN = new RMConfirmDN(this, listViewDN.SelectedItems[0].SubItems[0].Text, listViewDN.SelectedItems[0].SubItems[4].Text);
                vDN.Show();
            }
            else
            {
                WHUpdateDN uDN = new WHUpdateDN(this, listViewDN.SelectedItems[0].SubItems[0].Text, listViewDN.SelectedItems[0].SubItems[4].Text);
                uDN.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewDeliveryNoteMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            m.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSearch.Text))
            {
                MessageBox.Show("You should input id to search", "Check Your Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                listViewDN.Items.Clear();
                cnn.Open();
                MySqlDataAdapter sda;
                if (role.Equals("RM"))
                    sda = new MySqlDataAdapter("select Distinct DeliveryID, dn.RequestNo, DesID, dn.CreationDate, dn.Status from DeliveryNote dn, PurchaseRequest pr Where DeliveryID LIKE '%" + tbSearch.Text+"%' and dn.RequestNo=pr.RequestNo and dn.Status<>'CAN' and pr.RestNo='" + restNo + "' Order by DeliveryID ASC;", cnn);
                else
                    sda = new MySqlDataAdapter("select Distinct DeliveryID, dn.RequestNo, DesID, dn.CreationDate, dn.Status from DeliveryNote dn, PurchaseRequest pr Where DeliveryID LIKE '%" + tbSearch.Text + "%' Order by DeliveryID ASC;", cnn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem listitem = new ListViewItem(dr["DeliveryID"].ToString());
                    listitem.SubItems.Add(dr["RequestNo"].ToString());
                    listitem.SubItems.Add(dr["DesID"].ToString());
                    listitem.SubItems.Add(Convert.ToDateTime(dr["CreationDate"]).ToString("dd-MM-yyyy"));
                    listitem.SubItems.Add(dr["Status"].ToString());
                    listViewDN.Items.Add(listitem);
                }
                cnn.Close();
            }
        }

        private void btnInitial_Click(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            listViewDN.Items.Clear();
            cnn.Open();
            MySqlDataAdapter sda;
            if (role.Equals("RM"))
                sda = new MySqlDataAdapter("select Distinct DeliveryID, dn.RequestNo, DesID, dn.CreationDate, dn.Status from DeliveryNote dn, PurchaseRequest pr Where dn.RequestNo=pr.RequestNo and dn.Status<>'CAN' and pr.RestNo='" + restNo+ "' Order by DeliveryID DESC;", cnn);
            else
                sda = new MySqlDataAdapter("select Distinct DeliveryID, dn.RequestNo, DesID, dn.CreationDate, dn.Status from DeliveryNote dn, PurchaseRequest pr Order by DeliveryID DESC;", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem listitem = new ListViewItem(dr["DeliveryID"].ToString());
                listitem.SubItems.Add(dr["RequestNo"].ToString());
                listitem.SubItems.Add(dr["DesID"].ToString());
                listitem.SubItems.Add(Convert.ToDateTime(dr["CreationDate"]).ToString("dd-MM-yyyy"));
                listitem.SubItems.Add(dr["Status"].ToString());
                listViewDN.Items.Add(listitem);
            }
            cnn.Close();
        }
    }
}
