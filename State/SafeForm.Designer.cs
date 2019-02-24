namespace Gushwell.DesignPatterns {
    partial class SafeForm {
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
            this.components = new System.ComponentModel.Container();
            this.textScreen = new System.Windows.Forms.TextBox();
            this.textClock = new System.Windows.Forms.TextBox();
            this.buttonUse = new System.Windows.Forms.Button();
            this.buttonAlarm = new System.Windows.Forms.Button();
            this.buttonPhone = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textScreen
            // 
            this.textScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textScreen.Location = new System.Drawing.Point(0, 28);
            this.textScreen.Multiline = true;
            this.textScreen.Name = "textScreen";
            this.textScreen.ReadOnly = true;
            this.textScreen.Size = new System.Drawing.Size(348, 175);
            this.textScreen.TabIndex = 0;
            // 
            // textClock
            // 
            this.textClock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textClock.Location = new System.Drawing.Point(0, 3);
            this.textClock.Name = "textClock";
            this.textClock.ReadOnly = true;
            this.textClock.Size = new System.Drawing.Size(348, 19);
            this.textClock.TabIndex = 1;
            // 
            // buttonUse
            // 
            this.buttonUse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUse.Location = new System.Drawing.Point(6, 215);
            this.buttonUse.Name = "buttonUse";
            this.buttonUse.Size = new System.Drawing.Size(75, 23);
            this.buttonUse.TabIndex = 2;
            this.buttonUse.Text = "金庫使用";
            this.buttonUse.UseVisualStyleBackColor = true;
            this.buttonUse.Click += new System.EventHandler(this.buttonUse_Click);
            // 
            // buttonAlarm
            // 
            this.buttonAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAlarm.Location = new System.Drawing.Point(91, 215);
            this.buttonAlarm.Name = "buttonAlarm";
            this.buttonAlarm.Size = new System.Drawing.Size(75, 23);
            this.buttonAlarm.TabIndex = 3;
            this.buttonAlarm.Text = "非常ベル";
            this.buttonAlarm.UseVisualStyleBackColor = true;
            this.buttonAlarm.Click += new System.EventHandler(this.buttonAlarm_Click);
            // 
            // buttonPhone
            // 
            this.buttonPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPhone.Location = new System.Drawing.Point(176, 215);
            this.buttonPhone.Name = "buttonPhone";
            this.buttonPhone.Size = new System.Drawing.Size(75, 23);
            this.buttonPhone.TabIndex = 4;
            this.buttonPhone.Text = "通常通話";
            this.buttonPhone.UseVisualStyleBackColor = true;
            this.buttonPhone.Click += new System.EventHandler(this.buttonPhone_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExit.Location = new System.Drawing.Point(261, 215);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "終了";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // timerClock
            // 
            this.timerClock.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // SafeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 248);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPhone);
            this.Controls.Add(this.buttonAlarm);
            this.Controls.Add(this.buttonUse);
            this.Controls.Add(this.textClock);
            this.Controls.Add(this.textScreen);
            this.Name = "SafeForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textScreen;
        private System.Windows.Forms.TextBox textClock;
        private System.Windows.Forms.Button buttonUse;
        private System.Windows.Forms.Button buttonAlarm;
        private System.Windows.Forms.Button buttonPhone;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Timer timerClock;
    }
}

