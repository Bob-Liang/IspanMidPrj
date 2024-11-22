using PrjEIP.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjEIP.views
{
    public partial class FrmForgotCode : Form
    {

        public FrmForgotCode()
        {
            InitializeComponent();
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            //按下確認按鈕後,比對驗證碼是否正確.
            //驗證碼正確之後就將新密碼覆蓋掉原本資料庫當中的密碼,比對的資料是帳號
            string SqlSelect = "SELECT fEmpPassword FROM Employee WHERE fEmpAccount = @K_Account";
            string tempPassword = "";
            using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PrjEIP;Integrated Security=True;"))
            {
                con.Open();
                //連線開始後,設邊設定為交易的起始點
                //SqlTransaction tran = con.BeginTransaction();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(SqlSelect, con))
                    {
                        cmd.Parameters.Add(new SqlParameter("K_Account", (object)fbEmpAccount.filedValue));
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            tempPassword = reader["fEmpPassword"].ToString();
                        }
                        reader.Close();
                        //這邊加上一秒的等待時間,讓這兩個sql指令有緩衝時間
                        await Task.Delay(1000);

                        //如果有讀取到密碼(臨時密碼),那就讓他與使用者輸入的臨時密碼比對,如果是true就讓他把新密碼覆蓋掉臨時密碼
                        if (fbtempPassword.filedValue.ToString() == tempPassword && textBox1.Text == fbNewPassword2.filedValue && !string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(fbtempPassword.filedValue) && IsVailidPassword(textBox1.Text))
                        {
                            string SqlUpDate = "UPDATE Employee SET fEmpPassword = @K_Password WHERE fEmpAccount=@K_Account";
                            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(textBox1.Text);
                            using (SqlCommand cmd1 = new SqlCommand(SqlUpDate, con))
                            {
                                cmd1.Connection = con;
                                cmd1.CommandText = SqlUpDate;
                                cmd1.Parameters.Add(new SqlParameter("K_Password", (object)hashedPassword));
                                cmd1.Parameters.Add(new SqlParameter("K_Account", (object)fbEmpAccount.filedValue));
                                cmd1.ExecuteNonQuery();
                                con.Close();
                            }
                            MessageBox.Show("密碼已經更新完成,下次再忘記密碼就打屁屁");
                        }
                        else if (textBox1.Text != fbNewPassword2.filedValue && fbtempPassword.filedValue.ToString() == tempPassword)
                        {
                            MessageBox.Show("請確認兩次新密碼輸入結果都相同");
                            con.Close();
                            return;
                        }
                        else if (string.IsNullOrEmpty(textBox1.Text))
                        {
                            MessageBox.Show("密碼請不要留白");
                            con.Close();
                        }
                        else if (string.IsNullOrEmpty(fbtempPassword.filedValue.ToString()))
                        {
                            MessageBox.Show("請輸入驗證碼");
                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("驗證碼輸入錯誤");
                            con.Close();
                            return;
                        }
                    }
                    //提交交易
                    //tran.Commit();
                }
                catch (Exception)
                {
                    throw new Exception();
                }
                finally
                {
                    if (con.State == ConnectionState.Open) { con.Close(); }
                }

            }
            //以上,資料庫臨時密碼已經在tempPassword裡面
        }

        private void FrmForgotCode_Load(object sender, EventArgs e)
        {
            fbNewPassword2.passwordMask = "*".ToCharArray()[0];
        }
        private static bool IsVailidPassword(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*(),.?:{}|<>])(?=.*.{8,})";
            return Regex.IsMatch(password, pattern);
        }

        private void btnGetTempPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(fbEmpAccount.filedValue))
                {
                    MessageBox.Show("請輸入帳號");
                    return;
                }
                if (string.IsNullOrEmpty(fbEmpEmail.filedValue))
                {
                    MessageBox.Show("請輸入電子郵件");
                    return;
                }

                CEmailSender x = new CEmailSender();
                //生成一個隨機的字串並且存到資料庫當中成為一個臨時密碼,給使用者去變更他的新密碼
                x.UpdateTemporaryPassword(fbEmpAccount.filedValue, x.GenerateTemporaryPassword());
                string sql = "SELECT fEmpPassword FROM Employee WHERE fEmpAccount = @K_Account";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=.;Initial Catalog=PrjEIP;Integrated Security=True;";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.Parameters.Add(new SqlParameter("K_Account", (object)fbEmpAccount.filedValue));
                SqlDataReader reader = cmd.ExecuteReader();
                string tempPassword = "";
                //如果有讀到資料
                if (reader.Read())
                {
                    //臨時密碼就會從資料庫當中被存到tempPassword當中
                    tempPassword = reader["fEmpPassword"].ToString();
                }
                else
                {
                    MessageBox.Show("系統發生錯誤,請再次嘗試提取驗證碼");
                    return;
                }
                string recipientEmail = $"{fbEmpEmail.filedValue.ToString()}"; // 收件人電子郵件地址
                string emailSubject = "下次再忘記密碼就打屁屁"; // 郵件主題
                string emailBody = $"<h1>以下是驗證碼</h1><p>{tempPassword}。</p>"; // 郵件內容
                //發送電子信件,提供使用者臨時密碼
                x.SendEmail(recipientEmail, emailSubject, emailBody);
                con.Close();
                //到這邊使用者就會拿到已經在資料庫的臨時密碼,並且會將它輸入到臨時密碼的欄位

            }
            catch
            {
                throw new Exception();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
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
