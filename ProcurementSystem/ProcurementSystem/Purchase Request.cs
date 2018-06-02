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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createPRbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProcurementSystem.Create_Purchase_Order CPO = new Create_Purchase_Order();
            CPO.MdiParent = this;
            CPO.Show();
        }
    }
}
