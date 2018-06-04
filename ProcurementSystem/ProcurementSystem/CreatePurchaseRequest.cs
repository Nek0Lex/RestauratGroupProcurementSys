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
using System.Text.RegularExpressions;

namespace ProcurementSystem
{
    public partial class CreatePurchaseRequest : Form
    {
        private PurchaseRequest pr;
        private string nowRequestNo;
        private DateTime today = DateTime.Now;
        private int quantity;
        private string staffNo;
        private string restNo;

        MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;");
        public CreatePurchaseRequest(PurchaseRequest pr, string staffNo, string restNo, string staffName, string restName)
        {
            cnn.Open();
            InitializeComponent();
            this.pr = pr;
            StfId.Text = staffNo;
            StfName.Text = staffName;
            RestId.Text = restNo;
            RestName.Text = restName;
            this.restNo = restNo;
            this.staffNo = staffNo;
            MySqlCommand getNextRequestNo = new MySqlCommand("SELECT MAX(RequestNo) FROM PurchaseRequest",cnn);
            nowRequestNo =(string) getNextRequestNo.ExecuteScalar();
            if (nowRequestNo == null)
            {
                nowRequestNo = "00000000";
            }
            else
            {
                nowRequestNo = Regex.Match(nowRequestNo, @"\d+").Value;
            }
            int num = Int32.Parse(nowRequestNo);
            num++;
            nowRequestNo = num.ToString().PadLeft(8, '0');
            CreateDate.Text = today.ToString("yyyy-MM-dd");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string selectItem = this.itemList.Text;
                Boolean qtnNull = int.TryParse(qtn.Text,out quantity);
                if ((quantity <= 0)||(qtnNull ==false))
                {
                    errorMsg.Text = "Check Your Input!";
                }
                else
                {
                    if (selectItem == "Fishball") {
                        purchaseList2.Rows.Add(selectItem, quantity, "000001");
                    }
                    else if (selectItem == "CurrySauce")
                    {
                        purchaseList2.Rows.Add(selectItem, quantity, "000002");
                    }
                    errorMsg.Text = "";
                }
            }
            catch (EntryPointNotFoundException ex) {
                errorMsg.Text = "Something Wrong";
            }
        }

        private void Create_Purchase_Order_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            pr.Show();
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in purchaseList2.SelectedRows)
                {
                    purchaseList2.Rows.Remove(row);
                }
            }
            catch (Exception ex) { }
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MySqlCommand add;
            uint qtnToInt;
 
            for(int i=0; i<purchaseList2.RowCount; i++)
            {
                try
                {
                    if (purchaseList2.Rows[i].Cells[0] != null)
                    {
                        qtnToInt = Convert.ToUInt32(purchaseList2.Rows[i].Cells[1].Value.ToString());
                        add = new MySqlCommand("INSERT INTO PurchaseRequest (RequestNo, CreationDate, Quantity, status, VItemID, Hierarchy, StaffNo, RestNo) Value ('" + nowRequestNo + "', '" + today.ToString("yyyy-MM-dd") + "', " + qtnToInt + ", 'NEW', '" + purchaseList2.Rows[i].Cells[2].Value.ToString() + "', 'Chinese', '" + staffNo + "', '" + restNo + "');", cnn);
                        add.ExecuteNonQuery();
                    }
                }
                catch (Exception ex) { }
            }
                this.Close();
                pr.Refresh();
                pr.Show();
        }
    }
}
