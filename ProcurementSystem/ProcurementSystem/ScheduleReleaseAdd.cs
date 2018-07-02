using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProcurementSystem
{
    public partial class ScheduleReleaseAdd : Form
    {
        public ScheduleReleaseAdd()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (SRNo.Text.Equals("")||shippingAddress.Text.Equals(""))
            {
                MessageBox.Show("Fill in all the text box!");
            }
            else
            {
                String CreationDate = creationDate.Value.ToString("yyyy-MM-dd");
                String EffectiveDate = effectiveDate.Value.ToString("yyyy-MM-dd");
                String ShippingAddress = shippingAddress.Text;
                String srno = SRNo.Text;

                MySqlConnection cnn = new MySqlConnection("server=code4cat.me; user id=jackysc; password=123456; database=procurement;SslMode=none");
                cnn.Open();
                String query = "INSERT INTO SheduleRelease (SRNo, CreationDate,EffectiveDate, DeliveryAddress) VALUES " +
                    "('" + srno + "', '" + CreationDate + "', '" + EffectiveDate + "', '" + ShippingAddress + "');";
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Add successfully");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
