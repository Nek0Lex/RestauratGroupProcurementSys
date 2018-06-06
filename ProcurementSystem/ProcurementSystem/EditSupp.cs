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
    public partial class EditSupp : Form
    {
        private Menu m;
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
        private String SNo, SContact, SAddress;
        public EditSupp(String SNo, String SContact, String SAddress, Menu m)
        {
            InitializeComponent();
            this.m = m;
            this.SNo = SNo;
            this.SContact = SContact;
            this.SAddress = SAddress;
            setData();
        }

        public void setData()
        {
            tbNo.Text = SNo;
            tbContact.Text = SContact;
            rtbAdd.Text = SAddress;
        }

        private void EditSupp_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNo.Text) || string.IsNullOrWhiteSpace(tbContact.Text) || string.IsNullOrWhiteSpace(rtbAdd.Text))
            {
                MessageBox.Show("You must input all fields", "Check Your Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SNo = tbNo.Text;
                SContact = tbContact.Text;
                SAddress = rtbAdd.Text;
                MySqlCommand command = new MySqlCommand("UPDATE Supplier SET SupplierContact = '" + SContact + "', SupplierAddress = '" + SAddress + "' WHERE SupplierNo = '" + SNo + "';", cnn);
                cnn.Open();
                command.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Update Success!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                m.Show();
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
    }
}
