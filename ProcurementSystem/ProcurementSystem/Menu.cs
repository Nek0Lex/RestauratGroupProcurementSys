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
    public partial class Menu : Form
    {
        private String deptCode;
        public Menu(String deptCode)
        {
            InitializeComponent();
            this.deptCode = deptCode;
            switch (deptCode)
            {
                case "PM":
                    lb1.Text = "Purchase Manager";
                    break;
                case "RM":
                    lb1.Text = "Restaurant Manager";
                    break;
                case "CM":
                    lb1.Text = "Category Manager";
                    break;
                case "WC":
                    lb1.Text = "Warehouse Clerk";
                    break;
                case "AD":
                    lb1.Text = "Accounting Department";
                    break;
                case "AM":
                    lb1.Text = "ADMIN";
                    break;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void lingLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (deptCode == "AM")
            {
                this.Hide();
                CreateAc cac = new CreateAc(this);
                cac.Show();
            }
        }
    }
}
