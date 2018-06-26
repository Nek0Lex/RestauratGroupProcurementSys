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
    public partial class WHGenerateDN : Form
    {
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;");
        String iId;
        int[] maxQty;
        public WHGenerateDN(String iId)
        {
            InitializeComponent();
            this.iId = iId;
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT Distinct DI.ItemID, ItemName,ItemDescription, DI.quantity, S.quantity as Stock FROM DespatchInstruction DI, WarehouseStock_new S, Item I WHERE DI.ItemID=I.ItemID and DI.ItemID=S.ItemID and DesID = '"+iId+"';", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dGVItem.DataSource = dt;
            cnn.Close();
            int i = 0;
            maxQty = new int[dGVItem.RowCount];
            foreach (DataGridViewRow row in dGVItem.Rows)
            {
                int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
                String itemID = Convert.ToString(row.Cells["ItemID"].Value);
                cnn.Open();
                MySqlCommand getQuantity = new MySqlCommand("Select quantity from DespatchInstruction WHERE ItemID = '" + itemID + "' and DesID = '" + iId + "';", cnn);
                maxQty[i] = Convert.ToInt32(getQuantity.ExecuteScalar());
                cnn.Close();
                i++;
            }
        }

        private void WHGenerateDN_Load(object sender, EventArgs e)
        {

        }

        private void dGVItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            numQty.Maximum = maxQty[e.RowIndex];
            numQty.Value = Convert.ToDecimal(dGVItem.Rows[e.RowIndex].Cells["quantity"].Value.ToString());
            lbMax.Text = numQty.Maximum.ToString();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            int rowCount = 0, finishedCount = 0;
            foreach (DataGridViewRow row in dGVItem.Rows)
            {
                int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
                String itemID = Convert.ToString(row.Cells["ItemID"].Value);
                cnn.Open();                   

                MySqlCommand command = new MySqlCommand("UPDATE DespatchInstruction SET quantity = '" + (maxQty[rowCount] - quantity) + "' WHERE ItemID = '" + itemID + "' and DesID = '" + iId + "';", cnn);
                command.ExecuteNonQuery();

                MySqlCommand updateStock = new MySqlCommand("UPDATE WarehouseStock_new SET quantity = quantity - " + quantity + " WHERE ItemID = '" + itemID + "';", cnn);
                updateStock.ExecuteNonQuery();
                cnn.Close();

                if (maxQty[rowCount] == quantity)
                    finishedCount++;
                rowCount++;
            }
            if (finishedCount == rowCount)
            {
                MySqlCommand command = new MySqlCommand("UPDATE DespatchInstruction SET status = 'FIN' WHERE DesID = '" + iId + "';", cnn);
                cnn.Open();
                command.ExecuteNonQuery();
                cnn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dGVItem.SelectedRows.Count < 0)
            {
                MessageBox.Show("You must select a item", "Select a Item !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(numQty.Text))
            {
                MessageBox.Show("You must input at least 0", "Check your input !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dGVItem.SelectedRows[0].Cells["quantity"].Value = numQty.Value.ToString();
;            }
        }
    }
}
