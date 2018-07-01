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
using System.Text.RegularExpressions;

namespace ProcurementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            tbSN.Text = Properties.Settings.Default.username;
            if (Properties.Settings.Default.isSave.Equals("True"))
                checkSave.Checked = true;
            else
                checkSave.Checked = false;
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
            Regex r = new Regex("^[a-zA-Z0-9]*$");
            try
            {
                if (!r.IsMatch(tbSN.Text))
                    MessageBox.Show("Only can input alphanumeric", "Check your input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (tbSN.Text.Length > 8 || tbSN.Text.Length < 8)
                    MessageBox.Show("The length of username must be 8 !", "Check your input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (tbPW.Text.Length > 8)
                    MessageBox.Show("The length of password must not longer than 8 !", "Check your input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (tbPW.Text.Length == 0)
                    MessageBox.Show("The length of password must not be null !", "Check your input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    tbSN.Text.ToUpper();
                    MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none");
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
                        MessageBox.Show("Account Not Found", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (checkSave.Checked)
                    {
                        Properties.Settings.Default.username = tbSN.Text;
                        Properties.Settings.Default.isSave = "True";
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.username = null;
                        Properties.Settings.Default.isSave = "False";
                        Properties.Settings.Default.Save();
                    }
                }
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show("Account Not Found", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbPW_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
