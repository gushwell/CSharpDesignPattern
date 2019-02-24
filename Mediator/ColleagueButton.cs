using System;

namespace Gushwell.DesignPatterns {
    // 仲間オブジェクトの具象クラス
    [Serializable]
    public class ColleagueButton : System.Windows.Forms.Button, IColleague {
        private IMediator mediator;
        public ColleagueButton()
            : base() {
        }

        // Mediatorを保持
        virtual public void SetMediator(IMediator value) {
            this.mediator = value;
        }

        // Mediatorから有効/無効が指示される
        virtual public void SetColleagueEnabled(bool value) {
            Enabled = value;
        }
    }
}