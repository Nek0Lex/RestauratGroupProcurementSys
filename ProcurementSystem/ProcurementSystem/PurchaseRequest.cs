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
    public partial class PurchaseRequest : Form
    {
        private Menu m;
        public PurchaseRequest(Menu m)
        {
            InitializeComponent();
            this.m = m;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void createPRbtn_Click(object sender, EventArgs e)
        {
            CreatePurchaseRequest cpr = new CreatePurchaseRequest(this);
            this.Hide();
            cpr.Show();
        }

        private void purchaseRequestList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void prBack_Click(object sender, EventArgs e)
        {
            this.Close();
            m.Show();
        }

        private void edditPRbtn_Click(object sender, EventArgs e)
        {
            EditPurchaseRequest epr = new EditPurchaseRequest(this);
            this.Hide();
            epr.Show();
        }
    }
}
