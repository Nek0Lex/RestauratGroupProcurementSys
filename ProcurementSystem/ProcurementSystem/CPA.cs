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
    public partial class CPA : Form
    {
        private TypeofAgreementMenu tam;
        public CPA(TypeofAgreementMenu tam)
        {
            InitializeComponent();
            this.tam = tam;
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
            cnn.Open();
            String query = "select * from CPA ORDER BY ContractNo ASC;";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataAdapter ada = new MySqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];

                ListViewItem listitem = new ListViewItem(dr["ContractNo"].ToString());
                listitem.SubItems.Add(dr["SupplierNo"].ToString());
                listitem.SubItems.Add(dr["CreationDate"].ToString());
                listitem.SubItems.Add(dr["EffectiveDate"].ToString());
                listitem.SubItems.Add(dr["BuyerName"].ToString());
                listitem.SubItems.Add(dr["BillingAddress"].ToString());
                listitem.SubItems.Add(dr["TermsAndCondition"].ToString());
                listitem.SubItems.Add(dr["ItemID"].ToString());
                

                listView1.Items.Add(listitem);
            }
            dateTimeCompare();
        }

        public void dateTimeCompare()
        {
            DateTime now = DateTime.Now;
            DateTime effectiveDate;
            int datecompare;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                effectiveDate = DateTime.Parse(listView1.Items[i].SubItems[3].Text);
                datecompare = DateTime.Compare(now, effectiveDate);
                if (datecompare > 0)
                {
                    listView1.Items[i].BackColor = Color.Yellow;
                }
                else
                    continue;
            }
        }

        private void CPA_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            tam.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CPAAdd CPAAdd = new CPAAdd();
            CPAAdd.ShowDialog();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nothing Selected", "ERROR");
                return;
            }
            else
            {
                CPAEdit cpaEdit = new CPAEdit(this, listView1);
                cpaEdit.ShowDialog();
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            refreshFunction();
            dateTimeCompare();
        }

        private void status_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nothing Selected", "ERROR");
                return;
            }
            else
            {
                CPAStatus cpaStatus = new CPAStatus(this, listView1);
                cpaStatus.ShowDialog();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nothing Selected", "ERROR");
                return;
            }
            else
            {
                MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
                cnn.Open();
                String deleteitem = listView1.SelectedItems[0].SubItems[0].Text;
                String query = "DELETE from CPA where ContractNo = '" + deleteitem + "'; ";
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                MySqlDataAdapter ada = new MySqlDataAdapter(query, cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Remove success!");
                refreshFunction();
            }
        }

        private void refreshFunction()
        {
            listView1.Items.Clear();
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
            cnn.Open();
            String query = "select * from CPA ORDER BY ContractNo ASC;";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataAdapter ada = new MySqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];

                ListViewItem listitem = new ListViewItem(dr["ContractNo"].ToString());
                listitem.SubItems.Add(dr["SupplierNo"].ToString());
                listitem.SubItems.Add(dr["CreationDate"].ToString());
                listitem.SubItems.Add(dr["EffectiveDate"].ToString());
                listitem.SubItems.Add(dr["BuyerName"].ToString());
                listitem.SubItems.Add(dr["BillingAddress"].ToString());
                listitem.SubItems.Add(dr["TermsAndCondition"].ToString());
                listitem.SubItems.Add(dr["ItemID"].ToString());


                listView1.Items.Add(listitem);
            }
            dateTimeCompare();
        }
    }
}
