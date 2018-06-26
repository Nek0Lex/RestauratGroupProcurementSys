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
    public partial class WHStock : Form
    {
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;");
        Menu m;
        public WHStock(Menu m)
        {
            InitializeComponent();
            this.m = m;
            ReloadStock();
        }

        private void WHStock_Load(object sender, EventArgs e)
        {

        }

        private void ReloadStock()
        {
            cnn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT WarehouseStock_new.ItemID, ItemName, ItemDescription, quantity FROM WarehouseStock_new, Item WHERE WarehouseStock_new.ItemID=Item.ItemID;", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dGVItem.DataSource = dt;
            cnn.Close();

            MySqlDataAdapter sda2 = new MySqlDataAdapter("SELECT ItemID, ItemDescription FROM Item WHERE ItemID NOT IN (SELECT ItemID From WarehouseStock_new);", cnn);
            Dictionary<String, String> comboSource = new Dictionary<String, String>();
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            if (dt2.Rows.Count < 1)
            {
                cbAddItem.Text = "All item have been added into the stock.";
                cbAddItem.Enabled = false;
                btnAdd.Enabled = false;
            }
            else
            {
                int i = 1;
                foreach (DataRow dr in dt2.Rows)
                {
                    String itemInfo = dr["ItemID"].ToString() + " - " + dr["ItemDescription"].ToString();
                    comboSource.Add(i++.ToString(), itemInfo);
                }
                cbAddItem.DataSource = new BindingSource(comboSource, null);
                cbAddItem.DisplayMember = "Value";
                cbAddItem.ValueMember = "Key";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dGVItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbEditItem.Text = dGVItem.Rows[e.RowIndex].Cells["ItemID"].Value.ToString();
            numEditQty.Value = Convert.ToDecimal(dGVItem.Rows[e.RowIndex].Cells["quantity"].Value.ToString());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbEditItem.Text))
            {
                MessageBox.Show("You must select a item", "Select a Item !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(numEditQty.Text) || numEditQty.Value < 0)
            {
                MessageBox.Show("You must input at least 0", "Check your input !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MySqlCommand command = new MySqlCommand("UPDATE WarehouseStock_new SET quantity = '" + numEditQty.Value.ToString() + "' WHERE ItemID = '" + tbEditItem.Text.ToString() + "';", cnn);
                cnn.Open();
                command.ExecuteNonQuery();
                cnn.Close();            
                MessageBox.Show("Update Success!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ReloadStock();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numAddQty.Text))
            {
                MessageBox.Show("You must select a item", "Select a Item !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(numEditQty.Text) || numEditQty.Value < 0)
            {
                MessageBox.Show("You must input at least 0", "Check your input !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String itemId = this.cbAddItem.GetItemText(this.cbAddItem.SelectedItem).Substring(0,8);
                MySqlCommand command = cnn.CreateCommand();
                command.CommandText = "insert into WarehouseStock_new values('" + itemId + "','" + numAddQty.Value.ToString() + "');";
                cnn.Open();
                command.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Create Success!", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ReloadStock();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MySqlCommand del = new MySqlCommand("Delete from WarehouseStock_new where ItemID = '" + tbEditItem.Text.ToString() + "'", cnn);
            cnn.Open();
            del.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Delete Success!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReloadStock();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            m.Show();
        }
    }
}
