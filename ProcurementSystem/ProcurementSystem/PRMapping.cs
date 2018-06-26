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
    public partial class PRMapping : Form
    {
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;");
        public PRMapping()
        {
            InitializeComponent();
            cnn.Open();
            MySqlDataAdapter findRequestList = new MySqlDataAdapter("Select RequestNo, CreationDate From PurchaseRequest where status='NEW';", cnn);
            DataTable dt = new DataTable();
            findRequestList.Fill(dt);
            foreach (DataRow dr in dt.Rows) {
                requestList.Rows.Add(dr["RequestNo"].ToString(), dr["CreationDate"].ToString());
            }
        }
    }
}
