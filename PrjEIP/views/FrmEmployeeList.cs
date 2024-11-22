using PrjEIP.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace PrjEIP.views
{
    public partial class FrmEmployeeList : Form
    {
        //宣告離線三件套,因為這樣才不會一儲存就消失,且可以在不同的function共用
        SqlDataAdapter _da;
        SqlCommandBuilder _builder;
        int _position = -1;//如果預設給0,他就會刪掉第一筆資料,這邊用來記錄當前的索引值

        public FrmEmployeeList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CDateConverter converter = new CDateConverter();
            FrmEmployeeEditor frm = new FrmEmployeeEditor();
            //frm.MdiParent = this.MdiParent;
            //frm.Text = "FrmMain";//使Main成為這個Editor的父表單
            frm.ShowDialog();
            //如果時間格式輸入錯誤就直接return
            if (converter.ConvertToUnixTimestamp(frm.Employee.fEmpHireDate) == -1 || converter.ConvertToUnixTimestamp(frm.Employee.fEmpUpdatedDate) == -1 || converter.ConvertToUnixTimestamp(frm.Employee.fEmpCreatedDate) == -1 || converter.ConvertToUnixTimestamp(frm.Employee.fEmpBirthday) == -1)
            {
                return;
            }
            //如果有按下確認按鈕就執行if裡面的程式碼
            if (frm.isConfirm == DialogResult.OK)
            {
                DataTable dt = dataGridView1.DataSource as DataTable;
                DataRow row = dt.NewRow();
                row["fEmpName"] = frm.Employee.fEmpName;
                row["fEmpGender"] = frm.Employee.fEmpGender.ToUpper();
                row["fEmpAge"] = frm.Employee.fEmpAge;
                row["fEmpMarriage"] = frm.Employee.fEmpMarriage.ToUpper();
                row["fEmpStatus"] = frm.Employee.fEmpStatus.ToUpper();
                row["fEmpHireDate"] = converter.ConvertToUnixTimestamp(frm.Employee.fEmpHireDate);
                row["fEmpCreatedDate"] = converter.ConvertToUnixTimestamp(frm.Employee.fEmpCreatedDate);
                row["fEmpUpdatedDate"] = converter.ConvertToUnixTimestamp(frm.Employee.fEmpUpdatedDate);
                row["fEmpPositionId"] = frm.Employee.fEmpPositionId;
                row["fEmpGradeId"] = frm.Employee.fEmpGradeId;
                row["fEmpSupervisorId"] = frm.Employee.fEmpSupervisorId;
                row["fEmpDepartmentId"] = frm.Employee.fEmpDepartmentId;
                row["fEmpBirthday"] = converter.ConvertToUnixTimestamp(frm.Employee.fEmpBirthday);
                row["fEmpPermissionId"] = frm.Employee.fEmpPermissionId;
                row["fEmpImage"] = frm.Employee.fEmpImage;
                row["fEmpPhone"] = frm.Employee.fEmpPhone;
                row["fEmpEmail"] = frm.Employee.fEmpEmail;
                row["fEmpAddress"] = frm.Employee.fEmpAddress;
                row["fEmpPersonalId"] = frm.Employee.fEmpPersonalId;
                //資料全部填完之後要在指定回去給綠框裡面的rows裡面的row
                dt.Rows.Add(row);
                _da.Update(dataGridView1.DataSource as DataTable);
                //MessageBox.Show("新增資料成功");
                resetGridStyle();
            }

        }
        private void displayBySql(string sql, bool isKeyword)//這邊多一個參數bool是要給如果語法裡面有parameter的字串就要變成true
        {
            //連線設定,不管離線與連線型都一樣
            //這邊用離線型來做dataGridView
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=.;Initial Catalog=PrjEIP;Integrated Security=True;";
            con.Open();
            //設定水龍頭連線,字串
            _da = new SqlDataAdapter(sql, con);
            //幫查詢的textbox做一個防止injection,可以給Search以及Filter來使用
            if (isKeyword)
            {
                //這是做給搜尋的box防止sql injection
                _da.SelectCommand.Parameters.Add(new SqlParameter("K_Keyword", $"%{(object)textBox1.Text}%"));
            }
            //設定把builder new出來裝進去_da
            _builder = new SqlCommandBuilder();
            _builder.DataAdapter = _da;
            //要把水龍頭資料放進水桶ds裡面
            DataSet ds = new DataSet();
            _da.Fill(ds);
            con.Close();

            dataGridView1.DataSource = ds.Tables[0];
            resetGridStyle();
        }

        private void FrmEmployeeList_Load(object sender, EventArgs e)
        {
            displayBySql("SELECT * FROM Employee", false);
            //顯示索引位置
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //先確定索引位置,如果小於0就不動作直接return
            if (_position < 0) return;

            //dataGridView想要刪除資料的話必須透過綠框table去刪除裡面的橘框row
            //刪除dataSet>dataTable>dataRow
            DataRow row = (dataGridView1.DataSource as DataTable).Rows[_position];
            row.Delete();
            //刪除之後要更新dataSet裡面的資料
            _da.Update(dataGridView1.DataSource as DataTable);
            resetGridStyle();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //rowEnter的事件裡面的e.RowIndex就是當前的row的index,它代表著dataGridView裡面選取的index,類似於listbox的selected

            _position = e.RowIndex;

            //確認玩position之後才可以給別的CRUD去做使用參考
        }

        private void FrmEmployeeList_FormClosed(object sender, FormClosedEventArgs e)
        {
            //關閉視窗之後要將所有變更的資料重新update一次
            //將黑框dataSet裡面的綠框dataTable重新整理一次
            _da.Update(dataGridView1.DataSource as DataTable);
        }

        private void btnEditor_Click(object sender, EventArgs e)
        {
            //修改做的事情核心:就是將選取的該筆資料放進編輯表單裡面show出來,然後按下確定的時候又把表單裡面的值

            //如果索引值小於0就不動作直接return
            if (_position < 0) return;
            CDateConverter converter = new CDateConverter();
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow row = dt.Rows[_position];//這邊的position就是靠rowEnter事件取得位置
            //要將編輯畫面以及容器物件都new出來
            FrmEmployeeEditor frm = new FrmEmployeeEditor();
            CEmployee x = new CEmployee();

            //將資料庫當中的時間戳轉換成我指定的時間格式
            long.TryParse(row["fEmpHireDate"].ToString(), out long timeStampHireDate);
            DateTime timeStampHireDate1 = converter.FromUnixTimestamp(timeStampHireDate);
            long.TryParse(row["fEmpCreatedDate"].ToString(), out long timeStampCreatedDate);
            DateTime timeStampCreateDate1 = converter.FromUnixTimestamp(timeStampCreatedDate);
            long.TryParse(row["fEmpUpdatedDate"].ToString(), out long timeStampUpdatedDate);
            DateTime timeStampUpdatedDate1 = converter.FromUnixTimestamp(timeStampUpdatedDate);
            long.TryParse(row["fEmpBirthday"].ToString(), out long timeStampBirthday);
            DateTime timeStampBirthday1 = converter.FromUnixTimestamp(timeStampBirthday);

            //然後將畫面中所有的值放到物件當中
            x.fEmpName = Convert.ToString(row["fEmpName"]);
            x.fEmpGender = Convert.ToString(row["fEmpGender"]);
            x.fEmpAge = Convert.ToInt32(row["fEmpAge"]);
            x.fEmpMarriage = Convert.ToString(row["fEmpMarriage"]);
            x.fEmpStatus = Convert.ToString(row["fEmpStatus"]);
            x.fEmpHireDate = timeStampHireDate1.ToString("yyyyMMdd");
            x.fEmpCreatedDate = timeStampCreateDate1.ToString("yyyyMMdd");
            x.fEmpUpdatedDate = timeStampUpdatedDate1.ToString("yyyyMMdd");
            x.fEmpPositionId = (row["fEmpPositionId"].ToString());
            x.fEmpGradeId = (row["fEmpGradeId"].ToString());
            x.fEmpSupervisorId = Convert.ToInt32(row["fEmpSupervisorId"]);
            x.fEmpDepartmentId = (row["fEmpDepartmentId"].ToString());
            x.fEmpBirthday = timeStampBirthday1.ToString("yyyyMMdd");
            x.fEmpPermissionId = (row["fEmpPermissionId"].ToString());
            x.fEmpEmail = Convert.ToString(row["fEmpEmail"]);
            x.fEmpAddress = Convert.ToString(row["fEmpAddress"]);
            x.fEmpPhone = Convert.ToString(row["fEmpPhone"]);
            x.fEmpPersonalId = Convert.ToString(row["fEmpPersonalId"]);

            //如果資料庫當中不是null才會讀取圖片
            if (row["fEmpImage"] != DBNull.Value)
                x.fEmpImage = (byte[])row["fEmpImage"];

            //最後再將物件裡面所有的值指定給容器,整個顯示
            frm.Employee = x;
            frm.ShowDialog();
            //在畫面有修改的值之後
            //如果有按下確定
            if (converter.ConvertToUnixTimestamp(frm.Employee.fEmpHireDate) == -1 || converter.ConvertToUnixTimestamp(frm.Employee.fEmpUpdatedDate) == -1 || converter.ConvertToUnixTimestamp(frm.Employee.fEmpCreatedDate) == -1 || converter.ConvertToUnixTimestamp(frm.Employee.fEmpBirthday) == -1)
            {
                return;
            }
            if (frm.isConfirm == DialogResult.OK)
            {
                //dataRow裡面的資料就會直接指定到畫面裡面使用者輸入的值
                row["fEmpName"] = frm.Employee.fEmpName;
                row["fEmpGender"] = frm.Employee.fEmpGender.ToUpper();
                row["fEmpAge"] = frm.Employee.fEmpAge;
                row["fEmpMarriage"] = frm.Employee.fEmpMarriage.ToUpper();
                row["fEmpStatus"] = frm.Employee.fEmpStatus.ToUpper();
                row["fEmpHireDate"] = converter.ConvertToUnixTimestamp(frm.Employee.fEmpHireDate);
                row["fEmpCreatedDate"] = converter.ConvertToUnixTimestamp(frm.Employee.fEmpCreatedDate);
                row["fEmpUpdatedDate"] = converter.ConvertToUnixTimestamp(frm.Employee.fEmpUpdatedDate);
                row["fEmpPositionId"] = frm.Employee.fEmpPositionId;
                row["fEmpGradeId"] = frm.Employee.fEmpGradeId;
                row["fEmpSupervisorId"] = frm.Employee.fEmpSupervisorId;
                row["fEmpDepartmentId"] = frm.Employee.fEmpDepartmentId;
                row["fEmpBirthday"] = converter.ConvertToUnixTimestamp(frm.Employee.fEmpBirthday);
                row["fEmpPermissionId"] = frm.Employee.fEmpPermissionId;
                row["fEmpImage"] = frm.Employee.fEmpImage;
                row["fEmpEmail"] = frm.Employee.fEmpEmail;
                row["fEmpAddress"] = frm.Employee.fEmpAddress;
                row["fEmpPhone"] = frm.Employee.fEmpPhone;
                row["fEmpPersonalId"] = frm.Employee.fEmpPersonalId;
                //離線型的執行完資料變動之後都要水龍頭update 

                _da.Update(dataGridView1.DataSource as DataTable);
                MessageBox.Show("資料修改成功");
                resetGridStyle();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Employee WHERE fEmpId LIKE @K_Keyword OR fEmpName LIKE @K_Keyword OR fEmpGender LIKE @K_Keyword OR fEmpAge LIKE @K_Keyword OR fEmpMarriage LIKE @K_Keyword OR fEmpStatus LIKE @K_Keyword OR fEmpHireDate LIKE @K_Keyword OR fEmpCreatedDate LIKE @K_Keyword OR fEmpUpdatedDate LIKE @K_Keyword OR fEmpPositionId LIKE @K_Keyword OR fEmpGradeId LIKE @K_Keyword OR fEmpSupervisorId LIKE @K_Keyword OR fEmpDepartmentId LIKE @K_Keyword OR fEmpBirthday LIKE @K_Keyword OR fEmpPermissionId LIKE @K_Keyword OR fEmpEmail LIKE @K_Keyword OR fEmpPhone LIKE @K_Keyword OR fEmpAddress LIKE @K_Keyword";
            displayBySql(sql, true);//第二個參數是true,因為這邊要防止injection有使用parameter key
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //由於載入程式時,就有display將全部資料秀出,所以只需要寫出遍歷全部資料的雙迴圈foreach然後指定texbox裡面的值有被資料庫裡面的資料值包含
            //然後針對該筆資料改變style
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex == 0) continue;//如果索引值在第一筆,也就是fId的時候就不會進行搜尋然後跳過

                    if (cell.Value == null)
                    {
                        cell.Value = string.Empty; // 或其他適當的預設值 
                    }
                    //要讓第二次篩選資料顏色改變時,第一筆的顏色變回初始值
                    cell.Style.BackColor = row.Cells[0].Style.BackColor;
                    //報錯訊息:cell.value=null
                    if (cell.Value.ToString().Contains(textBox1.Text))
                        cell.Style.BackColor = Color.Yellow;
                }
            }
        }
        //重設欄位畫面style的方法
        private void resetGridStyle()
        {
            //設定欄位的寬度
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 50;
            dataGridView1.Columns[3].Width = 50;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 130;
            dataGridView1.Columns[7].Width = 130;
            dataGridView1.Columns[8].Width = 130;
            dataGridView1.Columns[9].Width = 50;
            dataGridView1.Columns[10].Width = 50;
            dataGridView1.Columns[11].Width = 50;
            dataGridView1.Columns[12].Width = 50;
            dataGridView1.Columns[13].Width = 130;
            dataGridView1.Columns[14].Width = 50;
            dataGridView1.Columns[15].Width = 130;
            dataGridView1.Columns[16].Width = 50;
            //使上下兩個列的顏色不同,那就要foreach每一個row然後

            bool isColorChanged = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                isColorChanged = !isColorChanged;
                //設定row的預設style
                row.DataGridView.DefaultCellStyle.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
                row.DataGridView.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                if (isColorChanged)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(238, 238, 242);
            }

        }

    }
}
