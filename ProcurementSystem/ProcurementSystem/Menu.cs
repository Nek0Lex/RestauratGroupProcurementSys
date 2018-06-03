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
    public partial class Menu : Form
    {
        private String StaffNo;
        private String deptCode;
        public Menu(String StaffNo, String deptCode)
        {
            InitializeComponent();
            this.StaffNo = StaffNo;
            this.deptCode = deptCode;
            switch (deptCode)
            {
                case "PM":
                    lb1.Text = "Purchase Manager";
                    break;
                case "RM":
                    lb1.Text = "Restaurant Manager";
                    MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;");
                    MySqlDataAdapter sda = new MySqlDataAdapter("select RestName from Staff,StaffRestaurant,Restaurant where Staff.StaffNo='"+StaffNo+"' and Staff.StaffNo = StaffRestaurant.StaffNo and StaffRestaurant.RestNo = Restaurant.RestNo;", cnn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    lb1.Text = dt.Rows[0][0].ToString();
                    btn1.Text = "Create Purchase Request";
                    break;
                case "CM":
                    lb1.Text = "Category Manager";
                    break;
                case "WC":
                    lb1.Text = "Warehouse Clerk";
                    break;
                case "AD":
                    lb1.Text = "Accounting Department";
                    break;
                case "AM":
                    lb1.Text = "ADMIN";
                    btn1.Text = "Create New User";
                    break;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (deptCode)
            {
                case "AM":
                    this.Hide();
                    CreateAc cac = new CreateAc(this);
                    cac.Show();
                    break;
                case "RM":
                    this.Hide();
                    PurchaseRequest pr = new PurchaseRequest(this,0001);
                    pr.Show();
                    break;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}
