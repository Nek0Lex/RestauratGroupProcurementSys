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
    public partial class CreateAc : Form
    {
        private Menu m = null;
        public CreateAc(Menu m)
        {
            InitializeComponent();
            this.m = m;
        }

        private void CreateAc_Load(object sender, EventArgs e)
        {

        }

        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            m.Show();
        }
    }
}
