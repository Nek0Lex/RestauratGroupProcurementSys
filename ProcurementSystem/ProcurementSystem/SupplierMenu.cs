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
    public partial class SupplierMenu : Form
    {
        private Menu m;
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
        public SupplierMenu(Menu m)
        {
            InitializeComponent();
            this.m = m;
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter("select * from Supplier;", cnn);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem listitem = new ListViewItem(dr["SupplierNo"].ToString());
                listitem.SubItems.Add(dr["SupplierName"].ToString());
                listitem.SubItems.Add(dr["SupplierContact"].ToString());
                listitem.SubItems.Add(dr["SupplierAddress"].ToString());
                listViewSupplier.Items.Add(listitem);
            }
        }

        private void SupplierMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            m.Show();
        }

        private void listViewSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter sda2 = new MySqlDataAdapter("select Max(SupplierNo) from Supplier;", cnn);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            CreateSupp cs = new CreateSupp(dt2.Rows[0][0].ToString(), this);
            this.Hide();
            cs.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listViewSupplier.SelectedItems.Count >= 1)
            {
                EditSupp es = new EditSupp(listViewSupplier.SelectedItems[0].SubItems[0].Text,
                    listViewSupplier.SelectedItems[0].SubItems[1].Text, listViewSupplier.SelectedItems[0].SubItems[2].Text, listViewSupplier.SelectedItems[0].SubItems[3].Text, this);
                this.Hide();
                es.Show();
            }
            else
            {
                MessageBox.Show("Please select the supplier \n that you want to delete.", "Select Supplier!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listViewSupplier.SelectedItems.Count >= 1)
            {
                String sid = listViewSupplier.SelectedItems[0].SubItems[0].Text;
                try
                {
                    MySqlCommand command = new MySqlCommand("Delete From Supplier where SupplierNo = '" + sid + "';", cnn);
                    cnn.Open();
                    command.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("Supplier Deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete Failed. \n Please check whether the supplier \n is processing with requests.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select the supplier \n that you want to delete.", "Select Supplier!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btnRefresh_Click(sender, e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listViewSupplier.Items.Clear();
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter("select * from Supplier;", cnn);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem listitem = new ListViewItem(dr["SupplierNo"].ToString());
                listitem.SubItems.Add(dr["SupplierName"].ToString());
                listitem.SubItems.Add(dr["SupplierContact"].ToString());
                listitem.SubItems.Add(dr["SupplierAddress"].ToString());
                listViewSupplier.Items.Add(listitem);
            }
        }
    }
}
