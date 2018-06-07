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
        private String rno;
        private int target; //0 for user account, 1 for restaurant
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
        public EditMenu(Menu m, int target)
        {
            InitializeComponent();
            this.m = m;
            this.target = target;
            String UserOrRest;
            DataTable dt = new DataTable();
            if (target == 0)
            {
                label1.Text = "Edit User Information";
                listViewUser.Visible = true;
                UserOrRest = "User";
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
                UserOrRest = "Restaurant";
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
            btnAdd.Text = "Add" + UserOrRest;
            btnEdit.Text = "Edit" + UserOrRest;
            btnDelete.Text = "Delete" + UserOrRest;
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
            if (listViewUser.SelectedItems.Count >= 1 || listViewRest.SelectedItems.Count >= 1)
            {
                if (target == 0)
                {
                
                    EditAc ea = new EditAc(listViewUser.SelectedItems[0].SubItems[3].Text, listViewUser.SelectedItems[0].SubItems[0].Text, this);
                    this.Hide();
                    ea.Show();
                }
                else
                {
                    EditRest er = new EditRest(listViewRest.SelectedItems[0].SubItems[0].Text, this);
                    this.Hide();
                    er.Show();
                }      
            }
            else
            {
                MessageBox.Show("Please select the target \n that you want to edit.", "Select Target!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void listViewUser_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (target == 0)
            {

                CreateAc ea = new CreateAc(this);
                this.Hide();
                ea.Show();
            }
            else
            {
                CreateRest er = new CreateRest(this);
                this.Hide();
                er.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewUser.SelectedItems.Count >= 1 || listViewRest.SelectedItems.Count >= 1)
            {
                if (target == 0)
                {
                    String uid = listViewUser.SelectedItems[0].SubItems[0].Text;
                    try
                    {
                        if (listViewUser.SelectedItems[0].SubItems[3].Text == "RM")
                        {
                            DataTable dt = new DataTable();
                            MySqlDataAdapter sda = new MySqlDataAdapter("select RestNo from StaffRestaurant where StaffNo = '" + uid + "';", cnn);
                            sda.Fill(dt);
                            rno = dt.Rows[0][0].ToString();
                            MySqlCommand delete = new MySqlCommand("Delete From StaffRestaurant where StaffNo = '" + uid + "';", cnn);
                            cnn.Open();
                            delete.ExecuteNonQuery();
                            cnn.Close();
                        }
                        MySqlCommand delete2 = new MySqlCommand("Delete From Staff where StaffNo = '" + uid + "';", cnn);
                        cnn.Open();
                        delete2.ExecuteNonQuery();
                        cnn.Close();
                        MessageBox.Show("User Deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Delete Failed. \n Please check whether the user \n is processing with the requests.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (listViewUser.SelectedItems[0].SubItems[3].Text == "RM")
                        {
                            MySqlCommand recovery = new MySqlCommand("Insert into StaffRestaurant values ('" + uid + "','" + rno + "');", cnn);
                            recovery.ExecuteNonQuery();
                            cnn.Close();
                        }
                    }
                }
                else
                {
                    String rno = listViewRest.SelectedItems[0].SubItems[0].Text;
                    try
                    {
                        MySqlCommand delete = new MySqlCommand("Delete From Restaurant where RestNo = '" + rno + "';", cnn);
                        cnn.Open();
                        delete.ExecuteNonQuery();
                        cnn.Close();
                        MessageBox.Show("Restaurant Deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Delete Failed. \n Please check whether the restaurant \n is processing with the requests \n or containing staffs.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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
            if (target == 0)
            {
                listViewUser.Items.Clear();
                DataTable dt = new DataTable();
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
                listViewRest.Items.Clear();
                DataTable dt = new DataTable();
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
    }
}
