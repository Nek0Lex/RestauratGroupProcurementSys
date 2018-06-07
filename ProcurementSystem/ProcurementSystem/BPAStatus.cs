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
    public partial class BPAStatus : Form
    {
        Form f1;
        ListView lv;
        public BPAStatus(Form1 BPA, ListView listView1)
        {
            this.f1 = BPA;
            this.lv = listView1;
            InitializeComponent();
            BPANo.Text = lv.SelectedItems[0].Text;
            RequestNo.Text = lv.SelectedItems[0].SubItems[1].Text;
            PurchaseOrderRevision.Text = lv.SelectedItems[0].SubItems[2].Text;
            CreationDate.Text = lv.SelectedItems[0].SubItems[3].Text;
            Effective.Text = lv.SelectedItems[0].SubItems[4].Text;
            BuyerName.Text = lv.SelectedItems[0].SubItems[5].Text;
            BillingAddress.Text = lv.SelectedItems[0].SubItems[6].Text;
            Amount.Text = lv.SelectedItems[0].SubItems[7].Text;
            currency.Text = lv.SelectedItems[0].SubItems[8].Text;
            TAC.Text = lv.SelectedItems[0].SubItems[9].Text;
            SupplierNo.Text = lv.SelectedItems[0].SubItems[10].Text;
        }
    }
}
