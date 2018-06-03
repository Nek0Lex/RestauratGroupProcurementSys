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
    public partial class CreateAc : Form
    {
        private Menu m = null;
        private String uid;
        public CreateAc(Menu m)
        {
            InitializeComponent();
            this.m = m;
            Dictionary<String, String> comboSource = new Dictionary<String, String>();
            comboSource.Add("1", "RM");
            comboSource.Add("2", "PM");
            comboSource.Add("3", "CM");
            comboSource.Add("4", "WC");
            comboSource.Add("5", "AD");
            comboSource.Add("6", "AM");
            comboBox1.DataSource = new BindingSource(comboSource, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
        }

        private void CreateAc_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get the current maximum user id
            String deptCode = ((KeyValuePair<String, String>)comboBox1.SelectedItem).Value;
            int staffNo;
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;");
            MySqlDataAdapter sda = new MySqlDataAdapter("select Max(StaffNo) from Staff where StaffNo like '" + deptCode + "%';", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            uid = dt.Rows[0][0].ToString();
            //add 1 to the max uid to show the next id
            uid = Regex.Match(uid, @"\d+").Value;
            staffNo = Int32.Parse(uid);
            staffNo += 1;
            uid = deptCode + staffNo.ToString().PadLeft(6, '0');
            tbID.Text = staffNo.ToString().PadLeft(6, '0');
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFName.Text) || string.IsNullOrWhiteSpace(tbLName.Text) || string.IsNullOrWhiteSpace(tbPW.Text) || string.IsNullOrWhiteSpace(tbID.Text))
            {
                MessageBox.Show("You must input all fields", "Check Your Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            { 
                String deptCode, fName, lName, pw;
                int staffNo;
                //get data from the inputs
                deptCode = ((KeyValuePair<String, String>)comboBox1.SelectedItem).Value;
                fName = tbFName.Text;
                lName = tbLName.Text;
                pw = tbPW.Text;
                //insert all data into db
                MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;");
                MySqlCommand command = cnn.CreateCommand();
                command.CommandText = "insert into Staff values('" + uid + "','" + fName + "','" + lName + "','" + deptCode + "','" + pw + "')";
                cnn.Open();
                command.ExecuteNonQuery();
                cnn.Close();
                //show create success message
                MessageBox.Show("Create Success!", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                m.Show();
             }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbFName.Text = String.Empty;
            tbLName.Text = String.Empty;
            tbPW.Text = String.Empty;
            comboBox1.SelectedIndex = 0;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            m.Show();
        }
    }
}
