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
    public partial class RMConfirmDN : Form
    {
        private String DNId, status, rno;
        private ViewDeliveryNoteMenu m;
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
        public RMConfirmDN(ViewDeliveryNoteMenu m, String DNId, String status)
        {
            InitializeComponent();
            this.m = m;
            this.DNId = DNId;
            this.status = status;
            cnn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT DN.ItemID, ItemName, ItemDescription, Quantity, Quantity as Arrived FROM DeliveryNote DN, Item I WHERE DN.ItemID=I.ItemID and DeliveryID = '" + DNId + "';", cnn);
            if (status.Equals("COM") || status.Equals("DNC"))
            {
                btnGen.Enabled = false;
                sda = new MySqlDataAdapter("SELECT DN.ItemID, ItemName, ItemDescription, Quantity, ArrivedQty as Arrived FROM DeliveryNote DN, Item I WHERE DN.ItemID=I.ItemID and DeliveryID = '" + DNId + "';", cnn);
            }
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dGVItem.DataSource = dt;
            MySqlDataAdapter getDNInfo = new MySqlDataAdapter("SELECT DeliveryID, dn.RequestNo, DesID, dn.CreationDate, DeliveryDate From DeliveryNote dn, PurchaseRequest pr Where dn.RequestNo=pr.RequestNo and DeliveryID = '" +DNId + "';", cnn);
            DataTable DNInfo = new DataTable();
            getDNInfo.Fill(DNInfo);            
            cnn.Close();
            lbDID.Text = DNInfo.Rows[0][0].ToString();
            lbRNo.Text = DNInfo.Rows[0][1].ToString();
            lbDesId.Text = DNInfo.Rows[0][2].ToString();
            lbCreationDate.Text = Convert.ToDateTime(DNInfo.Rows[0][3]).ToString("dd-MM-yyyy");
            lbDeliveryDate.Text = Convert.ToDateTime(DNInfo.Rows[0][4]).ToString("dd-MM-yyyy");
            lbStatus.Text = status;
            rno = lbRNo.Text;
            btnUpdate.Enabled = false;      
        }

        private void ViewDeliveryNote_Load(object sender, EventArgs e)
        {

        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            cnn.Open();
            int completedCount = 0, rowCount = 0;
            String status = "DNC";
            foreach (DataGridViewRow row in dGVItem.Rows)
            {
                int qty = Convert.ToInt32(row.Cells["Quantity"].Value);
                int arrivedQty = Convert.ToInt32(row.Cells["Arrived"].Value);
                String itemID = Convert.ToString(row.Cells["ItemID"].Value);
                MySqlCommand updateDN = new MySqlCommand("Update DeliveryNote SET ArrivedQty = '" + arrivedQty + "' WHERE ItemID = '" + itemID + "' and DeliveryID = '" + DNId + "';", cnn);
                updateDN.ExecuteNonQuery();
                if (qty <= arrivedQty)
                    completedCount++;
                rowCount++;
            }
            if (completedCount == rowCount)
                status = "COM";
            MySqlCommand updateStatus = new MySqlCommand("Update DeliveryNote SET Status = '" + status + "' WHERE DeliveryID = '" + DNId + "';", cnn);
            updateStatus.ExecuteNonQuery();
            if (status.Equals("COM"))
                MessageBox.Show("Delivery Completed !", "Confirm Successfully !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (status.Equals("DNC"))
                MessageBox.Show("Delivery Completed with not correct amount", "Confirm Successfully !", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Check DB for updating PR status
            MySqlCommand getCOMDN = new MySqlCommand("select count(RequestNo) from DeliveryNote where Status in ('COM','DNC','CAN') and RequestNo = '" + rno + "';", cnn);
            MySqlCommand getTotalDN = new MySqlCommand("select count(DeliveryID) from DeliveryNote where RequestNo = '" + rno + "';", cnn);
            MySqlCommand getFINDI = new MySqlCommand("select count(DesID) from DespatchInstruction where RequestNo = '" + rno + "' and Status = 'FIN'; ", cnn);
            MySqlCommand getTotalDI = new MySqlCommand("select count(DesID) from DespatchInstruction where RequestNo = '"+rno+"'; ", cnn);
            int COMDN = Convert.ToInt32(getCOMDN.ExecuteScalar());
            int TotalDN = Convert.ToInt32(getTotalDN.ExecuteScalar());
            int FINDI = Convert.ToInt32(getFINDI.ExecuteScalar());
            int TotalDI = Convert.ToInt32(getTotalDI.ExecuteScalar());
            if ((COMDN == TotalDN) && (FINDI == TotalDI))
            {
                MySqlCommand updatePRStatus = new MySqlCommand("Update PurchaseRequest SET Status = 'COM' WHERE RequestNo = '" + rno + "';", cnn);
                updatePRStatus.ExecuteNonQuery();
            }

            cnn.Close();
            m.loadData();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
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
                dGVItem.SelectedRows[0].Cells["Arrived"].Value = numQty.Value.ToString();
            }
        }

        private void dGVItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            numQty.Value = Convert.ToDecimal(dGVItem.Rows[e.RowIndex].Cells["Arrived"].Value.ToString());
            btnUpdate.Enabled = true;
        }
    }
}
