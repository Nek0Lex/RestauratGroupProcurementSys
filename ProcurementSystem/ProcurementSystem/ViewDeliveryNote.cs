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
    public partial class ViewDeliveryNote : Form
    {
        private String DNId;
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
        public ViewDeliveryNote(String DNId)
        {
            InitializeComponent();
            this.DNId = DNId;
            cnn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT DN.ItemID, ItemName, ItemDescription, Quantity, Quantity as Arrived FROM DeliveryNote DN, Item I WHERE DN.ItemID=I.ItemID and DeliveryID = '" + DNId+ "';", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dGVItem.DataSource = dt;
            cnn.Close();
        }

        private void ViewDeliveryNote_Load(object sender, EventArgs e)
        {

        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            cnn.Open();
            int completedCount=0, rowCount=0;
            String status = "DNC";
            foreach (DataGridViewRow row in dGVItem.Rows)
            {
                int qty = Convert.ToInt32(row.Cells["Quantity"].Value);
                int arrivedQty = Convert.ToInt32(row.Cells["Arrived"].Value);
                String itemID = Convert.ToString(row.Cells["ItemID"].Value);
                MySqlCommand updateDN = new MySqlCommand("Update DeliveryNote SET ArrivedQty = '"+arrivedQty + "' WHERE ItemID = '" + itemID + "' and DeliveryID = '" + DNId + "';", cnn);
                updateDN.ExecuteNonQuery();
                if (qty <= arrivedQty)
                    completedCount++;
                rowCount++;
            }
            if (completedCount == rowCount)
                status = "COM";
            MySqlCommand updateStatus = new MySqlCommand("Update DeliveryNote SET Status = '" + status + "' WHERE DeliveryID = '" + DNId + "';", cnn);
            updateStatus.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
