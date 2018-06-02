using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProcurementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;");
            MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from Staff where StaffNo = '" + tbSN.Text + "' and Password = '" + tbPW.Text + "'", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                sda = new MySqlDataAdapter("select deptcode from Staff where StaffNo = '" + tbSN.Text + "';", cnn);
                dt = new DataTable();
                sda.Fill(dt);
                String deptCode = dt.Rows[0][0].ToString();
                cnn.Close();
                this.Hide();
                Menu m = new Menu(tbSN.Text, deptCode);
                m.Show();
            }
            else
                MessageBox.Show("Please enter the correct information", "alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
