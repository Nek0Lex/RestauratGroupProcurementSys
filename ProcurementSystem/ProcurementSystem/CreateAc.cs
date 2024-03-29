﻿using System;
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
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;");
        private EditMenu m = null;
        private String uid;
        private String restNum;
        public CreateAc(EditMenu m)
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
            Dictionary<String, String> comboSource2 = new Dictionary<String, String>();
            MySqlDataAdapter sda = new MySqlDataAdapter("select RestNo, RestName from Restaurant;", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int i=1;
            foreach (DataRow dr in dt.Rows)
            {
                String restInfo = dr["RestNo"].ToString() + " - " + dr["RestName"].ToString();
                comboSource2.Add(i++.ToString(), restInfo );
            }
            comboBox2.DataSource = new BindingSource(comboSource2, null);
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";
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

            if (((KeyValuePair<String, String>)comboBox1.SelectedItem).Value == "RM")
            {
                comboBox2.Enabled = true;
                comboBox2.Visible = true;
                label7.Visible = true;
            }
            else
            {
                comboBox2.Enabled = false;
                comboBox2.Visible = false;
                label7.Visible = false;
            }
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
                //get data from the inputs
                deptCode = ((KeyValuePair<String, String>)comboBox1.SelectedItem).Value;
                fName = tbFName.Text;
                lName = tbLName.Text;
                pw = tbPW.Text;
                //insert all data into db
                MySqlCommand command = cnn.CreateCommand();
                command.CommandText = "insert into Staff values('" + uid + "','" + fName + "','" + lName + "','" + deptCode + "','" + pw + "');";
                cnn.Open();
                command.ExecuteNonQuery();
                cnn.Close();
                if (((KeyValuePair<String, String>)comboBox1.SelectedItem).Value == "RM")
                {
                    command.CommandText = "insert into StaffRestaurant values('" + uid + "','" + restNum + "');";
                    cnn.Open();
                    command.ExecuteNonQuery();
                    cnn.Close();
                }
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
            comboBox1.SelectedIndex = 1;
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            restNum = ((KeyValuePair<String, String>)comboBox2.SelectedItem).Value.Substring(0,4);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
