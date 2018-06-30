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
    public partial class WHUpdateDN : Form
    {
        private String DNId, status;
        private ViewDeliveryNoteMenu m;
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;");
        public WHUpdateDN(ViewDeliveryNoteMenu m, String DNId, String status)
        {
            InitializeComponent();
            this.m = m;
            this.DNId = DNId;
            this.status = status;
            cnn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT DN.ItemID, ItemName, ItemDescription, Quantity as quantity, ArrivedQty as arrived FROM DeliveryNote DN, Item I WHERE DN.ItemID=I.ItemID and DeliveryID = '" + DNId + "';", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dGVItem.DataSource = dt;
            MySqlDataAdapter getDNInfo = new MySqlDataAdapter("SELECT DeliveryID, RequestNo, DesID, CreationDate From DeliveryNote Where DeliveryID = '" + DNId + "';", cnn);
            DataTable DNInfo = new DataTable();
            getDNInfo.Fill(DNInfo);
            cnn.Close();
            lbDID.Text = DNInfo.Rows[0][0].ToString();
            lbRNo.Text = DNInfo.Rows[0][1].ToString();
            lbDesId.Text = DNInfo.Rows[0][2].ToString();
            lbCreationDate.Text = DNInfo.Rows[0][3].ToString();
            lbStatus.Text = status;
            btnUpdate.Enabled = false;
            Dictionary<String, String> comboSource = new Dictionary<String, String>();
            comboSource.Add("1", "DLI");
            comboSource.Add("2", "COM");
            comboSource.Add("3", "DNC");
            comboSource.Add("4", "CAN");
            cbStatus.DataSource = new BindingSource(comboSource, null);
            cbStatus.DisplayMember = "Value";
            cbStatus.ValueMember = "Key";
        }

        private void WHUpdateDN_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbStatus.Text = cbStatus.Text;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dGVItem.SelectedRows.Count < 0)
            {
                MessageBox.Show("You must select a item", "Select a Item !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(numQty.Text))
            {
                MessageBox.Show("You must input at least 0", "Check your input !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (checkArrived.Checked)
            {
                if (lbStatus.Text.Equals("COM"))
                    dGVItem.SelectedRows[0].Cells["quantity"].Value = numQty.Value.ToString();
                if (lbStatus.Text.Equals("DLI"))
                    MessageBox.Show("Nothing should be arrived \nif status is delivering", "Check your status !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    dGVItem.SelectedRows[0].Cells["arrived"].Value = numQty.Value.ToString();
            }
            else
            {
                if (lbStatus.Text.Equals("COM"))
                    dGVItem.SelectedRows[0].Cells["arrived"].Value = numQty.Value.ToString();
                if (lbStatus.Text.Equals("DLI"))
                    dGVItem.SelectedRows[0].Cells["arrived"].Value = 0;
                dGVItem.SelectedRows[0].Cells["quantity"].Value = numQty.Value.ToString();
            }
        }

        private void dGVItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checkArrived.Checked)
                numQty.Value = Convert.ToDecimal(dGVItem.Rows[e.RowIndex].Cells["arrived"].Value.ToString());
            else
                numQty.Value = Convert.ToDecimal(dGVItem.Rows[e.RowIndex].Cells["quantity"].Value.ToString());
            btnUpdate.Enabled = true;
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            cnn.Open();
            foreach (DataGridViewRow row in dGVItem.Rows)
            {
                int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
                int arrivedQty = Convert.ToInt32(row.Cells["arrived"].Value);
                String itemID = Convert.ToString(row.Cells["ItemID"].Value);
                MySqlCommand updateStock = new MySqlCommand("UPDATE DeliveryNote SET quantity = '" + quantity + "', ArrivedQty ='"+ arrivedQty + "',Status = '"+ lbStatus.Text + "' WHERE ItemID = '" + itemID + "' and DeliveryID = '" + DNId + "';", cnn);
                updateStock.ExecuteNonQuery();
            }
            cnn.Close();
            MessageBox.Show("Update Success!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            m.loadData();
            this.Close();
        }
    }
}
