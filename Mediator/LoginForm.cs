using System;
using System.Windows.Forms;

// イベントという機能があるので、このようなWindowsFormsアプリで
// Mediatoprパターンを使うことはあるのかな？ ちょっとわからないです。
// ColleagueButtonとかColleagueTextFieldとかは普通は作らないと思われます。
// まあ、あくまでもMediatorパターンのサンプルということで。
namespace Gushwell.DesignPatterns {

    // 調停者オブジェクト
    public partial class LoginForm : Form, IMediator {
        public LoginForm() {
            InitializeComponent();
            CreateColleagues();
            ColleagueChanged();
        }

        // 名前が実態と一致しなくなったが、オリジナルの名前のままとする。
        public virtual void CreateColleagues() {
            // 当Formが、それぞれのコントロールの仲裁者になる
            radioGuest.SetMediator(this);
            radioLogin.SetMediator(this);
            textUser.SetMediator(this);
            textPass.SetMediator(this);
            buttonOk.SetMediator(this);
            buttonCancel.SetMediator(this);
        }

        // Colleage(仲間)からの通知で各Colleageの有効/無効を判定する。
        public virtual void ColleagueChanged() {
            if (radioGuest.Checked) {
                // Guest mode
                textUser.SetColleagueEnabled(false);
                textPass.SetColleagueEnabled(false);
                buttonOk.SetColleagueEnabled(true);
            } else {
                // Login mode
                textUser.SetColleagueEnabled(true);
                UserPassChanged();
            }
        }

        // textUserまたはtextPassの変更があった。
        // 各Colleage(仲間)の有効/無効を判定する。
        private void UserPassChanged() {
            if (textUser.Text.Length > 0) {
                textPass.SetColleagueEnabled(true);
                if (textPass.Text.Length > 0) {
                    buttonOk.SetColleagueEnabled(true);
                } else {
                    buttonOk.SetColleagueEnabled(false);
                }
            } else {
                textPass.SetColleagueEnabled(false);
                buttonOk.SetColleagueEnabled(false);
            }
        }

        private void ButtonOk_Click(object sender, EventArgs e) {
            Console.WriteLine(sender + " : " + e.ToString());
            Close();
        }
    }
}