namespace Gushwell.DesignPatterns {
    partial class LoginForm {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textPass = new Gushwell.DesignPatterns.ColleagueTextField();
            this.textUser = new Gushwell.DesignPatterns.ColleagueTextField();
            this.buttonCancel = new Gushwell.DesignPatterns.ColleagueButton();
            this.buttonOk = new Gushwell.DesignPatterns.ColleagueButton();
            this.radioLogin = new Gushwell.DesignPatterns.ColleagueRadioButton();
            this.radioGuest = new Gushwell.DesignPatterns.ColleagueRadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(76, 74);
            this.textPass.MaxLength = 10;
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(118, 19);
            this.textPass.TabIndex = 7;
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(75, 41);
            this.textUser.MaxLength = 10;
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(119, 19);
            this.textUser.TabIndex = 6;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(110, 117);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(93, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(3, 117);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(101, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // radioLogin
            // 
            this.radioLogin.AutoSize = true;
            this.radioLogin.Location = new System.Drawing.Point(87, 12);
            this.radioLogin.Name = "radioLogin";
            this.radioLogin.Size = new System.Drawing.Size(50, 16);
            this.radioLogin.TabIndex = 1;
            this.radioLogin.TabStop = true;
            this.radioLogin.Text = "Login";
            this.radioLogin.UseVisualStyleBackColor = true;
            // 
            // radioGuest
            // 
            this.radioGuest.AutoSize = true;
            this.radioGuest.Location = new System.Drawing.Point(16, 12);
            this.radioGuest.Name = "radioGuest";
            this.radioGuest.Size = new System.Drawing.Size(53, 16);
            this.radioGuest.TabIndex = 0;
            this.radioGuest.TabStop = true;
            this.radioGuest.Text = "Guest";
            this.radioGuest.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 146);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioLogin);
            this.Controls.Add(this.radioGuest);
            this.Name = "LoginForm";
            this.Text = "Mediator Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColleagueRadioButton radioGuest;
        private ColleagueRadioButton radioLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ColleagueButton buttonOk;
        private ColleagueButton buttonCancel;
        private ColleagueTextField textUser;
        private ColleagueTextField textPass;

    }
}

