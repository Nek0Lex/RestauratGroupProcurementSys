using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProcurementSystem
{
    public partial class TypeofAgreementMenu : Form
    {
        private Menu m;
        public TypeofAgreementMenu(String staffName, Menu m)
        {
            InitializeComponent();
            this.m = m;
            textBox1.Text = "Hello, " + staffName;
        }

        public void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 BPA = new Form1(this);
            BPA.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SPO SPO = new SPO(this);
            SPO.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PPO PPO = new PPO(this);
            PPO.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CPA CPA = new CPA(this);
            CPA.ShowDialog();
        }

        private void TypeofAgreementMenu_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void prBack_Click(object sender, EventArgs e)
        {
            this.Close();
            m.Show();
        }
    }
}
