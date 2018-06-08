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
    public partial class StockManagement : Form
    {
        int mode;
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;");
        string StockID;
        string ItemID;
        string Quantity;
        string StockLocation;
        string StockOwner;
        
        public StockManagement()
        {
            InitializeComponent();
            mode = 0; //Create mode
        }

        public StockManagement(DataGridViewSelectedRowCollection selectedRow)
        {
            InitializeComponent();
            mode = 1; //Edit mode

            foreach (DataGridViewRow row in selectedRow)
            {
                StockID = row.Cells[0].Value.ToString();
                ItemID = row.Cells[1].Value.ToString();
                Quantity = row.Cells[2].Value.ToString();
                StockLocation = row.Cells[3].Value.ToString();
                StockOwner = row.Cells[4].Value.ToString();
            }

            textBox_StockID.Text = StockID;
            textBox_ItemID.Text = ItemID;
            textBox_Quantity.Text = Quantity;
            textBox_Location.Text = StockLocation;
            textBox_Owner.Text = StockOwner;

        }

        private void StockManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 0:
                    addStock();
                    break;
                case 1:
                    editStock();
                    break;
            }

            this.Close();
        }

        private void addStock()
        {
            if (!string.IsNullOrWhiteSpace(textBox_StockID.Text) && !string.IsNullOrWhiteSpace(textBox_ItemID.Text) && !string.IsNullOrWhiteSpace(textBox_Quantity.Text) && !string.IsNullOrWhiteSpace(textBox_Location.Text) && !string.IsNullOrWhiteSpace(textBox_Owner.Text))
            {
                cnn.Open();
                string insert = "INSERT INTO WarehouseStock VALUES ('" + textBox_StockID.Text + "', '" + textBox_ItemID.Text + "', '" + textBox_Quantity.Text + "' , '" + textBox_Location.Text + "' , '" + textBox_Owner.Text + "'  ); ";
                MySqlCommand cmd = new MySqlCommand(insert, cnn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Insert Failed: Duplicate with existing record");
                    Console.WriteLine(ex.ToString());
                    cnn.Close();
                    return;
                }
                MessageBox.Show("Create Success!");
            }
        }

        private void editStock()
        {
            cnn.Open();
            string update = "UPDATE WarehouseStock SET StockID = '" + textBox_StockID.Text + "', ItemID = '" + textBox_ItemID.Text + "', Quantity = " + textBox_Quantity.Text + ", Location = '" + textBox_Location.Text + "', Owner = '" + textBox_Owner.Text + "' WHERE StockID = '" + StockID +"' AND ItemID = '" + ItemID + "';";
            MySqlCommand cmd = new MySqlCommand(update, cnn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Update Failed: Duplicate with existing Item");
                Console.WriteLine(ex.ToString());
                cnn.Close();
                return;
            }
            MessageBox.Show("Update Success!");
            cnn.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
