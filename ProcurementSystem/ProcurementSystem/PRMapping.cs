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
    public partial class PRMapping : Form
    {
        private Menu m;
        private BPAAdd BPAadd;
        private string selectedRequest;
        private string nowBPANo;
        private string finalGenRequestList;
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;");
        public PRMapping(Menu m)
        {
            InitializeComponent();
            this.m = m;
            cnn.Open();
            MySqlDataAdapter findRequestList = new MySqlDataAdapter("Select RequestNo, CreationDate From PurchaseRequest where status='NEW' Group BY RequestNo;", cnn);
            DataTable dt = new DataTable();
            findRequestList.Fill(dt);
            foreach (DataRow dr in dt.Rows) {
                requestList.Rows.Add(dr["RequestNo"].ToString(), Convert.ToDateTime(dr["CreationDate"]).ToString("dd-MM-yyyy"));
            }
            MySqlCommand getNextRequestNo = new MySqlCommand("SELECT MAX(BPANo) FROM BlanketPurchaseAgreement", cnn);
            nowBPANo = (string)getNextRequestNo.ExecuteScalar();
            if (nowBPANo == null)
            {
                nowBPANo = "BPA00000";
            }
            else
            {
                nowBPANo = Regex.Match(nowBPANo, @"\d+").Value;
            }
            int num = Int32.Parse(nowBPANo.GetLast(5));
            num++;
            nowBPANo =num.ToString().PadLeft(5, '0');
            nowBPANo = "BPA" + nowBPANo;
        }
            private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            m.Show();
        }

        private void itemList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void requestList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            itemList.Rows.Clear();
            int i;
            i = requestList.SelectedCells[0].RowIndex;
            selectedRequest = tbRequestID.Text = requestList.Rows[i].Cells[0].Value.ToString();
            MySqlDataAdapter item = new MySqlDataAdapter("SELECT i.ItemName, pr.Quantity FROM VItem v,Item i ,Category c,PurchaseRequest pr WHERE v.category_id = c.category_id AND v.ItemID = i.ItemID AND pr.VItemID = v.VItemID AND pr.category_id = v.category_id AND pr.RequestNo = '" + selectedRequest + "';", cnn);
            DataTable dt2 = new DataTable();
            item.Fill(dt2);
            foreach (DataRow dr in dt2.Rows)
            {
                 itemList.Rows.Add(dr["itemName"].ToString(), dr["Quantity"].ToString());
            }
            itemList.Refresh();
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            string checkItem;
            int addedItemQty;
            Boolean added = false;
            foreach(DataGridViewRow row in itemList.Rows) {
                foreach (DataGridViewRow row2 in GenItemList.Rows) {
                    if (row2.Cells[0].Value != null)
                    {
                        checkItem = row2.Cells[0].Value.ToString();
                        if (row.Cells[0].Value.ToString() == checkItem)
                        {
                            addedItemQty = int.Parse(row2.Cells[1].Value.ToString()) + int.Parse(row.Cells[1].Value.ToString());
                            row2.Cells[1].Value = addedItemQty.ToString();
                            added = true;
                        }
                    }
                }
                if(added == false) {
                    GenItemList.Rows.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
                }
                if (finalGenRequestList != null)
                    finalGenRequestList = finalGenRequestList + ", " + tbRequestID.Text.ToString();
                else
                    finalGenRequestList += tbRequestID.Text.ToString();
                added = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                BPAadd = new BPAAdd(nowBPANo, finalGenRequestList);
                BPAadd.ShowDialog();
                this.reset();
            }
        }
        public void reset() {
            tbRequestID.Text = "";
            itemList.Rows.Clear();
            GenItemList.Rows.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            this.Refresh();
        }
    }
    public static class StringExtension
    {
        public static string GetLast(this string source, int tail_length)
        {
            if (tail_length >= source.Length)
                return source;
            return source.Substring(source.Length - tail_length);
        }
    }
}
