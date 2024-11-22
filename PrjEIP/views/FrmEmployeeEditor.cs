using PrjEIP.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PrjEIP.views
{
    public partial class FrmEmployeeEditor : Form
    {
        string _errorMessage = "";
        //要做get\set就要有一個private全域變數
        private CEmployee _Employee;
        public DialogResult isConfirm { get; set; }
        public FrmEmployeeEditor()
        {
            InitializeComponent();
        }

        public CEmployee Employee
        {
            get
            {
                if (_Employee == null)
                    _Employee = new CEmployee();
                _Employee.fEmpName = fbName.filedValue;
                _Employee.fEmpGender = cbGender.Text;
                _Employee.fEmpAge = Convert.ToInt32(fbAge.filedValue);
                _Employee.fEmpMarriage = cbMarriage.Text;
                _Employee.fEmpStatus = cbStatus.Text;
                _Employee.fEmpHireDate = fbHireDate.filedValue;
                _Employee.fEmpCreatedDate = fbCreatedDate.filedValue;
                _Employee.fEmpUpdatedDate = fbUpdatedDate.filedValue;
                _Employee.fEmpPositionId = cbPosition.Text;
                _Employee.fEmpGradeId = cbGrade.Text;
                _Employee.fEmpSupervisorId = Convert.ToInt16(fbSupervisorId.filedValue);
                _Employee.fEmpDepartmentId = cbDepartment.Text;
                _Employee.fEmpBirthday = fbBirthday.filedValue;
                _Employee.fEmpPermissionId = cbPermission.Text;
                _Employee.fEmpPhone = fbPhone.filedValue.ToString();
                _Employee.fEmpAddress = fbAddress.filedValue.ToString();
                _Employee.fEmpEmail = fbEmail.filedValue.ToString();
                _Employee.fEmpPersonalId = fbPersonalId.filedValue.ToString();

                return _Employee;
            }
            set
            {
                _Employee = value;
                fbName.filedValue = _Employee.fEmpName;
                cbGender.Text = _Employee.fEmpGender.ToString();
                fbAge.filedValue = _Employee.fEmpAge.ToString();
                cbMarriage.Text = _Employee.fEmpMarriage;
                cbStatus.Text = _Employee.fEmpStatus.ToString();
                fbHireDate.filedValue = _Employee.fEmpHireDate;
                fbCreatedDate.filedValue = _Employee.fEmpCreatedDate;
                fbUpdatedDate.filedValue = _Employee.fEmpUpdatedDate;
                cbPosition.Text = _Employee.fEmpPositionId.ToString();
                cbGrade.Text = _Employee.fEmpGradeId.ToString();
                fbSupervisorId.filedValue = _Employee.fEmpSupervisorId.ToString();
                cbDepartment.Text = _Employee.fEmpDepartmentId.ToString();
                fbBirthday.filedValue = _Employee.fEmpBirthday;
                cbPermission.Text = _Employee.fEmpPermissionId.ToString();
                fbEmail.filedValue = _Employee.fEmpEmail;
                fbAddress.filedValue = _Employee.fEmpAddress;
                fbPhone.filedValue = _Employee.fEmpPhone;
                fbPersonalId.filedValue = _Employee.fEmpPersonalId;
                //如果pitcutureBox1不是空的,就把資料庫的照片讀出來
                if (_Employee.fEmpImage != null)
                {
                    try
                    {
                        Stream streamImage = new MemoryStream(_Employee.fEmpImage);
                        pictureBox1.Image = Bitmap.FromStream(streamImage);
                    }
                    catch { }
                }
            }
        }

        private void fbConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbStatus.Text) || string.IsNullOrEmpty(cbPosition.Text) || string.IsNullOrEmpty(cbPermission.Text) || string.IsNullOrEmpty(cbMarriage.Text) || string.IsNullOrEmpty(cbGrade.Text) || string.IsNullOrEmpty(cbGender.Text) || string.IsNullOrEmpty(cbDepartment.Text))
            {
                return;
            }
            //設定開關isDialogOK作為確認有按下此按鈕
            if (IsCorrectInput())
            {
                this.isConfirm = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(_errorMessage);
                Close();
            }
        }

        private void fbCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cbStatus.Text) || string.IsNullOrEmpty(cbPosition.Text) || string.IsNullOrEmpty(cbPermission.Text) || string.IsNullOrEmpty(cbMarriage.Text) || string.IsNullOrEmpty(cbGrade.Text) || string.IsNullOrEmpty(cbGender.Text) || string.IsNullOrEmpty(cbDepartment.Text))
                {
                    Close();
                    return;
                }
                Close();
            }
            catch
            { throw new Exception(); }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            //使檔案管理員視窗可以篩選檔案類型,人看的名稱|指定的檔案類型
            openFileDialog1.Filter = "我的員工|*.jpg";
            //如果沒有點下確認,就執行return
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            pictureBox1.Image = Bitmap.FromFile(openFileDialog1.FileName);
            //開啟串流,與資料庫做連結
            FileStream imgStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(imgStream);
            this.Employee.fEmpImage = reader.ReadBytes((int)imgStream.Length);
            reader.Close();
            imgStream.Close();
        }
        //判斷手機與電子信箱的輸入格式是否確的方法
        private bool IsCorrectInput()
        {

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string phonePattern = @"^09\d{2}-\d{3}-\d{3}$";
            string personalId = @"^[A-Z][12]\d{8}$";
            //比對email&手機號碼是否有符合格式
            if (!Regex.IsMatch(fbEmail.filedValue, emailPattern) && !Regex.IsMatch(fbPhone.filedValue, phonePattern))
            {
                _errorMessage = $"email以及手機格式輸入錯誤";

            }
            else if (!Regex.IsMatch(fbEmail.filedValue, emailPattern))
            {
                _errorMessage = $"email格式輸入錯誤";
            }
            else if (!Regex.IsMatch(fbPhone.filedValue, phonePattern))
            {
                _errorMessage = "手機格式輸入錯誤";
            }
            else if (!Regex.IsMatch(fbPersonalId.filedValue, personalId))
            {
                _errorMessage = "身份證字號格式輸入錯誤";
            }
            else
            {
                _errorMessage = "";
            }
            //如果errorMessage裡面有值,IsNullOrEmpty會回傳true,下面這個三元運算子就會回傳false.然後就把結果return給IsCorrectInput
            return string.IsNullOrEmpty(_errorMessage) ? true : false;

        }
    }
}
