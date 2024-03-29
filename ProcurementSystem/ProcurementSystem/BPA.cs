﻿using System;
using System.Globalization;
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
    public partial class Form1 : Form
    {
        private TypeofAgreementMenu tam;
        public Form1(TypeofAgreementMenu tam)
        {
            InitializeComponent();
            this.tam = tam;
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
            cnn.Open();
            String query = "select * from BlanketPurchaseAgreement ORDER BY BPANo ASC;";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataAdapter ada = new MySqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            CultureInfo arSA = new CultureInfo("ar-SA");
            arSA.DateTimeFormat.Calendar = new UmAlQuraCalendar();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];

                ListViewItem listitem = new ListViewItem(dr["BPANo"].ToString());
                listitem.SubItems.Add(dr["RequestNo"].ToString());
                listitem.SubItems.Add(dr["PurchaseOrderRevision"].ToString());
                listitem.SubItems.Add(dr["CreationDate"].ToString());
                listitem.SubItems.Add(dr["EffectiveDate"].ToString());
                listitem.SubItems.Add(dr["BuyerName"].ToString());
                listitem.SubItems.Add(dr["BillingAddress"].ToString());
                listitem.SubItems.Add(dr["AmountAgreed"].ToString());
                listitem.SubItems.Add(dr["Currency"].ToString());
                listitem.SubItems.Add(dr["TermsAndCondition"].ToString());
                listitem.SubItems.Add(dr["SupplierNo"].ToString());

                listView1.Items.Add(listitem);
                
                
            }

            DateTime now = DateTime.Now;
            DateTime effectiveDate;
            int datecompare;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                effectiveDate = DateTime.Parse(listView1.Items[i].SubItems[4].Text);
                datecompare = DateTime.Compare(now, effectiveDate);
                if (datecompare > 0)
                {
                    listView1.Items[i].BackColor = Color.Yellow;
                }
                else
                    continue;
            }
            //textBox1.Text = datecompare.ToString();

        }

        public void dateTimeCompare()
        {
            DateTime now = DateTime.Now;
            DateTime effectiveDate;
            int datecompare;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                effectiveDate = DateTime.Parse(listView1.Items[i].SubItems[4].Text);
                datecompare = DateTime.Compare(now, effectiveDate);
                if (datecompare > 0)
                {
                    listView1.Items[i].BackColor = Color.Yellow;
                }
                else
                    continue;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BPAAdd BPAAdd = new BPAAdd();
            BPAAdd.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            tam.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void button3_Click(object sender, EventArgs e)
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
                String delete = "DELETE from BlanketPurchaseAgreement where BPANo = '" + deleteitem + "'; ";
                MySqlCommand cmd = new MySqlCommand(delete, cnn);
                cmd.ExecuteNonQuery();
                delete = "DELETE FROM BlanketPurchaseRelease WHERE BPANo = '" + deleteitem + "'; ";
                cmd = new MySqlCommand(delete, cnn);
                cmd.ExecuteNonQuery();
                delete = "DELETE FROM BPALines WHERE BPANo = '" + deleteitem + "'; ";
                cmd = new MySqlCommand(delete, cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Remove success!");
                refreshFunction();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nothing Selected", "ERROR");
                return;
            }
            else
            {
                BPAEdit bPAEdit = new BPAEdit(this, listView1);
                bPAEdit.ShowDialog();
            }

        }

        public string bpaNo
        {
           get { return listView1.SelectedItems[0].Text; }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
            cnn.Open();
            String query = "select * from BlanketPurchaseAgreement ORDER BY BPANo ASC;";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataAdapter ada = new MySqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];

                ListViewItem listitem = new ListViewItem(dr["BPANo"].ToString());
                listitem.SubItems.Add(dr["RequestNo"].ToString());
                listitem.SubItems.Add(dr["PurchaseOrderRevision"].ToString());
                listitem.SubItems.Add(dr["CreationDate"].ToString());
                listitem.SubItems.Add(dr["EffectiveDate"].ToString());
                listitem.SubItems.Add(dr["BuyerName"].ToString());
                listitem.SubItems.Add(dr["BillingAddress"].ToString());
                listitem.SubItems.Add(dr["AmountAgreed"].ToString());
                listitem.SubItems.Add(dr["Currency"].ToString());
                listitem.SubItems.Add(dr["TermsAndCondition"].ToString());
                listitem.SubItems.Add(dr["SupplierNo"].ToString());

                listView1.Items.Add(listitem);
            }

            dateTimeCompare();
        }

        private void refreshFunction()
        {
            listView1.Items.Clear();
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
            cnn.Open();
            String query = "select * from BlanketPurchaseAgreement ORDER BY BPANo ASC;";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            MySqlDataAdapter ada = new MySqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];

                ListViewItem listitem = new ListViewItem(dr["BPANo"].ToString());
                listitem.SubItems.Add(dr["RequestNo"].ToString());
                listitem.SubItems.Add(dr["PurchaseOrderRevision"].ToString());
                listitem.SubItems.Add(dr["CreationDate"].ToString());
                listitem.SubItems.Add(dr["EffectiveDate"].ToString());
                listitem.SubItems.Add(dr["BuyerName"].ToString());
                listitem.SubItems.Add(dr["BillingAddress"].ToString());
                listitem.SubItems.Add(dr["AmountAgreed"].ToString());
                listitem.SubItems.Add(dr["Currency"].ToString());
                listitem.SubItems.Add(dr["TermsAndCondition"].ToString());
                listitem.SubItems.Add(dr["SupplierNo"].ToString());

                listView1.Items.Add(listitem);
            }

            dateTimeCompare();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nothing Selected", "ERROR");
                return;
            }
            else
            {
                BPAStatus bPAStatus = new BPAStatus(this, listView1);
                bPAStatus.ShowDialog();
            }
        }
    }
}
