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
    public partial class BlanketPurchaseRelease : Form
    {
        public BlanketPurchaseRelease()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void requestNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void actualAmount_TextChanged(object sender, EventArgs e)
        {

        }


        private void confirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Confirm?", null, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
