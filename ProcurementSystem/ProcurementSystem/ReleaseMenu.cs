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
    public partial class ReleaseMenu : Form
    {
        public ReleaseMenu()
        {
            InitializeComponent();
        }

        private void BPRForward_Click(object sender, EventArgs e)
        {
            BlanketPurchaseReleaseAdd BPRAdd = new BlanketPurchaseReleaseAdd();
            BPRAdd.Show();
        }

        private void SRForward_Click(object sender, EventArgs e)
        {
            ScheduleReleaseAdd scheduleReleaseAdd = new ScheduleReleaseAdd();
            scheduleReleaseAdd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu mainMenu = new Menu("WC000001", "WC");
            mainMenu.Show();
            this.Close();
        }
    }
}
