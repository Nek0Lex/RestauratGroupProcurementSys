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
    public partial class CreateRest : Form
    {
        private Menu m;
        private String rid;
        public CreateRest(Menu m)
        {
            InitializeComponent();
            this.m = m;
            int restID;
            MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;");
            MySqlDataAdapter sda = new MySqlDataAdapter("select Max(RestNo) from Restaurant;", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            rid = dt.Rows[0][0].ToString();
            //add 1 to the restaurant number
            rid = Regex.Match(rid, @"\d+").Value;
            restID = Int32.Parse(rid);
            restID += 1;
            rid = "R" + restID.ToString().PadLeft(3, '0');
            tbID.Text = rid;
            Dictionary<String, String> comboSource = new Dictionary<String, String>();
            MySqlDataAdapter sda2 = new MySqlDataAdapter("select name from Category where parent_id is not null;", cnn);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            int i = 1;
            foreach (DataRow dr2 in dt2.Rows)
            {
                comboSource.Add(i++.ToString(), dr2["name"].ToString());
            }
            comboBox1.DataSource = new BindingSource(comboSource, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
        }

        private void CreateRest_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            m.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbID.Text) || string.IsNullOrWhiteSpace(rtbAdd.Text) || string.IsNullOrWhiteSpace(tbRName.Text))
            {
                MessageBox.Show("You must input all fields", "Check Your Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String rAddress, rName, hierachy;
                rAddress = rtbAdd.Text;
                rName = tbRName.Text;
                hierachy = comboBox1.Text;
                //insert all data into db
                MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;");
                MySqlCommand command = cnn.CreateCommand();
                command.CommandText = "insert into Restaurant values('" + rid + "','" + rName + "','" + rAddress + "','" + hierachy + "')";
                cnn.Open();
                command.ExecuteNonQuery();
                cnn.Close();
                //show create success message
                MessageBox.Show("Create Success!", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                m.Show();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbAdd.Text = String.Empty;
            tbRName.Text = String.Empty;
            tbID.Text = rid;
            comboBox1.SelectedIndex = 0;
        }

        private void rtbAdd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
