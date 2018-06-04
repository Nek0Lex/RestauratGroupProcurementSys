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
        public TypeofAgreementMenu()
        {
            InitializeComponent();
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
            cnn.Open();
            String query = "select LastName from Staff where StaffNo = 'AD000001';";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            string _name = (string)cmd.ExecuteScalar();
        }
        public TypeofAgreementMenu(Menu m)
        {
            InitializeComponent();
            this.m = m;
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
            cnn.Open();
            String query = "select LastName from Staff where StaffNo = 'AD000001';";
            MySqlCommand cmd = new MySqlCommand(query, cnn);
            string _name = (string)cmd.ExecuteScalar();
        }

        public void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 BPA = new Form1();
            BPA.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SPO SPO = new SPO();
            SPO.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PPO PPO = new PPO();
            PPO.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CPA CPA = new CPA();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
