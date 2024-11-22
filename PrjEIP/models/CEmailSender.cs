using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PrjEIP.models
{
    public class CEmailSender
    {
        //發送email的方法,傳入參數有三個分別為:收件者信箱,郵件主旨,郵件內容
        public void SendEmail(string toEmail, string subject, string body)
        {
            string fromEmail = "stetronliang@gmail.com"; // 發送者電子郵件地址
            string fromPassword = "xdxqlwqxricrysma"; // 發送者電子郵件密碼,這邊的密碼是應用程式密碼,並不是真的我的gmail密碼

            // 創建郵件
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(fromEmail);
            mail.To.Add(toEmail);
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true; // 如果是HTML格式的郵件

            // 設置SMTP客戶端
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromEmail, fromPassword),
                EnableSsl = true,
            };
            try
            {
                smtpClient.Send(mail);
                System.Windows.Forms.MessageBox.Show("請從信箱確認驗證碼");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"郵件發送失敗：{ex.Message}");
            }
        }

        //生成隨機字串
        public string GenerateTemporaryPassword(int length = 5)
        {
            //定義一個包含可用字元的字串
            const string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            //stringBuilder是用來建構隨機字串
            StringBuilder result = new StringBuilder();
            //random物件是用來產生隨機數字
            Random random = new Random();
            //不停循環直到生成指定長度的隨機字串
            while (length-- > 0)
            {
                //從validChars這個字串當中隨機選取一個字元並且插進去result當中
                //所以就會不斷重複這個動作直到字元達到指定的長度
                result.Append(validChars[random.Next(validChars.Length)]);
            }
            return result.ToString();
        }
        //這個方法是將臨時密碼傳入資料庫裏面覆蓋掉原本的密碼
        public void UpdateTemporaryPassword(string account, string temporaryPassword)
        {
            //string hashedPassword = BCrypt.Net.BCrypt.HashPassword(temporaryPassword);

            string sql = $"UPDATE Employee SET fEmpPassword = @K_Password WHERE fEmpAccount = @K_Account";
            using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PrjEIP;Integrated Security=True;"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add(new SqlParameter("K_Password", temporaryPassword));
                    cmd.Parameters.Add(new SqlParameter("K_Account", account));
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        //將系統發送的驗證碼存入到資料庫當中,後續logIn登入也要比對這個驗證碼
        public void UpdateVerifyPassword(string account, string verifyPassword)
        {
            string sql = $"UPDATE Employee SET fEmpVerify = @K_Verify WHERE fEmpAccount = @K_Account";
            using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PrjEIP;Integrated Security=True;"))
            {
                con.Open();
                using(SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add(new SqlParameter("K_Verify", (object)verifyPassword));
                    cmd.Parameters.Add(new SqlParameter("K_Account", (object)account));
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}
