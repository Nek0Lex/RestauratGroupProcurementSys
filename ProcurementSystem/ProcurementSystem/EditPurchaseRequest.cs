using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProcurementSystem
{
    public partial class EditPurchaseRequest : Form
    {
        private string staffNo;
        private string restNo;
        private int quantity;
        private string restHierarchy;
        private string selectedRequest;
        private DateTime createDate;
        private PurchaseRequest pr;
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;");
        public EditPurchaseRequest(PurchaseRequest pr, string staffNo, string restNo, string staffName, string restName, string selectedRequest, string createDate)
        {
            cnn.Open();
            InitializeComponent();
            StfId.Text = staffNo;
            StfName.Text = staffName;
            RestId.Text = restNo;
            RestName.Text = restName;
            CreateDate.Text = createDate.Substring(0,10);
            this.createDate = DateTime.Parse(createDate);
            this.selectedRequest = selectedRequest;
            this.restNo = restNo;
            this.staffNo = staffNo;
            title.Text = "Purchase Request " + selectedRequest;
            MySqlDataAdapter showList = new MySqlDataAdapter("SELECT i.ItemName, pr.Quantity, v.VItemID, c.category_id FROM VItem v,Item i ,Category c,PurchaseRequest pr WHERE v.category_id = c.category_id AND v.ItemID = i.ItemID AND pr.VItemID = v.VItemID AND pr.category_id = v.category_id AND pr.RequestNo = '"+ selectedRequest+ "';",cnn);
            DataTable dt = new DataTable();
            showList.Fill(dt);
            foreach (DataRow dr in dt.Rows) {
                purchaseList2.Rows.Add(dr["itemName"].ToString(), dr["Quantity"].ToString(), dr["VItemID"].ToString(), dr["Category_id"].ToString());
            }

            MySqlCommand getRestaurantHierarchy = new MySqlCommand("SELECT Hierarchy FROM Restaurant WHERE RestNo = '" + restNo + "';", cnn);
            restHierarchy = (string)getRestaurantHierarchy.ExecuteScalar();

            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT i.ItemName FROM VItem v,Item i ,Category c WHERE v.category_id = c.category_id AND v.ItemID = i.ItemID AND c.name = '" + restHierarchy + "'; ", cnn);
            DataTable dt2 = new DataTable();
            sda.Fill(dt2);
            foreach (DataRow dr in dt2.Rows)
            {
                itemList.Items.Add(dr["ItemName"].ToString());
            }
            this.pr = pr;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            pr.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            errorMsg.Text = "";
            try
            {
                string selectItem = this.itemList.Text;
                //new
                MySqlCommand getVItemID = new MySqlCommand("SELECT v.VItemID FROM VItem v,Item i ,Category c WHERE v.category_id = c.category_id AND v.ItemID = i.ItemID AND c.name ='" + restHierarchy + "' AND i.ItemName = '" + selectItem + "';", cnn);
                string VItemID = (string)getVItemID.ExecuteScalar();
                MySqlCommand getCategory_id = new MySqlCommand("SELECT v.category_id FROM VItem v,Item i ,Category c WHERE v.category_id = c.category_id AND v.ItemID = i.ItemID AND c.name ='" + restHierarchy + "' AND i.ItemName = '" + selectItem + "';", cnn);
                string category_id = getCategory_id.ExecuteScalar().ToString();
                //
                Boolean qtnNull = int.TryParse(qtn.Text, out quantity);
                Boolean haveItem = false;
                for (int i = 0; i < purchaseList2.RowCount - 1; i++)
                {
                    if (purchaseList2.Rows[i].Cells[0].Value.ToString() == selectItem)
                    {
                        haveItem = true;
                    }
                }
                if (haveItem)
                {
                    errorMsg.Text = "Item is already in the list";
                }
                else
                if ((quantity <= 0) || (qtnNull == false))
                {
                    errorMsg.Text = "Check Your Input!";
                }
                else
                {
                    purchaseList2.Rows.Add(selectItem, quantity, VItemID, category_id);
                    errorMsg.Text = "";
                }
            }
            catch (EntryPointNotFoundException ex)
            {
                errorMsg.Text = "Something Wrong";
            }
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            errorMsg.Text = "";
            try
            {
                foreach (DataGridViewRow row in purchaseList2.SelectedRows)
                {
                    purchaseList2.Rows.Remove(row);
                }
            }
            catch (Exception ex) { }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            if (purchaseList2.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("No item has been added into the list");
            }
            else
            {
                MySqlCommand delOld = new MySqlCommand("delete from PurchaseRequest where RequestNo ='" + selectedRequest + "';", cnn);
                delOld.ExecuteNonQuery();
                for (int i = 0; i < purchaseList2.RowCount - 1; i++)
                {
                    try
                    {
                        if (purchaseList2.Rows[i].Cells[0] != null)
                        {
                            MySqlCommand add = new MySqlCommand("INSERT INTO PurchaseRequest (RequestNo, CreationDate, Quantity, status, VItemID, category_id, StaffNo, RestNo) Value ('" + selectedRequest + "', '" + createDate.ToString("yyyy-MM-dd") + "', " + purchaseList2.Rows[i].Cells[1].Value.ToString() + ", 'NEW', '" + purchaseList2.Rows[i].Cells[2].Value + "', " + purchaseList2.Rows[i].Cells[3].Value + ", '" + staffNo + "', '" + restNo + "');", cnn);
                            add.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                this.Close();
                pr.Show();
            }
        }
    }
}
