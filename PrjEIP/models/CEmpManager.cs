using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace PrjEIP.models
{
    public class CEmpManager
    {
        public DialogResult _passwordIsNull { get; set; }
        public void create(CEmployee p)
        {
            //設定sql字串,讓這個創造方法將數值加入CEmployee裡面
            //要使用parameter防止sql injection
            string sql = $"INSERT INTO Employee (fEmpName,fEmpGender,fEmpAge,fEmpHeight,fEmpWeight,fEmpMarriage,fEmpStatus,fEmpHireDate,fEmpCreatedDate,fEmpUpdatedDate,fEmpPositionId,fEmpGradeId,fEmpSupervisorId,fEmpDepartmentId,fEmpBirthday,fEmpPermissionId) VALUES (@K_fEmpName,@K_fEmpGender,@K_fEmpAge,@K_fEmpHeight,@K_fEmpWeight,@K_fEmpMarriage,@K_fEmpStatus,@K_fEmpHireDate,@K_fEmpCreatedDate,@K_fEmpUpdatedDate,@K_fEmpPositionId,@K_fEmpGradeId,@K_fEmpSupervisorId,@K_fEmpDepartmentId,@K_fEmpBirthday,@K_fEmpPermissionId)";
            //設定水管\水龍頭\放進parameter
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=PrjEIP;Integrated Security=True;";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("K_fEmpName", (object)p.fEmpName));
            cmd.Parameters.Add(new SqlParameter("K_fEmpGender", (object)p.fEmpGender));
            cmd.Parameters.Add(new SqlParameter("K_fEmpAge", (object)p.fEmpAge));
            cmd.Parameters.Add(new SqlParameter("K_fEmpMarriage", (object)p.fEmpMarriage));
            cmd.Parameters.Add(new SqlParameter("K_fEmpHireDate", (object)p.fEmpHireDate));
            cmd.Parameters.Add(new SqlParameter("K_fEmpStatus", (object)p.fEmpStatus));
            cmd.Parameters.Add(new SqlParameter("K_fEmpCreatedDate", (object)p.fEmpCreatedDate));
            cmd.Parameters.Add(new SqlParameter("K_fEmpUpdatedDate", (object)p.fEmpUpdatedDate));
            cmd.Parameters.Add(new SqlParameter("K_fEmpPositionId", (object)p.fEmpPositionId));
            cmd.Parameters.Add(new SqlParameter("K_fEmpGradeId", (object)p.fEmpGradeId));
            cmd.Parameters.Add(new SqlParameter("K_fEmpSupervisorId", (object)p.fEmpSupervisorId));
            cmd.Parameters.Add(new SqlParameter("K_fEmpDepartmentId", (object)p.fEmpDepartmentId));
            cmd.Parameters.Add(new SqlParameter("K_fEmpPermissionId", (object)p.fEmpPermissionId));
            cmd.Parameters.Add(new SqlParameter("K_fEmpBirthday", (object)p.fEmpBirthday));
            cmd.ExecuteNonQuery();
            con.Close();

        }
        //這功能其實就是更新update,將原有的員工資料添加帳號密碼進去
        public void register(CEmployee p)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(p.fEmpAccount);
            string sql = $"UPDATE Employee SET fEmpAccount=@K_Account,fEmpPassword=@K_Password WHERE fEmpId=@K_KId";
            using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PrjEIP;Integrated Security=True;"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add(new SqlParameter("K_Account", (object)p.fEmpAccount));
                    //將雜湊密碼放到parameters裡面與資料庫做連結
                    cmd.Parameters.Add(new SqlParameter("K_Password", (object)hashedPassword));
                    cmd.Parameters.Add(new SqlParameter("K_KId", (object)p.fEmpId));
                    //更新的同時,將更新後的資料放進reader裡面
                    SqlDataReader reader = cmd.ExecuteReader();

                    //撈資料,要執行reader.Read()下面才可以利用reader讀取欄位資料
                    if (reader.Read() && string.IsNullOrEmpty(reader["fEmpPassword"].ToString()))
                    {
                        p = new CEmployee();
                        p.fEmpId = (int)reader["fEmpId"];
                        p.fEmpAccount = reader["fEmpAccount"].ToString();
                        //這邊雜湊密碼可能會出錯
                        hashedPassword = reader["fEmpPassword"].ToString();
                    }
                    else
                    {
                        //如果有密碼
                        _passwordIsNull = DialogResult.OK;
                    }
                    con.Close();
                    if (p == null)
                        return;
                }
            }
        }
    }
}
