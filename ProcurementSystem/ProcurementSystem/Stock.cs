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
    public partial class Stock : Form
    {
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;");
        Menu m;
        public Stock(Menu m)
        {
            InitializeComponent();
            this.m = m;
            ReloadStock();
        }

        private void ReloadStock()
        {
            cnn.Open();
            //MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM WarehouseStock;", cnn);
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT ws.StockID, ws.ItemID, i.ItemName, ws.Quantity, w.WarehouseAddress, r.RestName FROM WarehouseStock ws, Item i, Warehouse w, Restaurant r WHERE ws.ItemID = i.ItemID AND ws.Location = w.warehouseNo AND ws.Owner = r.RestNo;", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            m.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
