using BCrypt.Net;
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


namespace PrjEIP.views
{
    public partial class FrmLogIn : Form
    {
        private bool isClosde = true;
        private int _counter;
        private string _verify;
        private CEmployee _employee;

        public CEmployee Employee
        {
            get
            {
                _employee.CurrentUser = checkCurrentUser().ToString();
                return _employee;
            }
            //set { }
        }
        //這個方法可以獲取到登入者帳號對應之使用者ID,並且已經將它存入到Employee裡面,直接new出來即可存取到使用者ID的資料
        private string checkCurrentUser()
        {
            string sql = "SELECT fEmpId FROM Employee WHERE fEmpAccount = @K_Account";
            string currentUserId = "";
            //使用資料庫把登入帳號對應的EmpId塞到上面的變數,並且讓這個方法return
            using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PrjEIP;Integrated Security=True;"))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add(new SqlParameter("K_Account", (object)fbAccount.filedValue));
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                                currentUserId = reader["fEmpId"].ToString();
                            con.Close();
                        }
                    }
                }
                catch (Exception) { throw new Exception(); }
                finally { if (con.State == ConnectionState.Open) { con.Close(); } }
            }
            return currentUserId;
        }


        public FrmLogIn()
        {
            InitializeComponent();

        }

        //這是一個方法,用來取得雜湊密碼的值,讓我可以放入verify的參數當中
        private string checkPassword()
        {
            string hashCode = "";
            //sql尋找的是密碼來自於使用者輸入的帳號與資料庫的帳號相同
            string sql = "SELECT fEmpPassword FROM Employee WHERE fEmpAccount = @K_Account";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=PrjEIP;Integrated Security=True;";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("K_Account", (object)fbAccount.filedValue));
            SqlDataReader reader = cmd.ExecuteReader();
            //如果reader有找到密碼來自於,是使用者輸入的帳號對應的帳號之密碼
            //就把reader找到的那筆密碼資料string後指定給hasCode

            if (reader.Read())
                hashCode = reader["fEmpPassword"].ToString();
            con.Close();
            //最後就將這個雜湊的密碼return回去給verify                
            return hashCode;
        }



        private void fbConfirm_Click(object sender, EventArgs e)
        {

            if (BCrypt.Net.BCrypt.Verify(textBox1.Text.ToString(), checkPassword()) && fbVerify.filedValue == _verify)
            {
                isClosde = false;
                MessageBox.Show("登入成功,歡迎使用本系統");
                Close();//關閉FrmLogIn,就會進入main程式表單
            }
            else if (_counter < 3)
            {
                _counter++;
                MessageBox.Show("密碼錯誤,請再嘗試一次");
            }
            else
            {
                MessageBox.Show("登入次數超過上限,請稍後再進行嘗試");
                Application.Exit();
            }
        }

        private void fbRegister_Click(object sender, EventArgs e)
        {
            FrmRegister frm = new FrmRegister();
            CEmpManager x = new CEmpManager();
            try
            {
                frm.ShowDialog();
                if (frm.isOk == DialogResult.OK && x._passwordIsNull != DialogResult.OK)
                {
                    x.register(frm.Employee);
                    MessageBox.Show("註冊帳號密碼成功");
                }
                else
                {
                    MessageBox.Show("請不要亂改別人密碼!");
                }
            }
            catch
            {
                throw new Exception("發生錯誤");
            }
        }

        private void FrmLogIn_FormClosing(object sender, FormClosingEventArgs e)//此為關閉式窗前的生命週期
        {
            //這個function主要是防止有人按掉X就直接跑進系統裡面
            e.Cancel = isClosde;//這個值只要是true就無法關閉此視窗,而預設值為true除非答對密碼才會改成false
        }
        private void fbCancel_Click(object sender, EventArgs e)
        {
            isClosde = false;
            Application.Exit();
        }

        private void fbForgotCode_Click(object sender, EventArgs e)
        {
            FrmForgotCode frm = new FrmForgotCode();
            frm.ShowDialog();
        }

        private void fbGetVerify_Click(object sender, EventArgs e)
        {

            //先提取依據使用者輸入帳號的對應email地址,這邊fbEmpAccount不能null
            CEmailSender cEmailSender = new CEmailSender();
            string emailSubject = "這是系統自動發送的驗證碼信件,請勿回覆";
            //產生一個隨機字串當作驗證碼
            _verify = $"{cEmailSender.GenerateTemporaryPassword()}";
            string emailBody = $"<h1>以下是驗證碼</h1><p>{_verify}</p>";
            //將驗證碼傳入資料庫
            cEmailSender.UpdateVerifyPassword(fbAccount.filedValue, _verify);

            string sql = "SELECT fEmpEmail,fEmpVerify FROM Employee WHERE fEmpAccount = @K_Account";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=PrjEIP;Integrated Security=True;";
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("K_Account", (object)fbAccount.filedValue.ToString()));
            //這邊的reader裡面的值就是email帳號,賦值到userEmail
            SqlDataReader reader = cmd.ExecuteReader();

            string userEmail = "";
            if (reader.Read())
            {
                userEmail = reader["fEmpEmail"].ToString();
                _verify = reader["fEmpVerify"].ToString();
            }
            //發送驗證碼到指定的email地址
            if (!string.IsNullOrEmpty(fbAccount.filedValue))
            {
                cEmailSender.SendEmail(userEmail, emailSubject, emailBody);
            }
            else
            {
                MessageBox.Show("要填入帳號才可以拿到驗證碼喔");
                return;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            var strength = CPasswordStrengthChecker.CheckStrength(textBox1.Text.ToString());
            //使用switch來顯示strength的各種情況
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
