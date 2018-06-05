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
    public partial class EditPurchaseRequest : Form
    {
        private string staffNo;
        private string restNo;
        private PurchaseRequest pr;
        MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;");
        public EditPurchaseRequest(PurchaseRequest pr, string staffNo, string restNo, string staffName, string restName, string selectedRequest, string createDate)
        {
            InitializeComponent();
            StfId.Text = staffNo;
            StfName.Text = staffName;
            RestId.Text = restNo;
            RestName.Text = restName;
            CreateDate.Text = createDate.Substring(0,10);
            this.restNo = restNo;
            this.staffNo = staffNo;
            title.Text = "Purchase Request " + selectedRequest;
            MySqlCommand showList = new MySqlCommand("select ");
            this.pr = pr;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            pr.Show();
        }
    }
}
