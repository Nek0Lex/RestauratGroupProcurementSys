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
    public partial class CreateSupp : Form
    {
        private Menu m;
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
        public CreateSupp(String SNo, Menu m)
        {
            InitializeComponent();
            this.m = m;
            int sid;
            SNo = Regex.Match(SNo, @"\d+").Value;
            sid = Int32.Parse(SNo);
            sid += 1;
            SNo = "S" + sid.ToString().PadLeft(3, '0');
            tbNo.Text = SNo;
        }

        private void CreateSupp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            m.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbNo.Text = String.Empty;
            tbName.Text = String.Empty;
            tbContact.Text = String.Empty;
            rtbAdd.Text = String.Empty;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNo.Text) || string.IsNullOrWhiteSpace(tbName.Text) || string.IsNullOrWhiteSpace(tbContact.Text))
            {
                MessageBox.Show("You must input all fields", "Check Your Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String SNo, SName, SContact, SAddress;
                //get data from the inputs
                SNo = tbNo.Text;
                SContact = tbContact.Text;
                SName = tbName.Text;
                SAddress = rtbAdd.Text;
                //insert all data into db
                MySqlCommand command = cnn.CreateCommand();
                command.CommandText = "insert into Supplier values('" + SNo + "','" + SName + "','" + SContact + "','" + SAddress + "');";
                cnn.Open();
                command.ExecuteNonQuery();
                cnn.Close();
                //show create success message
                MessageBox.Show("Create Success!", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                m.Show();
            }
        }
    }
}
