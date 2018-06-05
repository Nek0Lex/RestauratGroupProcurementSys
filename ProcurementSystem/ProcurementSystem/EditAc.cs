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
    public partial class EditAc : Form
    {
        private String deptCode, StaffNo, restNo;
        private Menu m;
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;");
        public EditAc(String deptCode, String StaffNo, Menu m)
        {
            InitializeComponent();
            this.StaffNo = StaffNo;
            this.deptCode = deptCode;
            this.m = m;
            if (deptCode == "AM")
            {
                comboBox2.Enabled = true;
                comboBox2.Visible = true;
            }
            else
            {
                comboBox2.Visible = false;
                label7.Visible = false;
            }
            setData();
        }
        public void setData()
        {
            comboBox1.Text = deptCode;
            tbID.Text = Regex.Match(StaffNo, @"\d+").Value;
            if (deptCode == "RM" || deptCode == "AM")
            {
                MySqlDataAdapter sda = new MySqlDataAdapter("select Password, FirstName, LastName, RestName from Staff as s, StaffRestaurant as sr, Restaurant as r where s.StaffNo = '" + StaffNo + "' and s.StaffNo = sr.StaffNo and sr.RestNo = r.RestNo;", cnn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                tbPW.Text = dt.Rows[0][0].ToString();
                tbFName.Text = dt.Rows[0][1].ToString();
                tbLName.Text = dt.Rows[0][2].ToString();
            }
            else
            {
                MySqlDataAdapter sda = new MySqlDataAdapter("select Password, FirstName, LastName from Staff where StaffNo = '" + StaffNo + "';", cnn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                tbPW.Text = dt.Rows[0][0].ToString();
                tbFName.Text = dt.Rows[0][1].ToString();
                tbLName.Text = dt.Rows[0][2].ToString();
            }
            
            if (deptCode == "AM")
            {
                Dictionary<String, String> comboSource2 = new Dictionary<String, String>();
                MySqlDataAdapter sda2 = new MySqlDataAdapter("select RestNo, RestName from Restaurant;", cnn);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                int i = 1;
                foreach (DataRow dr in dt2.Rows)
                {
                    String restInfo = dr["RestNo"].ToString() + " - " + dr["RestName"].ToString();
                    comboSource2.Add(i++.ToString(), restInfo);
                }
                comboBox2.DataSource = new BindingSource(comboSource2, null);
                comboBox2.DisplayMember = "Value";
                comboBox2.ValueMember = "Key";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            m.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            setData();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPW.Text) || string.IsNullOrWhiteSpace(tbFName.Text) || string.IsNullOrWhiteSpace(tbLName.Text) || string.IsNullOrWhiteSpace(tbID.Text))
            {
                MessageBox.Show("You must input all fields", "Check Your Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String pw, fname, lname ;
                pw = tbPW.Text;
                fname = tbFName.Text;
                lname = tbLName.Text;
                MySqlCommand command = new MySqlCommand("UPDATE Staff SET StaffNo = '" + StaffNo + "', FirstName = '" + fname + "', LastName = '" + lname + "', DeptCode = '" + deptCode + "', Password = '"+ pw + "' WHERE StaffNo = '" + StaffNo + "';", cnn);
                cnn.Open();
                command.ExecuteNonQuery();
                cnn.Close();
                if (deptCode == "AM")
                {
                    command = new MySqlCommand("UPDATE StaffRestaurant SET StaffNo = '" + StaffNo + "', RestNo = '" + restNo + "' WHERE StaffNo = '" + StaffNo + "';", cnn);
                    cnn.Open();
                    command.ExecuteNonQuery();
                    cnn.Close();
                }
                MessageBox.Show("Update Success!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                m.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            restNo = ((KeyValuePair<String, String>)comboBox2.SelectedItem).Value.Substring(0, 4);
        }

        private void EditAc_Load(object sender, EventArgs e)
        {

        }
    }
}
