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
    public partial class EditMenu : Form
    {
        private Menu m;
        private int target; //0 for user account, 1 for restaurant
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
        public EditMenu(Menu m, int target)
        {
            InitializeComponent();
            this.m = m;
            this.target = target;
            DataTable dt = new DataTable();
            if (target == 0)
            {
                label1.Text = "Edit User Information";
                listViewUser.Visible = true;
                MySqlDataAdapter sda = new MySqlDataAdapter("select * from Staff;", cnn);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem listitem = new ListViewItem(dr["StaffNo"].ToString());
                    listitem.SubItems.Add(dr["FirstName"].ToString());
                    listitem.SubItems.Add(dr["LastName"].ToString());
                    listitem.SubItems.Add(dr["DeptCode"].ToString());
                    listitem.SubItems.Add(dr["Password"].ToString());
                    listViewUser.Items.Add(listitem);
                }
            }
            else
            {
                label1.Text = "Edit Restaurant";
                listViewRest.Visible = true;
                MySqlDataAdapter sda = new MySqlDataAdapter("select * from Restaurant;", cnn);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem listitem = new ListViewItem(dr["RestNo"].ToString());
                    listitem.SubItems.Add(dr["RestName"].ToString());
                    listitem.SubItems.Add(dr["RestAddress"].ToString());
                    listitem.SubItems.Add(dr["Hierarchy"].ToString());
                    listViewRest.Items.Add(listitem);
                }
            }
        }

        private void EditMenu_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (target == 0)
            {
                
                EditAc ea = new EditAc(listViewUser.SelectedItems[0].SubItems[3].Text, listViewUser.SelectedItems[0].SubItems[0].Text, m);
                this.Hide();
                ea.Show();
            }
            else
            {
                EditRest er = new EditRest(listViewRest.SelectedItems[0].SubItems[0].Text, m);
                this.Hide();
                er.Show();
            }            
        }

        private void listViewUser_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
