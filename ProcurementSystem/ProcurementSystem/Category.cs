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
        //List<object> cat;

        public Category(Menu m)
        {
            InitializeComponent();
            this.m = m;
        }

        private void Category_Load(object sender, EventArgs e)
        {
            cnn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM Category;", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //cat = dt.AsEnumerable().ToList<object>();
            //treeView1.DataSource = sda;
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
            cnn.Close();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            cnn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT VItemID, i.ItemID, ItemName,ItemDescription FROM VItem v, Item i where v.ItemId=i.ItemID AND v.category_id = " + treeView1.SelectedNode.Tag.ToString() + "; ", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();
        }

        private void AddCategory_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(treeView1.SelectedNode.Tag.ToString());
            //string categoryName;
            //MySqlCommand add = new MySqlCommand("INSERT INTO Category (name, parent_id) Value (" + categoryName + ", " + treeView1.SelectedNode.Tag.ToString() + ");", cnn);
            //add.ExecuteNonQuery();
        }
        
    }


}
