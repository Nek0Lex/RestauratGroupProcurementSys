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
    public partial class Item : Form
    {
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;");
        Menu m;
        public Item(Menu m)
        {
            InitializeComponent();
            this.m = m;
            ReloadItem();
        }

        private void ReloadItem()
        {
            cnn.Open();
            //MySqlDataAdapter sda = new MySqlDataAdapter("SELECT i.ItemID, i.ItemName, i.ItemDescription, s.SupplierName FROM Item i LEFT JOIN SupplierItem si ON i.ItemID = si.ItemID LEFT JOIN Supplier s ON si.SupplierNo = s.SupplierNo;", cnn);
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM Item;", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();
        }


        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            m.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ItemManagement createItem = new ItemManagement();
            createItem.FormClosing += new FormClosingEventHandler(this.ItemManagement_FormClosing);
            createItem.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {

            }
            else
            {
                DataGridViewSelectedRowCollection selectedRow = dataGridView1.SelectedRows;
                ItemManagement createItem = new ItemManagement(selectedRow);
                createItem.FormClosing += new FormClosingEventHandler(this.ItemManagement_FormClosing);
                createItem.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string ItemID = row.Cells[0].Value.ToString();
                MySqlCommand del;
                cnn.Open();
                try
                {
                    del = new MySqlCommand("DELETE FROM Item WHERE ItemID = '" + ItemID + "'; ", cnn);
                    del.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    cnn.Close();
                }
                ReloadItem();
            }
        }

        private void ItemManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReloadItem();
        }
    }
}
