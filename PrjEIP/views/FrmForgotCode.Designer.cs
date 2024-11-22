namespace PrjEIP.views
{
    partial class FrmForgotCode
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGetTempPassword = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbPasswordStrength = new System.Windows.Forms.Label();
            this.fbNewPassword2 = new PrjEIP.models.fieldbox();
            this.fbtempPassword = new PrjEIP.models.fieldbox();
            this.fbEmpAccount = new PrjEIP.models.fieldbox();
            this.fbEmpEmail = new PrjEIP.models.fieldbox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(145, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "忘記密碼,請填寫以下資訊才能找回密碼";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(853, 1);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConfirm.Location = new System.Drawing.Point(737, 443);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(125, 51);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "確認";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(586, 443);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 51);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGetTempPassword
            // 
            this.btnGetTempPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetTempPassword.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGetTempPassword.Location = new System.Drawing.Point(14, 453);
            this.btnGetTempPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGetTempPassword.Name = "btnGetTempPassword";
            this.btnGetTempPassword.Size = new System.Drawing.Size(153, 51);
            this.btnGetTempPassword.TabIndex = 10;
            this.btnGetTempPassword.Text = "取得驗證碼";
            this.btnGetTempPassword.UseVisualStyleBackColor = true;
            this.btnGetTempPassword.Click += new System.EventHandler(this.btnGetTempPassword_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(8, 419);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "輸入信箱後按下取得驗證碼";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(105, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "必填";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(342, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 31);
            this.label5.TabIndex = 29;
            this.label5.Text = "請輸入密碼";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(321, 253);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(197, 41);
            this.textBox1.TabIndex = 28;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(552, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 31);
            this.label6.TabIndex = 27;
            this.label6.Text = "您的密碼強度";
            // 
            // lbPasswordStrength
            // 
            this.lbPasswordStrength.AutoSize = true;
            this.lbPasswordStrength.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbPasswordStrength.Location = new System.Drawing.Point(552, 257);
            this.lbPasswordStrength.Name = "lbPasswordStrength";
            this.lbPasswordStrength.Size = new System.Drawing.Size(158, 31);
            this.lbPasswordStrength.TabIndex = 26;
            this.lbPasswordStrength.Text = "您的密碼強度";
            // 
            // fbNewPassword2
            // 
            this.fbNewPassword2.filedName = "再次輸入新的密碼";
            this.fbNewPassword2.filedValue = "";
            this.fbNewPassword2.Location = new System.Drawing.Point(321, 329);
            this.fbNewPassword2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.fbNewPassword2.Name = "fbNewPassword2";
            this.fbNewPassword2.passwordMask = '\0';
            this.fbNewPassword2.Size = new System.Drawing.Size(262, 91);
            this.fbNewPassword2.TabIndex = 9;
            // 
            // fbtempPassword
            // 
            this.fbtempPassword.filedName = "輸入驗證碼";
            this.fbtempPassword.filedValue = "";
            this.fbtempPassword.Location = new System.Drawing.Point(321, 104);
            this.fbtempPassword.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.fbtempPassword.Name = "fbtempPassword";
            this.fbtempPassword.passwordMask = '\0';
            this.fbtempPassword.Size = new System.Drawing.Size(213, 91);
            this.fbtempPassword.TabIndex = 5;
            // 
            // fbEmpAccount
            // 
            this.fbEmpAccount.filedName = "帳號";
            this.fbEmpAccount.filedValue = "";
            this.fbEmpAccount.Location = new System.Drawing.Point(14, 174);
            this.fbEmpAccount.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.fbEmpAccount.Name = "fbEmpAccount";
            this.fbEmpAccount.passwordMask = '\0';
            this.fbEmpAccount.Size = new System.Drawing.Size(213, 75);
            this.fbEmpAccount.TabIndex = 2;
            // 
            // fbEmpEmail
            // 
            this.fbEmpEmail.filedName = "電子郵件";
            this.fbEmpEmail.filedValue = "";
            this.fbEmpEmail.Location = new System.Drawing.Point(14, 291);
            this.fbEmpEmail.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.fbEmpEmail.Name = "fbEmpEmail";
            this.fbEmpEmail.passwordMask = '\0';
            this.fbEmpEmail.Size = new System.Drawing.Size(213, 75);
            this.fbEmpEmail.TabIndex = 1;
            // 
            // FrmForgotCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 621);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbPasswordStrength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGetTempPassword);
            this.Controls.Add(this.fbNewPassword2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.fbtempPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fbEmpAccount);
            this.Controls.Add(this.fbEmpEmail);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmForgotCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmForgotCode";
            this.Load += new System.EventHandler(this.FrmForgotCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private models.fieldbox fbEmpEmail;
        private models.fieldbox fbEmpAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private models.fieldbox fbtempPassword;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private models.fieldbox fbNewPassword2;
        private System.Windows.Forms.Button btnGetTempPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbPasswordStrength;
    }
}