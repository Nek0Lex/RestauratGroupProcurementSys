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
        private string selectedRequest;
        private string nowDesNo;
        private string nowSPONo;
        private string nowBPRNo;
        public Boolean checkCancel = false;
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;");
        public PRMapping(Menu m)
        {
            InitializeComponent();
            this.m = m;
            cnn.Open();
            MySqlDataAdapter findRequestList = new MySqlDataAdapter("Select RequestNo, CreationDate, Status From PurchaseRequest where status='NEW' or status='FAI' Group BY RequestNo;", cnn);
            DataTable dt = new DataTable();
            findRequestList.Fill(dt);
            foreach (DataRow dr in dt.Rows) {
                requestList.Rows.Add(dr["RequestNo"].ToString(), Convert.ToDateTime(dr["CreationDate"]).ToString("dd-MM-yyyy"), dr["Status"].ToString());
            }
            
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
            MySqlDataAdapter item = new MySqlDataAdapter("SELECT i.ItemDescription, pr.Quantity, pr.VItemID, pr.category_id FROM VItem v,Item i ,Category c,PurchaseRequest pr WHERE v.category_id = c.category_id AND v.ItemID = i.ItemID AND pr.VItemID = v.VItemID AND pr.category_id = v.category_id AND pr.RequestNo = '" + selectedRequest + "' AND (pr.Status = 'NEW' OR pr.Status ='FAI');", cnn);
            DataTable dt2 = new DataTable();
            item.Fill(dt2);
            foreach (DataRow dr in dt2.Rows)
            {
                 itemList.Rows.Add(dr["itemDescription"].ToString(), dr["Quantity"].ToString(), dr["VItemID"].ToString(), dr["category_id"].ToString());
            }
            foreach (DataGridViewRow row in itemList.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    try
                    {
                        MySqlCommand getStock = new MySqlCommand("SELECT quantity from WarehouseStock w, Item i WHERE w.ItemID = i. ItemID AND i.ItemDescription = '" + row.Cells[0].Value.ToString() + "'", cnn);
                        row.Cells[4].Value = getStock.ExecuteScalar().ToString();
                        if (row.Cells[4].Value.ToString() == "")
                        {
                            row.Cells[4].Value = "0";
                        }
                    }
                    catch (NullReferenceException)
                    {
                        row.Cells[4].Value = "0";
                    }
                    try
                    {
                        MySqlCommand getPPO = new MySqlCommand("SELECT p.Quantity, MAX(PPONo) from PPOLines p WHERE p.ItemDescription  ='" + row.Cells[0].Value.ToString() + "'", cnn);
                        row.Cells[5].Value = getPPO.ExecuteScalar().ToString();
                        if (row.Cells[5].Value.ToString() == "")
                        {
                            row.Cells[5].Value = "0";
                        }
                    }
                    catch (NullReferenceException exe)
                    {
                        row.Cells[5].Value = "0";
                    }
                    try
                    {
                        MySqlCommand getBPA = new MySqlCommand("SELECT b.PromisedQuantity, MAX(BPANo) from BPALines b, Item i WHERE b.ItemID = i.ItemID AND i.ItemDescription ='" + row.Cells[0].Value.ToString() + "'", cnn);
                        row.Cells[6].Value = getBPA.ExecuteScalar().ToString();
                        if(row.Cells[6].Value.ToString() == "")
                        {
                            row.Cells[6].Value = "0";
                        }
                    }
                    catch (NullReferenceException ex)
                    {
                        row.Cells[6].Value = "0";
                    }
                }
            }
            itemList.Refresh();
        }

        //private void addItem_Click(object sender, EventArgs e)
        //{
        //    string checkItem;
        //    int addedItemQty;
        //    Boolean added = false;
        //    foreach(DataGridViewRow row in itemList.Rows) {
        //        foreach (DataGridViewRow row2 in GenItemList.Rows) {
        //            if (row2.Cells[0].Value != null)
        //            {
        //                checkItem = row2.Cells[0].Value.ToString();
        //                if (row.Cells[0].Value.ToString() == checkItem)
        //                {
        //                    addedItemQty = int.Parse(row2.Cells[1].Value.ToString()) + int.Parse(row.Cells[1].Value.ToString());
        //                    row2.Cells[1].Value = addedItemQty.ToString();
        //                    row2.Cells[3].Value = row2.Cells[3].Value + ", " + tbRequestID.Text.ToString();
        //                    added = true;
        //                }
        //            }
        //        }
        //        if(added == false) {
        //            MySqlCommand getSuppier = new MySqlCommand("SELECT s.SupplierName From Supplier s, SupplierItem si, VItem v,Item i ,Category c WHERE v.category_id = c.category_id AND v.ItemID = i.ItemID AND v.ItemID = si.ItemID AND si.SupplierNo = s.SupplierNo AND v.VitemID ='"+row.Cells[2].Value.ToString()+"' AND v.category_id ='"+row.Cells[3].Value.ToString()+"'", cnn);
        //            GenItemList.Rows.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), getSuppier.ExecuteScalar().ToString(), tbRequestID.Text.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString());
        //        }
        //        added = false;
        //    }
            
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (int.Parse(itemList.Rows[0].Cells[1].Value.ToString()) - int.Parse(itemList.Rows[0].Cells[6].Value.ToString()) > 0)
                {
                    MessageBox.Show("Not a Valid BPA!");
                }
                else
                {
                    string restNo;
                    MySqlCommand getBPANo = new MySqlCommand("SELECT MAX(BPANo) from BPALines b, Item i WHERE b.ItemID = i.ItemID AND i.ItemDescription ='" + itemList.Rows[0].Cells[0].Value.ToString() + "'", cnn);
                    string bprBPANo = getBPANo.ExecuteScalar().ToString();
                    MySqlCommand getNextRequestNo = new MySqlCommand("SELECT MAX(ReleaseNo) FROM BlanketPurchaseRelease", cnn);
                    nowBPRNo = getNextRequestNo.ExecuteScalar().ToString();
                    if (nowBPRNo == "")
                    {
                        nowBPRNo = "RE0000";
                    }
                    else
                    {
                        nowBPRNo = Regex.Match(nowBPRNo, @"\d+").Value;
                    }
                    int num = int.Parse(nowBPRNo.GetLast(4));
                    num++;
                    nowBPRNo = num.ToString().PadLeft(4, '0');
                    nowBPRNo = "RE" + nowBPRNo;
                    MySqlCommand getRestNo = new MySqlCommand("Select DISTINCT RestNo FROM PurchaseRequest WHERE RequestNo = '" + tbRequestID.Text + "'", cnn);
                    restNo = getRestNo.ExecuteScalar().ToString();
                    BlanketPurchaseRelease BPR = new BlanketPurchaseRelease(bprBPANo, nowBPRNo, restNo, itemList.Rows[0].Cells[0].Value.ToString(), itemList.Rows[0].Cells[1].Value.ToString(), tbRequestID.Text);
                    BPR.ShowDialog();
                }
                //handlingItem = new List<string>();
                //handlingItemQty = new List<string>();
                //handlingRequest = new List<string>();
                //MySqlCommand getNextRequestNo = new MySqlCommand("SELECT MAX(BPANo) FROM BlanketPurchaseAgreement", cnn);
                //nowBPANo = (string)getNextRequestNo.ExecuteScalar();
                //if (nowBPANo == null)
                //{
                //    nowBPANo = "00000";
                //}
                //else
                //{
                //    nowBPANo = Regex.Match(nowBPANo, @"\d+").Value;
                //}
                //int num = Int32.Parse(nowBPANo.GetLast(5));
                //num++;
                //nowBPANo = num.ToString().PadLeft(5, '0');
                //string supplierID="";
                //foreach (DataGridViewRow row in GenItemList.Rows)
                //{
                //    MySqlCommand getSupplierID = new MySqlCommand("SELECT SupplierNo FROM Supplier WHERE supplierName ='" + row.Cells[2].Value.ToString() + "';", cnn);
                //    supplierID = getSupplierID.ExecuteScalar().ToString();
                //    if (handlingSupplier == null && row.Cells[0].Value != null)
                //    {
                //        handlingSupplier = row.Cells[2].Value.ToString();
                //        handlingItem.Add(row.Cells[0].Value.ToString());
                //        handlingItemQty.Add(row.Cells[1].Value.ToString());
                //        handlingRequest = checkrepeatRequest(handlingRequest, row.Cells[3].Value.ToString());

                //        GenItemList.Rows.RemoveAt(row.Index);
                //    }
                //    else if(handlingSupplier == row.Cells[2].Value.ToString()){
                //        handlingRequest = checkrepeatRequest(handlingRequest, row.Cells[3].Value.ToString());
                //        GenItemList.Rows.RemoveAt(row.Index);
                //    }
                //}
                //BPAadd = new BPAAdd(this, nowBPANo, handlingRequest.ToArray(), supplierID.GetLast(3),handlingItem.ToArray(), handlingItemQty.ToArray());
                //BPAadd.ShowDialog();
                //this.reset();
                //this.Refresh();
            }
            else if (radioButton2.Checked)
            {
                bool notEnough = false;
                if (int.Parse(itemList.Rows[0].Cells[1].Value.ToString()) - int.Parse(itemList.Rows[0].Cells[4].Value.ToString()) > 0)
                    notEnough = true;
                if (notEnough ==false)
                {
                    DateTime today = DateTime.Today;
                    String itemID = "";
                    MySqlCommand checkSameRequest = new MySqlCommand("SELECT DesID FROM DespatchInstruction WHERE RequestNo ='" + tbRequestID.Text + "'", cnn);
                    if (checkSameRequest.ExecuteScalar() != null)
                    {
                        nowDesNo = checkSameRequest.ExecuteScalar().ToString();
                    }
                    else
                    {
                        MySqlCommand getNextRequestNo = new MySqlCommand("SELECT MAX(DesID) FROM DespatchInstruction", cnn);
                        nowDesNo = (string)getNextRequestNo.ExecuteScalar();
                        if (nowDesNo == "")
                        {
                            nowDesNo = "0000000";
                        }
                        else
                        {
                            nowDesNo = Regex.Match(nowDesNo, @"\d+").Value;
                        }
                        int num = Int32.Parse(nowDesNo.GetLast(7));
                        num++;
                        nowDesNo = num.ToString().PadLeft(7, '0');
                        nowDesNo = "I" + nowDesNo;
                    }
                    MySqlCommand getItemID = new MySqlCommand("SELECT ItemID FROM Item WHERE ItemDescription = '" + itemList.Rows[0].Cells[0].Value.ToString() + "';", cnn);
                    itemID = getItemID.ExecuteScalar().ToString();
                    MySqlCommand genDes = new MySqlCommand("INSERT INTO DespatchInstruction (DesID, RequestNo, CreationDate, ItemID, quantity, status) VALUES ('"+nowDesNo+"', '"+tbRequestID.Text+"', '"+today.ToString("yyyy-MM-dd")+"' ,'"+itemID+"', '"+itemList.Rows[0].Cells[1].Value.ToString()+"', 'PRO')",cnn);
                    genDes.ExecuteNonQuery();                   
                    MySqlCommand updateRequest = new MySqlCommand("UPDATE PurchaseRequest SET status ='PSS' WHERE RequestNo='" + tbRequestID.Text + "' AND VItemID = '"+itemList.Rows[0].Cells[2].Value.ToString()+"'",cnn);
                    updateRequest.ExecuteNonQuery();
                    MessageBox.Show("Successly Added!");
                    this.reset();
                }
                else
                {
                    MessageBox.Show("Not enough quantity in warehouse!");
                }
            }else if (radioButton3.Checked)
            {
                if (int.Parse(itemList.Rows[0].Cells[1].Value.ToString()) - int.Parse(itemList.Rows[0].Cells[5].Value.ToString()) > 0)
                    MessageBox.Show("Not enough in PPO");
                else
                {
                    string ItemName = itemList.Rows[0].Cells[0].Value.ToString();
                    string SRrequestNo = tbRequestID.Text;
                    MySqlCommand getPPO2 = new MySqlCommand("SELECT  MAX(PPONo) from PPOLines p WHERE p.ItemDescription  ='" + itemList.Rows[0].Cells[0].Value.ToString() + "'", cnn);
                    string PRPPO = getPPO2.ExecuteScalar().ToString();
                    string requestNo = tbRequestID.Text;
                    ScheduleRelease sr = new ScheduleRelease(PRPPO, requestNo, ItemName);
                    sr.ShowDialog();
                    this.reset();
                }
            }
            else if (radioButton4.Checked)
            {
                String supplierNo = "";
                String restNo = "";
                MySqlCommand getNextRequestNo = new MySqlCommand("SELECT MAX(SPONo) FROM SPO", cnn);
                nowSPONo = (string)getNextRequestNo.ExecuteScalar();
                if (nowSPONo == "")
                {
                    nowSPONo = "00000";
                }
                else
                {
                    nowSPONo = Regex.Match(nowSPONo, @"\d+").Value;
                }
                int num = Int32.Parse(nowSPONo.GetLast(5));
                num++;
                nowSPONo = num.ToString().PadLeft(5, '0');
                MySqlDataAdapter getSupplierID = new MySqlDataAdapter("SELECT SupplierNo FROM SupplierItem si, Item i WHERE i.ItemId =si.ItemID AND i.ItemDescription ='" + itemList.Rows[0].Cells[0].Value.ToString()+"'", cnn);
                DataTable dt = new DataTable();
                getSupplierID.Fill(dt);
                foreach (DataRow dr in dt.Rows) {
                    supplierNo = dr["SupplierNo"].ToString().GetLast(3);
                }
                MySqlCommand getRestNo = new MySqlCommand("Select DISTINCT RestNo FROM PurchaseRequest WHERE requestNo = '"+tbRequestID.Text+"'", cnn);
                restNo = getRestNo.ExecuteScalar().ToString();
                restNo = restNo.GetLast(3);
                String RequestNo = tbRequestID.Text;
                SPOAdd spoadd = new SPOAdd(nowSPONo, supplierNo, restNo, itemList.Rows[0].Cells[0].Value.ToString(), itemList.Rows[0].Cells[1].Value.ToString(), RequestNo);
                spoadd.ShowDialog();
                this.reset();
            }
        }
        public List<string> checkrepeatRequest(List<string> requestList, string needHandleRequest) {
            bool haveRequest = false;
            string checkRequest;
            while (needHandleRequest.Length > 8)
            {
                checkRequest = needHandleRequest.Substring(0, 8);
                needHandleRequest = needHandleRequest.GetLast(needHandleRequest.Length - 10);
                foreach (string oldRequest in requestList)
                {
                    if (oldRequest.ToString() == checkRequest)
                        haveRequest = true;
                }
                if (!haveRequest)
                    requestList.Add(checkRequest);
            }
            haveRequest = false;
            foreach(string oldRequest in requestList)
            {
                if (oldRequest.ToString() == needHandleRequest)
                    haveRequest = true;
            }
            if (!haveRequest)
                requestList.Add(needHandleRequest);
            return requestList;
        }
        public void reset() {
            PRMapping newPRM = new PRMapping(m);
            this.Close();
            newPRM.Show();
            //itemList.Update();
            //itemList.Refresh();
            //radioButton1.Checked = false;
            //radioButton2.Checked = false;
            //radioButton3.Checked = false;
            //radioButton4.Checked = false;
            //requestList.Update();
            //requestList.Refresh();
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
