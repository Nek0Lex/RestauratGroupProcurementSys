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
    public partial class VIDMapping : Form
    {
        int mode;
        string currentCategory;
        string VItemID;
        string ItemID;
        string ItemName;
        string ItemDescription;
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;");

        public VIDMapping()
        {
            InitializeComponent();
        }

        public VIDMapping(string currentCategory)
        {
            InitializeComponent();
            mode = 0; //Create mode
            LoadItem();
            this.currentCategory = currentCategory;
        }

        public VIDMapping(string currentCategory, DataGridViewSelectedRowCollection selectedRow)
        {
            InitializeComponent();
            mode = 1; //Edit mode
            LoadItem();
            this.currentCategory = currentCategory;
            foreach (DataGridViewRow row in selectedRow)
            {
                VItemID = row.Cells[0].Value.ToString();
                ItemID = row.Cells[1].Value.ToString();
                ItemName = row.Cells[2].Value.ToString();
                ItemDescription = row.Cells[3].Value.ToString();
            }

            textBox_VItemID.Text = VItemID;
            textBox_ItemID.Text = ItemID;
            textBox_ItemName.Text = ItemName;
            textBox_ItemDescription.Text = ItemDescription;

        }

        public void LoadItem()
        {
            cnn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM Item; ", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();
        }

        private void AddSelectedItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    try
                    {
                        textBox_ItemID.Text = row.Cells[0].Value.ToString();
                        textBox_ItemName.Text = row.Cells[1].Value.ToString();
                        textBox_ItemDescription.Text = row.Cells[2].Value.ToString();
                    }
                    catch (Exception ex) { };
                }
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            switch (mode)
            {
                case 0:
                    CreateMapping();
                    break;
                case 1:
                    UpdateMapping();
                    break;
            }
            
            this.Close();
        }

        public void CreateMapping()
        {
            if (!string.IsNullOrWhiteSpace(textBox_VItemID.Text) && !string.IsNullOrWhiteSpace(textBox_ItemID.Text))
            {
                cnn.Open();
                string insert = "INSERT INTO VItem (VItemID, category_id, ItemID) VALUES ('" + textBox_VItemID.Text + "', " + currentCategory + ", '" + textBox_ItemID.Text + "'); ";
                //string insert = "INSERT INTO VItem (VItemID, category_id, ItemID) VALUES ('FTEST', 10, 'F00000002'; ";
                MySqlCommand cmd = new MySqlCommand(insert, cnn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Insert Failed: Duplicate with existing Mapping");
                    Console.WriteLine(ex.ToString());
                    cnn.Close();
                    return;
                }
                MessageBox.Show("Create Success!");
            }
            cnn.Close();
        }

        public void UpdateMapping()
        {
            cnn.Open();
            string update = "UPDATE VItem SET VItemID = '" + textBox_VItemID.Text + "', ItemID = '" + textBox_ItemID.Text + "' WHERE VItemID = '" + VItemID + "' AND category_id = " + currentCategory + ";";
            MySqlCommand cmd = new MySqlCommand(update, cnn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Update Failed: Duplicate with existing Mapping");
                Console.WriteLine(ex.ToString());
                cnn.Close();
                return;
            }
            MessageBox.Show("Update Success!");
            cnn.Close();
        }
    }
}
