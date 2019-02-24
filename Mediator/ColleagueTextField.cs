using System;

namespace Gushwell.DesignPatterns {
    // 仲間オブジェクトの具象クラス
    [Serializable]
    public class ColleagueTextField : System.Windows.Forms.TextBox, IColleague {
        private IMediator mediator = null;
        public ColleagueTextField()
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

        // 文字列が変化したらMediatorに通知
        protected override void OnTextChanged(EventArgs e) {
            base.OnTextChanged(e);
            if (mediator != null)
                // 調停者に変更したことを知らせる
                // 具体的に何をやるかは、調停者に任せる
                mediator.ColleagueChanged();
        }
    }
}