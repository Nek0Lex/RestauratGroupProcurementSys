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
        private string[,] itemTable = new string[1000, 2];
        private int nextItemPlace = 0;
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
                    string addMsg = "Item : " + selectItem + " Quantity : " + quantity;
                    purchaseList.Items.Insert(0, addMsg);
                    if (selectItem == "Fishball") {
                        itemTable[nextItemPlace, 0] = "000001";
                    }else if (selectItem == "CurrySauce")
                    {
                        itemTable[nextItemPlace, 0] = "000002";
                    }
                    itemTable[nextItemPlace, 1] = quantity.ToString();
                    nextItemPlace++;
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
                for (int i = 0; i <= purchaseList.Items.Count; i++)
                {
                    if (purchaseList.GetItemChecked(i))
                        purchaseList.Items.RemoveAt(i);
                }
            }
            catch (Exception ex) {

            }

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MySqlCommand add;
            Boolean haveCreate = false;
            for(int i=0; i<1000; i++)
            {
                if(itemTable[i, 0] == null)
                {
                    continue;
                }
                else
                {
                    add = new MySqlCommand("INSERT INTO PurchaseRequest (RequestNo, CreationDate, Quantity, status, VItemID, Hierarchy, StaffNo, RestNo) Value ('"+nowRequestNo+"', '"+ today.ToString("yyyy-MM-dd") + "', "+itemTable[i, 1]+", 'NEW', '"+itemTable[i, 0]+"', 'Chinese', '"+staffNo+"', '"+restNo+"');",cnn);
                    add.ExecuteNonQuery();
                    haveCreate = true;
                }
            }
            if (haveCreate)
            {
                this.Close();
                pr.Refresh();
                pr.Show();
            }
        }
    }
}
