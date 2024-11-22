namespace PrjEIP.views
{
    partial class FrmLogIn
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fbConfirm = new System.Windows.Forms.Button();
            this.fbCancel = new System.Windows.Forms.Button();
            this.fbRegister = new System.Windows.Forms.Button();
            this.fbForgotCode = new System.Windows.Forms.Button();
            this.fbGetVerify = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPasswordStrength = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fbVerify = new PrjEIP.models.fieldbox();
            this.fbAccount = new PrjEIP.models.fieldbox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(14, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 36);
            this.label2.TabIndex = 12;
            this.label2.Text = "登入畫面";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1096, 2);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // fbConfirm
            // 
            this.fbConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fbConfirm.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbConfirm.Location = new System.Drawing.Point(868, 654);
            this.fbConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fbConfirm.Name = "fbConfirm";
            this.fbConfirm.Size = new System.Drawing.Size(132, 60);
            this.fbConfirm.TabIndex = 7;
            this.fbConfirm.Text = "登入";
            this.fbConfirm.UseVisualStyleBackColor = true;
            this.fbConfirm.Click += new System.EventHandler(this.fbConfirm_Click);
            // 
            // fbCancel
            // 
            this.fbCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.fbCancel.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbCancel.Location = new System.Drawing.Point(644, 654);
            this.fbCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fbCancel.Name = "fbCancel";
            this.fbCancel.Size = new System.Drawing.Size(132, 60);
            this.fbCancel.TabIndex = 13;
            this.fbCancel.Text = "取消";
            this.fbCancel.UseVisualStyleBackColor = true;
            this.fbCancel.Click += new System.EventHandler(this.fbCancel_Click);
            // 
            // fbRegister
            // 
            this.fbRegister.Cursor = System.Windows.Forms.Cursors.Default;
            this.fbRegister.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbRegister.Location = new System.Drawing.Point(405, 654);
            this.fbRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fbRegister.Name = "fbRegister";
            this.fbRegister.Size = new System.Drawing.Size(132, 60);
            this.fbRegister.TabIndex = 14;
            this.fbRegister.Text = "註冊";
            this.fbRegister.UseVisualStyleBackColor = true;
            this.fbRegister.Click += new System.EventHandler(this.fbRegister_Click);
            // 
            // fbForgotCode
            // 
            this.fbForgotCode.Cursor = System.Windows.Forms.Cursors.Default;
            this.fbForgotCode.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbForgotCode.Location = new System.Drawing.Point(74, 654);
            this.fbForgotCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fbForgotCode.Name = "fbForgotCode";
            this.fbForgotCode.Size = new System.Drawing.Size(252, 60);
            this.fbForgotCode.TabIndex = 15;
            this.fbForgotCode.Text = "忘記密碼";
            this.fbForgotCode.UseVisualStyleBackColor = true;
            this.fbForgotCode.Click += new System.EventHandler(this.fbForgotCode_Click);
            // 
            // fbGetVerify
            // 
            this.fbGetVerify.Cursor = System.Windows.Forms.Cursors.Default;
            this.fbGetVerify.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbGetVerify.Location = new System.Drawing.Point(70, 544);
            this.fbGetVerify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fbGetVerify.Name = "fbGetVerify";
            this.fbGetVerify.Size = new System.Drawing.Size(255, 60);
            this.fbGetVerify.TabIndex = 16;
            this.fbGetVerify.Text = "領取驗證碼";
            this.fbGetVerify.UseVisualStyleBackColor = true;
            this.fbGetVerify.Click += new System.EventHandler(this.fbGetVerify_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(64, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 31);
            this.label3.TabIndex = 18;
            this.label3.Text = "使用者密碼";
            // 
            // lbPasswordStrength
            // 
            this.lbPasswordStrength.AutoSize = true;
            this.lbPasswordStrength.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbPasswordStrength.Location = new System.Drawing.Point(362, 294);
            this.lbPasswordStrength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPasswordStrength.Name = "lbPasswordStrength";
            this.lbPasswordStrength.Size = new System.Drawing.Size(158, 31);
            this.lbPasswordStrength.TabIndex = 19;
            this.lbPasswordStrength.Text = "您的密碼強度";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(74, 286);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(206, 36);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(362, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 31);
            this.label4.TabIndex = 21;
            this.label4.Text = "您的密碼強度";
            // 
            // fbVerify
            // 
            this.fbVerify.filedName = "驗證碼:";
            this.fbVerify.filedValue = "";
            this.fbVerify.Location = new System.Drawing.Point(74, 405);
            this.fbVerify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fbVerify.Name = "fbVerify";
            this.fbVerify.passwordMask = '\0';
            this.fbVerify.Size = new System.Drawing.Size(252, 104);
            this.fbVerify.TabIndex = 11;
            // 
            // fbAccount
            // 
            this.fbAccount.filedName = "使用者帳號:";
            this.fbAccount.filedValue = "";
            this.fbAccount.Location = new System.Drawing.Point(52, 78);
            this.fbAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fbAccount.Name = "fbAccount";
            this.fbAccount.passwordMask = '\0';
            this.fbAccount.Size = new System.Drawing.Size(255, 106);
            this.fbAccount.TabIndex = 9;
            // 
            // FrmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 818);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbPasswordStrength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fbGetVerify);
            this.Controls.Add(this.fbForgotCode);
            this.Controls.Add(this.fbRegister);
            this.Controls.Add(this.fbCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fbVerify);
            this.Controls.Add(this.fbAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fbConfirm);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogIn_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private models.fieldbox fbVerify;
        private models.fieldbox fbAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fbConfirm;
        private System.Windows.Forms.Button fbCancel;
        private System.Windows.Forms.Button fbRegister;
        private System.Windows.Forms.Button fbForgotCode;
        private System.Windows.Forms.Button fbGetVerify;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPasswordStrength;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}