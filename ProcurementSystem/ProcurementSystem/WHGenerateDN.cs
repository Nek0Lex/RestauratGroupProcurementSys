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
using System.Text.RegularExpressions;

namespace ProcurementSystem
{
    public partial class WHGenerateDN : Form
    {
        private DateTime today = DateTime.Now;
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;");
        String iId, rno, status, rest;
        int[] maxQty, stock;
        public WHGenerateDN(String iId, String rno, String status)
        {
            InitializeComponent();
            this.iId = iId;
            this.rno = rno;
            cnn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT Distinct DI.ItemID, ItemName,ItemDescription, DI.quantity as Needs, DI.quantity, S.quantity as Stock FROM DespatchInstruction DI, WarehouseStock_new S, Item I WHERE DI.ItemID=I.ItemID and DI.ItemID=S.ItemID and DesID = '" + iId+"';", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dGVItem.DataSource = dt; 
            int i = 0;
            maxQty = new int[dGVItem.RowCount];
            stock = new int[dGVItem.RowCount];
            foreach (DataGridViewRow row in dGVItem.Rows)
            {
                int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
                String itemID = Convert.ToString(row.Cells["ItemID"].Value);
                stock[i] = Convert.ToInt32(row.Cells["Stock"].Value);
                MySqlCommand getQuantity = new MySqlCommand("Select quantity from DespatchInstruction WHERE ItemID = '" + itemID + "' and DesID = '" + iId + "';", cnn);
                maxQty[i] = Convert.ToInt32(getQuantity.ExecuteScalar());
                if (quantity > stock[i])
                    row.Cells["quantity"].Value = stock[i];
                i++;
            }
            MySqlDataAdapter getDID = new MySqlDataAdapter("select Distinct Max(DeliveryID) from DeliveryNote;", cnn);
            DataTable dt2 = new DataTable();
            if (status.Equals("FIN"))
            {
                btnGen.Enabled = false;
                lbDID.Text = "";
                MySqlDataAdapter getDeliveryID = new MySqlDataAdapter("Select DeliveryID from DeliveryNote WHERE DesID = '" + iId + "';", cnn);
                DataTable dt3 = new DataTable();
                getDeliveryID.Fill(dt3);
                foreach (DataRow dr in dt3.Rows)
                    lbDID.Text += Convert.ToString(dr[0]) + ", ";
            }
            else
            {
                String did;
                 getDID.Fill(dt2);
                did = dt2.Rows[0][0].ToString();
                if (did.Equals(""))
                    did = "0";
                did = Regex.Match(did, @"\d+").Value;
                lbDID.Text = "D" + (Int32.Parse(did) + 1).ToString().PadLeft(7, '0');
            }
            MySqlDataAdapter getRest = new MySqlDataAdapter("Select RestName, RestAddress From PurchaseRequest pr, Restaurant r where RequestNo = '" + rno + "' and pr.restNo=r.restNo;", cnn);
            DataTable restInfo = new DataTable();
            getRest.Fill(restInfo);
            numQty.Maximum = 0;
            lbRName.Text = restInfo.Rows[0][0].ToString();
            lbAddress.Text = restInfo.Rows[0][1].ToString();
            lbCreationDate.Text = today.ToString("yyyy-MM-dd");
            lbStatus.Text = status;
            lbDesId.Text = iId;
            lbRNo.Text = rno;
            cnn.Close();
        }

        private void WHGenerateDN_Load(object sender, EventArgs e)
        {

        }

        private void dGVItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (maxQty[e.RowIndex] < stock[e.RowIndex])
            {
                numQty.Maximum = maxQty[e.RowIndex];
                numQty.Value = Convert.ToDecimal(dGVItem.Rows[e.RowIndex].Cells["quantity"].Value.ToString());
                lbMax.Text = numQty.Maximum.ToString();
            }
            else
            {
                numQty.Maximum = stock[e.RowIndex];
                numQty.Value = Convert.ToDecimal(dGVItem.Rows[e.RowIndex].Cells["quantity"].Value.ToString());
                if (numQty.Value < stock[e.RowIndex])
                    lbMax.Text = numQty.Maximum.ToString();
                else
                    lbMax.Text = stock[e.RowIndex].ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
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

                MySqlCommand updatePR = new MySqlCommand("UPDATE PurchaseRequest SET deliveryDate = '" + today.ToString("yyyy-MM-dd") + "' WHERE requestNo = '" + rno + "';", cnn);
                updateStock.ExecuteNonQuery();

                try
                {
                    if (quantity != 0)
                    {
                        MySqlCommand createDeliveryNote = new MySqlCommand("INSERT INTO DeliveryNote VALUES ('" + lbDID.Text + "','" + lbRNo.Text + "','" + lbDesId.Text + "','" + itemID +
                            "'," + quantity + ", '', 'Bus','" + lbCreationDate.Text + "','DLI');", cnn);
                        createDeliveryNote.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex) { };
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
            MessageBox.Show("Create Success!", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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
