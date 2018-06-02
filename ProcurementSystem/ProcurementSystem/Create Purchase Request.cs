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
    public partial class Create_Purchase_Order : Form
    {
        public Create_Purchase_Order()
        {
            InitializeComponent();
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
    }
}
