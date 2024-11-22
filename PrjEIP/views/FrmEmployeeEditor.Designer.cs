namespace PrjEIP.views
{
    partial class FrmEmployeeEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fbConfirm = new System.Windows.Forms.Button();
            this.fbCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbMarriage = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbGrade = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbPermission = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.fbPersonalId = new PrjEIP.models.fieldbox();
            this.fbPhone = new PrjEIP.models.fieldbox();
            this.fbEmail = new PrjEIP.models.fieldbox();
            this.fbAddress = new PrjEIP.models.fieldbox();
            this.fbBirthday = new PrjEIP.models.fieldbox();
            this.fbSupervisorId = new PrjEIP.models.fieldbox();
            this.fbUpdatedDate = new PrjEIP.models.fieldbox();
            this.fbCreatedDate = new PrjEIP.models.fieldbox();
            this.fbHireDate = new PrjEIP.models.fieldbox();
            this.fbAge = new PrjEIP.models.fieldbox();
            this.fbName = new PrjEIP.models.fieldbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fbConfirm
            // 
            this.fbConfirm.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbConfirm.Location = new System.Drawing.Point(969, 595);
            this.fbConfirm.Name = "fbConfirm";
            this.fbConfirm.Size = new System.Drawing.Size(103, 53);
            this.fbConfirm.TabIndex = 3;
            this.fbConfirm.Text = "確認";
            this.fbConfirm.UseVisualStyleBackColor = true;
            this.fbConfirm.Click += new System.EventHandler(this.fbConfirm_Click);
            // 
            // fbCancel
            // 
            this.fbCancel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbCancel.Location = new System.Drawing.Point(835, 595);
            this.fbCancel.Name = "fbCancel";
            this.fbCancel.Size = new System.Drawing.Size(103, 53);
            this.fbCancel.TabIndex = 3;
            this.fbCancel.Text = "取消";
            this.fbCancel.UseVisualStyleBackColor = true;
            this.fbCancel.Click += new System.EventHandler(this.fbCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "員工基本資料新增/編輯";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1135, 1);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(742, 93);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 377);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(868, 505);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 31);
            this.label3.TabIndex = 25;
            this.label3.Text = "點兩下可以載入圖片";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(2, 479);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(368, 31);
            this.label4.TabIndex = 31;
            this.label4.Text = "手機號碼格式為:XXXX-XXX-XXX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(8, 595);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(433, 31);
            this.label5.TabIndex = 32;
            this.label5.Text = "電子信箱格式為:XXXX@example.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(473, 275);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 31);
            this.label6.TabIndex = 33;
            this.label6.Text = "時間輸入格式:yyyyMMdd";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(473, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(296, 31);
            this.label7.TabIndex = 34;
            this.label7.Text = "時間輸入格式:yyyyMMdd";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(473, 412);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(296, 31);
            this.label8.TabIndex = 35;
            this.label8.Text = "時間輸入格式:yyyyMMdd";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(469, 533);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(296, 31);
            this.label9.TabIndex = 36;
            this.label9.Text = "時間輸入格式:yyyyMMdd";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbGender.Location = new System.Drawing.Point(284, 423);
            this.cbGender.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(127, 20);
            this.cbGender.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(281, 395);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 31);
            this.label10.TabIndex = 40;
            this.label10.Text = "性別";
            // 
            // cbMarriage
            // 
            this.cbMarriage.FormattingEnabled = true;
            this.cbMarriage.Items.AddRange(new object[] {
            "已婚",
            "未婚"});
            this.cbMarriage.Location = new System.Drawing.Point(285, 307);
            this.cbMarriage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbMarriage.Name = "cbMarriage";
            this.cbMarriage.Size = new System.Drawing.Size(127, 20);
            this.cbMarriage.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(285, 275);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 31);
            this.label12.TabIndex = 42;
            this.label12.Text = "婚姻狀態";
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbDepartment.Location = new System.Drawing.Point(284, 363);
            this.cbDepartment.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(127, 20);
            this.cbDepartment.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(285, 337);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 31);
            this.label11.TabIndex = 44;
            this.label11.Text = "部門ID";
            // 
            // cbGrade
            // 
            this.cbGrade.FormattingEnabled = true;
            this.cbGrade.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbGrade.Location = new System.Drawing.Point(288, 147);
            this.cbGrade.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.Size = new System.Drawing.Size(127, 20);
            this.cbGrade.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(292, 116);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 31);
            this.label13.TabIndex = 46;
            this.label13.Text = "職級ID";
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbPosition.Location = new System.Drawing.Point(288, 93);
            this.cbPosition.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(127, 20);
            this.cbPosition.TabIndex = 47;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(292, 59);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 31);
            this.label14.TabIndex = 48;
            this.label14.Text = "職位ID";
            // 
            // cbPermission
            // 
            this.cbPermission.FormattingEnabled = true;
            this.cbPermission.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbPermission.Location = new System.Drawing.Point(288, 193);
            this.cbPermission.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbPermission.Name = "cbPermission";
            this.cbPermission.Size = new System.Drawing.Size(127, 20);
            this.cbPermission.TabIndex = 49;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(292, 168);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 31);
            this.label15.TabIndex = 50;
            this.label15.Text = "權限ID";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "在線社畜",
            "離線社畜"});
            this.cbStatus.Location = new System.Drawing.Point(284, 252);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(127, 20);
            this.cbStatus.TabIndex = 51;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(285, 217);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 31);
            this.label16.TabIndex = 52;
            this.label16.Text = "在職狀態";
            // 
            // fbPersonalId
            // 
            this.fbPersonalId.filedName = "身分證字號";
            this.fbPersonalId.filedValue = "1";
            this.fbPersonalId.Location = new System.Drawing.Point(452, 572);
            this.fbPersonalId.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.fbPersonalId.Name = "fbPersonalId";
            this.fbPersonalId.passwordMask = '\0';
            this.fbPersonalId.Size = new System.Drawing.Size(219, 76);
            this.fbPersonalId.TabIndex = 53;
            // 
            // fbPhone
            // 
            this.fbPhone.filedName = "手機號碼";
            this.fbPhone.filedValue = "1";
            this.fbPhone.Location = new System.Drawing.Point(8, 395);
            this.fbPhone.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.fbPhone.Name = "fbPhone";
            this.fbPhone.passwordMask = '\0';
            this.fbPhone.Size = new System.Drawing.Size(219, 76);
            this.fbPhone.TabIndex = 23;
            // 
            // fbEmail
            // 
            this.fbEmail.filedName = "電子信箱";
            this.fbEmail.filedValue = "1";
            this.fbEmail.Location = new System.Drawing.Point(8, 517);
            this.fbEmail.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.fbEmail.Name = "fbEmail";
            this.fbEmail.passwordMask = '\0';
            this.fbEmail.Size = new System.Drawing.Size(219, 76);
            this.fbEmail.TabIndex = 22;
            // 
            // fbAddress
            // 
            this.fbAddress.filedName = "住址";
            this.fbAddress.filedValue = "1";
            this.fbAddress.Location = new System.Drawing.Point(12, 147);
            this.fbAddress.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.fbAddress.Name = "fbAddress";
            this.fbAddress.passwordMask = '\0';
            this.fbAddress.Size = new System.Drawing.Size(219, 76);
            this.fbAddress.TabIndex = 21;
            // 
            // fbBirthday
            // 
            this.fbBirthday.filedName = "生日";
            this.fbBirthday.filedValue = "date";
            this.fbBirthday.Location = new System.Drawing.Point(473, 443);
            this.fbBirthday.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.fbBirthday.Name = "fbBirthday";
            this.fbBirthday.passwordMask = '\0';
            this.fbBirthday.Size = new System.Drawing.Size(219, 83);
            this.fbBirthday.TabIndex = 17;
            // 
            // fbSupervisorId
            // 
            this.fbSupervisorId.filedName = "主管ID";
            this.fbSupervisorId.filedValue = "1";
            this.fbSupervisorId.Location = new System.Drawing.Point(12, 310);
            this.fbSupervisorId.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.fbSupervisorId.Name = "fbSupervisorId";
            this.fbSupervisorId.passwordMask = '\0';
            this.fbSupervisorId.Size = new System.Drawing.Size(219, 83);
            this.fbSupervisorId.TabIndex = 15;
            // 
            // fbUpdatedDate
            // 
            this.fbUpdatedDate.filedName = "資料更新日期";
            this.fbUpdatedDate.filedValue = "date";
            this.fbUpdatedDate.Location = new System.Drawing.Point(473, 307);
            this.fbUpdatedDate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.fbUpdatedDate.Name = "fbUpdatedDate";
            this.fbUpdatedDate.passwordMask = '\0';
            this.fbUpdatedDate.Size = new System.Drawing.Size(219, 83);
            this.fbUpdatedDate.TabIndex = 12;
            // 
            // fbCreatedDate
            // 
            this.fbCreatedDate.filedName = "資料創建日期";
            this.fbCreatedDate.filedValue = "date";
            this.fbCreatedDate.Location = new System.Drawing.Point(473, 187);
            this.fbCreatedDate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.fbCreatedDate.Name = "fbCreatedDate";
            this.fbCreatedDate.passwordMask = '\0';
            this.fbCreatedDate.Size = new System.Drawing.Size(219, 83);
            this.fbCreatedDate.TabIndex = 11;
            // 
            // fbHireDate
            // 
            this.fbHireDate.filedName = "雇用日期";
            this.fbHireDate.filedValue = "date";
            this.fbHireDate.Location = new System.Drawing.Point(473, 77);
            this.fbHireDate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.fbHireDate.Name = "fbHireDate";
            this.fbHireDate.passwordMask = '\0';
            this.fbHireDate.Size = new System.Drawing.Size(219, 83);
            this.fbHireDate.TabIndex = 10;
            // 
            // fbAge
            // 
            this.fbAge.filedName = "年齡";
            this.fbAge.filedValue = "1";
            this.fbAge.Location = new System.Drawing.Point(12, 231);
            this.fbAge.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.fbAge.Name = "fbAge";
            this.fbAge.passwordMask = '\0';
            this.fbAge.Size = new System.Drawing.Size(203, 76);
            this.fbAge.TabIndex = 2;
            // 
            // fbName
            // 
            this.fbName.filedName = "姓名";
            this.fbName.filedValue = "Name";
            this.fbName.Location = new System.Drawing.Point(12, 71);
            this.fbName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.fbName.Name = "fbName";
            this.fbName.passwordMask = '\0';
            this.fbName.Size = new System.Drawing.Size(203, 83);
            this.fbName.TabIndex = 0;
            // 
            // FrmEmployeeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 783);
            this.Controls.Add(this.fbPersonalId);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbPermission);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbGrade);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbMarriage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fbPhone);
            this.Controls.Add(this.fbEmail);
            this.Controls.Add(this.fbAddress);
            this.Controls.Add(this.fbBirthday);
            this.Controls.Add(this.fbSupervisorId);
            this.Controls.Add(this.fbUpdatedDate);
            this.Controls.Add(this.fbCreatedDate);
            this.Controls.Add(this.fbHireDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fbCancel);
            this.Controls.Add(this.fbConfirm);
            this.Controls.Add(this.fbAge);
            this.Controls.Add(this.fbName);
            this.Name = "FrmEmployeeEditor";
            this.Text = "FrmEmployeeEditor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private models.fieldbox fbName;
        private models.fieldbox fbAge;
        private System.Windows.Forms.Button fbConfirm;
        private System.Windows.Forms.Button fbCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private models.fieldbox fbHireDate;
        private models.fieldbox fbCreatedDate;
        private models.fieldbox fbUpdatedDate;
        private models.fieldbox fbSupervisorId;
        private models.fieldbox fbBirthday;
        private models.fieldbox fbAddress;
        private models.fieldbox fbEmail;
        private models.fieldbox fbPhone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbMarriage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbGrade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbPermission;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label16;
        private models.fieldbox fbPersonalId;
    }
}