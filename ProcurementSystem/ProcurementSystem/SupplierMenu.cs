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
    public partial class SupplierMenu : Form
    {
        private Menu m;
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
        public SupplierMenu(Menu m)
        {
            InitializeComponent();
            this.m = m;
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter("select * from Supplier;", cnn);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem listitem = new ListViewItem(dr["SupplierNo"].ToString());
                listitem.SubItems.Add(dr["SupplierContact"].ToString());
                listitem.SubItems.Add(dr["SupplierAddress"].ToString());
                listViewSupplier.Items.Add(listitem);
            }
        }

        private void SupplierMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            m.Show();
        }

        private void listViewSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateSupp cs = new CreateSupp(listViewSupplier.SelectedItems[0].SubItems[0].Text, m);
            this.Close();
            cs.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditSupp es = new EditSupp(listViewSupplier.SelectedItems[0].SubItems[0].Text,
                listViewSupplier.SelectedItems[0].SubItems[1].Text, listViewSupplier.SelectedItems[0].SubItems[2].Text, m);
            this.Close();
            es.Show();
        }
    }
}