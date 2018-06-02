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
            string selectItem = this.itemList.Text.ToString();
            string quantity = qtn.Text.ToString();
            string addMsg = "Item : "+selectItem +"Quantity : "+quantity;
            purchaseList.Items.Insert(1,addMsg);
        }

        private void Create_Purchase_Order_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            pr.Show();
        }
    }
}
