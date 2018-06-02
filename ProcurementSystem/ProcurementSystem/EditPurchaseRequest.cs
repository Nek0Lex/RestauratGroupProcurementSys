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
    public partial class EditPurchaseRequest : Form
    {
        private PurchaseRequest pr;
        public EditPurchaseRequest(PurchaseRequest pr)
        {
            InitializeComponent();
            this.pr = pr;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            pr.Show();
        }
    }
}
