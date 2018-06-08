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
    public partial class ItemManagement : Form
    {
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;");
        int mode;
        string ItemID;
        string ItemName;
        string ItemDescription;

        public ItemManagement()
        {
            InitializeComponent();
            mode = 0; //Create mode
        }

        public ItemManagement(DataGridViewSelectedRowCollection selectedRow)
        {
            InitializeComponent();
            mode = 1; //Edit mode

            foreach (DataGridViewRow row in selectedRow)
            {
                ItemID = row.Cells[0].Value.ToString();
                ItemName = row.Cells[1].Value.ToString();
                ItemDescription = row.Cells[2].Value.ToString();
            }
            
            textBox_ItemID.Text = ItemID;
            textBox_ItemName.Text = ItemName;
            textBox_ItemDescription.Text = ItemDescription;
        }

        private void ItemManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 0:
                    CreateItem();
                    break;
                case 1:
                    UpdateItem(); 
                    break;
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateItem()
        {
            if (!string.IsNullOrWhiteSpace(textBox_ItemID.Text) && !string.IsNullOrWhiteSpace(textBox_ItemName.Text) && !string.IsNullOrWhiteSpace(textBox_ItemDescription.Text))
            {
                cnn.Open();
                string insert = "INSERT INTO Item (ItemID, ItemName, ItemDescription) VALUES ('" + textBox_ItemID.Text + "', '" + textBox_ItemName.Text + "', '" + textBox_ItemDescription.Text + "'); ";
                MySqlCommand cmd = new MySqlCommand(insert, cnn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Insert Failed: Duplicate with existing Item");
                    Console.WriteLine(ex.ToString());
                    cnn.Close();
                    return;
                }
                MessageBox.Show("Update Success!");
            }
        }

        private void UpdateItem()
        {
            cnn.Open();
            string update = "UPDATE Item SET ItemID = '" + textBox_ItemID.Text + "', ItemName = '" + textBox_ItemName.Text + "', ItemDescription = '" + textBox_ItemDescription.Text + "' WHERE ItemID = '" + ItemID + "';";
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
    }

}
