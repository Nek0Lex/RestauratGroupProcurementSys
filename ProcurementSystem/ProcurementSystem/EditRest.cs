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
    public partial class EditRest : Form
    {
        private MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;");
        private String restNo, name, address, hierarchy;
        private Menu m;
        public EditRest(String restNo, Menu m)
        {
            InitializeComponent();
            this.restNo = restNo;
            Dictionary<String, String> comboSource = new Dictionary<String, String>();
            MySqlDataAdapter sda = new MySqlDataAdapter("select name from Category where parent_id is not null;", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int i = 1;
            foreach (DataRow dr in dt.Rows)
            {
                comboSource.Add(i++.ToString(), dr["name"].ToString());
            }
            comboBox1.DataSource = new BindingSource(comboSource, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
            setData();
            this.m = m;
        }
        public void setData()
        {
            tbID.Text = restNo;
            MySqlDataAdapter sda = new MySqlDataAdapter("select * from Restaurant where RestNo = '" + restNo + "';", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            name = dt.Rows[0][1].ToString();
            address = dt.Rows[0][2].ToString();
            hierarchy = dt.Rows[0][3].ToString();
            tbRName.Text = name;
            rtbAdd.Text = address;
            comboBox1.Text = hierarchy;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            setData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            m.Show();
        }

        private void tbRName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbRName.Text) || string.IsNullOrWhiteSpace(rtbAdd.Text) || string.IsNullOrWhiteSpace(tbID.Text))
            {
                MessageBox.Show("You must input all fields", "Check Your Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                name = tbRName.Text;
                address = rtbAdd.Text;
                hierarchy = comboBox1.Text;
                MySqlCommand command = new MySqlCommand("UPDATE Restaurant SET RestName = '" + name + "', RestAddress = '" + address + "', Hierarchy = '" + hierarchy + "' WHERE RestNo = '" + restNo + "';",cnn);
                cnn.Open();
                command.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Update Success!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                m.Show();
            }
         }

        private void EditRest_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
