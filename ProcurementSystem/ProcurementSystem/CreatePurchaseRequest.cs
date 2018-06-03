using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcurementSystem
{
    public partial class CreatePurchaseRequest : Form
    {
        private PurchaseRequest pr;
        public CreatePurchaseRequest(PurchaseRequest pr)
        {
            InitializeComponent();
            this.pr = pr;
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
                int quantity;
                Boolean qtnNull = int.TryParse(qtn.Text,out quantity);
                if ((quantity <= 0)||(qtnNull ==false))
                {
                    errorMsg.Text = "Check Your Input!";
                }
                else
                {
                    string addMsg = "Item : " + selectItem + " Quantity : " + quantity;
                    purchaseList.Items.Insert(0, addMsg);
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
    }
}
