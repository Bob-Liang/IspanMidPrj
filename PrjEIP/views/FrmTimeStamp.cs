using PrjEIP.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization.Configuration;

namespace PrjEIP.views
{
    public partial class FrmTimeStamp : Form
    {
        public FrmTimeStamp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CDateConverter converter = new CDateConverter();
            string sql = "SELECT fEmpHireDate FROM Employee WHERE fEmpId = 31 ";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=PrjEIP;Integrated Security=True;";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                long timeStampString = reader.GetInt64(0);
                DateTime x =converter.FromUnixTimestamp(timeStampString);
                textBox1.Text = x.ToString();
            }
            else
            {
                MessageBox.Show("沒有資料");
            }
        }
    }
}
