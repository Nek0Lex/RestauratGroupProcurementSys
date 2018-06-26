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
        private MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;");
        private String StaffNo;
        private String deptCode;
        private String restNo;
        private String staffName;
        private DataTable dt = new DataTable();
        public Menu(String StaffNo, String deptCode)
        {
            InitializeComponent();
            this.StaffNo = StaffNo.ToUpper();
            this.deptCode = deptCode;
            MySqlDataAdapter sda = new MySqlDataAdapter("select FirstName, LastName from Staff where Staff.StaffNo='" + StaffNo + "';", cnn);
            sda.Fill(dt);
            staffName = dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString();
            lbStaffName.Text = "Hello, " + staffName;
            switch (deptCode)
            {
                case "PM":
                    lb1.Text = "Purchase Manager";
                    btn1.Text = "Agreement";
                    btn2.Text = "Supplier";
                    btn3.Text = "Mapping";
                    btn4.Text = "Edit User Information";
                    break;
                case "RM":
                    lb1.Text = "Restaurant Manager";
                    sda = new MySqlDataAdapter("select RestName,Restaurant.RestNo from Staff,StaffRestaurant,Restaurant where Staff.StaffNo='"+StaffNo+"' and Staff.StaffNo = StaffRestaurant.StaffNo and StaffRestaurant.RestNo = Restaurant.RestNo;", cnn);
                    dt = new DataTable();
                    sda.Fill(dt);
                    lb1.Text = "The Restaurant Manager of \n" + dt.Rows[0][0].ToString();
                    this.restNo = dt.Rows[0][1].ToString();
                    btn1.Text = "Purchase Request";
                    btn2.Visible = false; //to be added function or keep invisible
                    btn3.Text = "Edit User Information";
                    btn4.Text = "Edit Restaurant Information";
                    break;
                case "CM":
                    lb1.Text = "Category Manager";
                    btn1.Text = "Category";
                    btn2.Text = "Item";
                    btn3.Text = "Stock";
                    btn4.Text = "Edit User Information";
                    break;
                case "WC":
                    lb1.Text = "Warehouse Clerk";
                    btn1.Text = "Despatch Instruction";
                    btn2.Text = "Delivery Note";
                    btn3.Text = "Stock";
                    btn4.Text = "Edit User Information";
                    break;
                case "AD":
                    lb1.Text = "Accounting Department";
                    btn1.Text = "Complete Payment";
                    btn2.Text = "Payment Record";
                    btn3.Visible = false; //to be added function or keep invisible
                    btn4.Text = "Edit User Information";
                    break;
                case "AM":
                    lb1.Text = "ADMIN";
                    btn1.Text = "User";
                    btn2.Text = "Restaurant";
                    btn3.Text = "Supplier";
                    btn4.Visible = false; //to be added function or keep invisible
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
                    EditMenu em = new EditMenu(this, 0);
                    em.Show();
                    break;
                case "RM":
                    this.Hide();
                    PurchaseRequest pr = new PurchaseRequest(this,"R001",StaffNo);
                    pr.Show();
                    break;
                case "PM":
                    this.Hide();
                    TypeofAgreementMenu tam = new TypeofAgreementMenu(staffName, this);
                    tam.Show();
                    break;
                case "CM":
                    this.Hide();
                    Category cat = new Category(this);
                    cat.Show();
                    break;
                case "WC":
                    this.Hide();
                    WHViewDPI dpi = new WHViewDPI(this);
                    dpi.Show();
                    break;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            switch (deptCode)
            {
                case "AM":
                    this.Hide();
                    EditMenu em = new EditMenu(this, 1);
                    em.Show();
                    break;
                case "PM":
                    this.Hide();
                    SupplierMenu sm = new SupplierMenu(this);
                    sm.Show();
                    break;
                case "CM":
                    this.Hide();
                    Item itm = new Item(this);
                    itm.Show();
                    break;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            switch (deptCode)
            {
                case "RM":
                    this.Hide();
                    EditRest erest = new EditRest(restNo, this);
                    erest.Show();
                    break;
                case "PM":
                case "CM":
                case "WC":
                case "AD":
                    this.Hide();
                    EditAc eac = new EditAc(deptCode, StaffNo, this);
                    eac.Show();
                    break;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            switch (deptCode)
            {
                case "RM":
                    this.Hide();
                    EditAc eac = new EditAc(deptCode, StaffNo, this);
                    eac.Show();
                    break;
                case "AM":
                    this.Hide();
                    SupplierMenu sm = new SupplierMenu(this);
                    sm.Show();
                    break;
                case "PM":
                    this.Hide();
                    PRMapping prm = new PRMapping(this);
                    prm.Show();
                    break;
                case "CM":
                    this.Hide();
                    Stock stk = new Stock(this);
                    stk.Show();
                    break;
                case "WC":
                    this.Hide();
                    WHStock wstk = new WHStock(this);
                    wstk.Show();
                    break;
            }
        }
    }
}
