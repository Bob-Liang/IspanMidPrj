using PrjEIP.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrjEIP.views
{
    public partial class FrmRegister : Form
    {
        public DialogResult isOk { get; set; }

        public FrmRegister()
        {
            InitializeComponent();
        }

        //要有儲存資料的get\set就要有一個private的全域變數,以免背黑鍋
        private CEmployee _Employee;
        public CEmployee Employee
        {
            get
            {
                if (_Employee == null)
                    _Employee = new CEmployee();
                _Employee.fEmpId = Convert.ToInt32(fbEmpId.filedValue);
                _Employee.fEmpAccount = fbAccount.filedValue;
                //_Employee.fEmpPassword = fbPassword.filedValue;
                _Employee.fEmpPassword=textBox1.Text;
                _Employee.fEmpPassword2 = fbPassword2.filedValue;
                return _Employee;
            }
            set
            {
                _Employee = value;
                fbEmpId.filedValue = _Employee.fEmpId.ToString();
                fbAccount.filedValue = _Employee.fEmpAccount;
                //fbPassword.filedValue = _Employee.fEmpPassword;
                fbPassword2.filedValue = _Employee.fEmpPassword2;
                textBox1.Text = _Employee.fEmpPassword.ToString();
            }
        }

        private void fbConfirm_Click(object sender, EventArgs e)
        {
            //帳號要註冊之前,要與資料庫內的資料比對過,不能有相同的
            //設置一個集合變數,等等用來存放資料庫所有帳戶的資料
            List<string> accountList = new List<string>();
            using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PrjEIP;Integrated Security=True;"))
            {
                con.Open();
                string sql = "SELECT fEmpAccount FROM Employee";
                using (SqlCommand cmd = new SqlCommand(sql,con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //將所有讀取到的資料全部放進集合當中
                        while (reader.Read())
                        {
                            accountList.Add(reader["fEmpAccount"].ToString());
                        }
                    }
                }
            }
            //讓集合裡面的所有帳號查看contains是否含有使用者輸入的帳戶資料
            if (accountList.Contains(fbAccount.filedValue.ToString()))
            {
                MessageBox.Show("您輸入的帳號已經有人註冊,請換一個");
                return;
            }

            //尋找並且比對員工的ID才能在指定的ID裡面加入對應該筆資料的帳號與密碼
            if (!IsVailidPassword(textBox1.Text))
            {
                MessageBox.Show("請確保密碼中含有至少一個英文大小寫字母以及至少8個字符");
                return;
            }
            //比對兩次輸入密碼是否相同
            if (textBox1.Text != fbPassword2.filedValue)
            {
                MessageBox.Show("請確認輸入的兩次密碼完全相同");
                return;
            }

            this.isOk = DialogResult.OK;
            Close();
        }

        private void btnCancel(object sender, EventArgs e)
        {
            Close();
        }
        //使用正則表達限制使用者註冊的帳號密碼
        private static bool IsVailidPassword(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*(),.?:{}|<>])(?=.*.{8,})";
            return Regex.IsMatch(password, pattern);
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            //fbPassword.passwordMask = "*".ToCharArray()[0];
            fbPassword2.passwordMask = "*".ToCharArray()[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var strength = CPasswordStrengthChecker.CheckStrength(textBox1.Text.ToString());
            //將密碼的方法呼叫出來之後的結果使用switch case展現在畫面當中
            switch (strength)
            {
                case CPasswordStrengthChecker.PasswordStrength.VeryWeak:
                    lbPasswordStrength.Text = "三歲小孩都可破解";
                    lbPasswordStrength.ForeColor = Color.Red;
                    break;
                case CPasswordStrengthChecker.PasswordStrength.Weak:
                    lbPasswordStrength.Text = "我女兒都可以破解";
                    lbPasswordStrength.ForeColor = Color.OrangeRed;
                    break;
                case CPasswordStrengthChecker.PasswordStrength.Medium:
                    lbPasswordStrength.Text = "我不能破解";
                    lbPasswordStrength.ForeColor = Color.Orange;
                    break;
                case CPasswordStrengthChecker.PasswordStrength.Strong:
                    lbPasswordStrength.Text = "仲仁也不能破解";
                    lbPasswordStrength.ForeColor = Color.Green;
                    break;
                case CPasswordStrengthChecker.PasswordStrength.VeryStrong:
                    lbPasswordStrength.Text = "上帝也不能破解";
                    lbPasswordStrength.ForeColor = Color.DarkGreen;
                    break;

            }
        }
    }
}
