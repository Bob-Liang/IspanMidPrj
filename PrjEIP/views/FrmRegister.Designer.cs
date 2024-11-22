namespace PrjEIP.views
{
    partial class FrmRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPasswordStrength = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fbEmpId = new PrjEIP.models.fieldbox();
            this.fbPassword2 = new PrjEIP.models.fieldbox();
            this.fbAccount = new PrjEIP.models.fieldbox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fbConfirm
            // 
            this.fbConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fbConfirm.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbConfirm.Location = new System.Drawing.Point(782, 538);
            this.fbConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fbConfirm.Name = "fbConfirm";
            this.fbConfirm.Size = new System.Drawing.Size(140, 58);
            this.fbConfirm.TabIndex = 3;
            this.fbConfirm.Text = "確認";
            this.fbConfirm.UseVisualStyleBackColor = true;
            this.fbConfirm.Click += new System.EventHandler(this.fbConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "使用者註冊帳號密碼";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(905, 2);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(622, 538);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 58);
            this.button1.TabIndex = 8;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCancel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(657, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "您的密碼強度";
            // 
            // lbPasswordStrength
            // 
            this.lbPasswordStrength.AutoSize = true;
            this.lbPasswordStrength.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbPasswordStrength.Location = new System.Drawing.Point(657, 240);
            this.lbPasswordStrength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPasswordStrength.Name = "lbPasswordStrength";
            this.lbPasswordStrength.Size = new System.Drawing.Size(132, 25);
            this.lbPasswordStrength.TabIndex = 22;
            this.lbPasswordStrength.Text = "您的密碼強度";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(349, 236);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(231, 35);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fbEmpId
            // 
            this.fbEmpId.filedName = "員工編號";
            this.fbEmpId.filedValue = "";
            this.fbEmpId.Location = new System.Drawing.Point(13, 187);
            this.fbEmpId.Margin = new System.Windows.Forms.Padding(2);
            this.fbEmpId.Name = "fbEmpId";
            this.fbEmpId.passwordMask = '\0';
            this.fbEmpId.Size = new System.Drawing.Size(284, 113);
            this.fbEmpId.TabIndex = 7;
            // 
            // fbPassword2
            // 
            this.fbPassword2.filedName = "請再次輸入密碼";
            this.fbPassword2.filedValue = "";
            this.fbPassword2.Location = new System.Drawing.Point(349, 328);
            this.fbPassword2.Margin = new System.Windows.Forms.Padding(2);
            this.fbPassword2.Name = "fbPassword2";
            this.fbPassword2.passwordMask = '\0';
            this.fbPassword2.Size = new System.Drawing.Size(331, 113);
            this.fbPassword2.TabIndex = 6;
            // 
            // fbAccount
            // 
            this.fbAccount.filedName = "帳號";
            this.fbAccount.filedValue = "";
            this.fbAccount.Location = new System.Drawing.Point(20, 332);
            this.fbAccount.Margin = new System.Windows.Forms.Padding(2);
            this.fbAccount.Name = "fbAccount";
            this.fbAccount.passwordMask = '\0';
            this.fbAccount.Size = new System.Drawing.Size(243, 110);
            this.fbAccount.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(377, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "請輸入密碼";
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 605);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbPasswordStrength);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fbEmpId);
            this.Controls.Add(this.fbPassword2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fbConfirm);
            this.Controls.Add(this.fbAccount);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmRegister";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private models.fieldbox fbAccount;
        private System.Windows.Forms.Button fbConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private models.fieldbox fbPassword2;
        private models.fieldbox fbEmpId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPasswordStrength;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}