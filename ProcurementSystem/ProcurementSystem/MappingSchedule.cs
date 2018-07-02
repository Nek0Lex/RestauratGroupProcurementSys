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
	public partial class MappingSchedule : Form
	{
		MySqlConnection cnn = new MySqlConnection("server=code4cat.me;user id=jackysc;password=123456;database=procurement;SslMode=none;Allow User Variables=True;");

		public MappingSchedule()
		{
			InitializeComponent();
			cnn.Open();
			MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM Category;", cnn);
			cnn.Close();
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			cnn.Open();
			MySqlCommand updateTime = new MySqlCommand("SET @time1 = '10:00'; ", cnn);
			updateTime.ExecuteNonQuery();
			cnn.Close();
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
