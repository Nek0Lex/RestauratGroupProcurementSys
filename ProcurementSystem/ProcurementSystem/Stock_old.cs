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
    public partial class Stock_old : Form
    {
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;");
        Menu m;
        public Stock_old(Menu m)
        {
            InitializeComponent();
            this.m = m;
            ReloadStock();
        }

        private void ReloadStock()
        {
            cnn.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM WarehouseStock;", cnn);
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
            StockManagement addStock = new StockManagement();
            addStock.FormClosing += new FormClosingEventHandler(this.StockManagement_FormClosing);
            addStock.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && !dataGridView1.SelectedRows[0].IsNewRow)
            {
                DataGridViewSelectedRowCollection selectedRow = dataGridView1.SelectedRows;
                StockManagement editStock = new StockManagement(selectedRow);
                editStock.FormClosing += new FormClosingEventHandler(this.StockManagement_FormClosing);
                editStock.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                try
                {
                    string StockID = row.Cells[0].Value.ToString();
                    string ItemID = row.Cells[1].Value.ToString();
                
                    MySqlCommand del;
                    cnn.Open();
                    del = new MySqlCommand("DELETE FROM WarehouseStock WHERE StockID = '" + StockID + "' AND ItemID = '" + ItemID + "'; ", cnn);
                    del.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    cnn.Close();
                }
                ReloadStock();
            }
        }

        private void StockManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReloadStock();
        }
    }
}
