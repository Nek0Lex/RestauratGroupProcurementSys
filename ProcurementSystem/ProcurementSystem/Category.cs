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
    public partial class Category : Form
    {
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;");
        private Menu m = null;
        DataTable itemInfo;
        //List<object> cat;

        public Category(Menu m)
        {
            InitializeComponent();
            this.m = m;
        }

        public void ReloadCategory()
        {
            treeView1.Nodes.Clear();
            cnn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM Category;", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //cat = dt.AsEnumerable().ToList<object>();
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["parent_id"].ToString().Equals(""))
                {
                    TreeNode treeNode = new TreeNode(dr["name"].ToString());
                    treeNode.Tag = dr["category_id"].ToString();
                    treeView1.Nodes.Add(treeNode);

                    MySqlDataAdapter sdaChild = new MySqlDataAdapter("SELECT* FROM Category WHERE parent_id = " + dr["category_id"].ToString() + ";", cnn);
                    DataTable dtChild = new DataTable();
                    sdaChild.Fill(dtChild);
                    foreach (DataRow drChild in dtChild.Rows)
                    {
                        TreeNode childNode = new TreeNode(drChild["name"].ToString());
                        childNode.Tag = drChild["category_id"].ToString();
                        treeNode.Nodes.Add(childNode);
                    }

                }
            }
            treeView1.ExpandAll();
            cnn.Close();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            ReloadCategory();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            cnn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT VItemID, i.ItemID, ItemName,ItemDescription FROM VItem v, Item i where v.ItemId=i.ItemID AND v.category_id = " + treeView1.SelectedNode.Tag.ToString() + "; ", cnn);
            itemInfo = new DataTable();
            sda.Fill(itemInfo);
            dataGridView1.DataSource = itemInfo;
            cnn.Close();
        }

        private void AddCategory_Click(object sender, EventArgs e)
        {
            //textBox1.Visible = !textBox1.Visible;
            //MessageBox.Show(treeView1.SelectedNode.Tag.ToString());
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                cnn.Open();
                MySqlCommand add = new MySqlCommand("INSERT INTO Category (name, parent_id) Value ('" + textBox1.Text.ToString() + "', " + treeView1.SelectedNode.Tag.ToString() + ");", cnn);
                add.ExecuteNonQuery();
                cnn.Close();
                ReloadCategory();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            m.Show();
        }

        private void DeleteCategory_Click(object sender, EventArgs e)
        {
            MySqlCommand del;
            cnn.Open();
            try
            {
                del = new MySqlCommand("DELETE FROM Category WHERE category_id = " + treeView1.SelectedNode.Tag.ToString() + "; ", cnn);
                del.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cnn.Close();
            }
            ReloadCategory();
        }

        private void EditCategory_Click(object sender, EventArgs e)
        {
            MySqlCommand edit;
            cnn.Open();
            try
            {
                edit = new MySqlCommand("UPDATE Category SET name = '" + textBox1.Text + "' WHERE category_id = " + treeView1.SelectedNode.Tag.ToString() +"; ", cnn);
                edit.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cnn.Close();
            }
            ReloadCategory();
        }

        private void UpdateVIDMapping_Click(object sender, EventArgs e)
        {

        }
    }


}
