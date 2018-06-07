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
    public partial class CPAStatus : Form
    {
        Form CPA;
        ListView lv;
        public CPAStatus(CPA CPA, ListView listView1)
        {
            this.CPA = CPA;
            this.lv = listView1;
            InitializeComponent();
            ContractNo.Text = lv.SelectedItems[0].Text;
            SupplierNo.Text = lv.SelectedItems[0].SubItems[1].Text;
            CreationDate.Text = lv.SelectedItems[0].SubItems[2].Text;
            EffectiveDate.Text = lv.SelectedItems[0].SubItems[3].Text;
            BuyerName.Text = lv.SelectedItems[0].SubItems[4].Text;
            BillingAddress.Text = lv.SelectedItems[0].SubItems[5].Text;
            TAC.Text = lv.SelectedItems[0].SubItems[6].Text;
            ItemID.Text = lv.SelectedItems[0].SubItems[7].Text;

            SetReadonlyControls(groupBox1.Controls);
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetReadonlyControls(Control.ControlCollection controlCollection)
        {
            if (controlCollection == null)
            {
                return;
            }
            foreach (DateTimePicker d in controlCollection.OfType<DateTimePicker>())
            {
                d.Enabled = false;
            }
            foreach (ComboBox c in controlCollection.OfType<ComboBox>())
            {
                c.Enabled = false;
            }
            foreach (TextBoxBase c in controlCollection.OfType<TextBoxBase>())
            {
                c.ReadOnly = true;
                c.BorderStyle = BorderStyle.None;
            }
        }

    }
}
