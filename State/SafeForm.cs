using System;
using System.Windows.Forms;

namespace Gushwell.DesignPatterns {
    // このフォームがコンテキストクラスに該当する
    public partial class SafeForm : Form, IContext {
        private IState state = DayState.Instance;
        public SafeForm() {
            InitializeComponent();
        }

        // 金庫使用ボタン
        private void buttonUse_Click(object sender, EventArgs e) {
            state.DoUse(this);
        }

        // 非常ベルボタン
        private void buttonAlarm_Click(object sender, EventArgs e) {
            state.DoAlarm(this);
        }

        // 通常通話ボタン
        private void buttonPhone_Click(object sender, EventArgs e) {
            state.DoPhone(this);
        }

        // 終了ボタン
        private void buttonExit_Click(object sender, EventArgs e) {
            Close();
        }
        
        // 時刻の設定
        virtual public void SetClock(int hour) {
            var clockstring = "現在時刻は";
            if (hour < 10) {
                clockstring += ("0" + hour + ":00");
            } else {
                clockstring += (hour + ":00");
            }
            Console.WriteLine(clockstring);
            textClock.Text = clockstring;
            state.DoClock(this, hour);
        }

        public virtual void ChangeState(IState state) {
            Console.WriteLine(this.state + "から" + state + "へ状態が変化しました。");
            this.state = state;
        }

        // 警備センター警備員呼び出し
        public virtual void CallSecurityCenter(string msg) {
            textScreen.AppendText("call! " + msg + Environment.NewLine);
        }

        // 警備センター記録
        public virtual void RecordLog(string msg) {
            textScreen.AppendText("record ... " + msg + Environment.NewLine);
        }

        private void Form1_Load(object sender, EventArgs e) {
            timerClock.Interval = 1000;
            timerClock.Enabled = true;
        }

        private int hour = 0;
        private void Timer1_Tick(object sender, EventArgs e) {
            SetClock(hour++);
            if (hour >= 24)
                hour = 0;
        }
    }
}