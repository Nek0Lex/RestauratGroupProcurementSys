using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractManagement
{
    public partial class PPO : Form
    {
        public PPO()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TypeofAgreementMenu menu = new TypeofAgreementMenu();
            this.Close();
        }
    }
}
