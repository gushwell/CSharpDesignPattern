using System;

namespace Gushwell.DesignPatterns {
    // 古いインターフェースのクラス
    // IPrintインターフェースに合わせたい
    public class Banner : IBanner  {
        private string str;

        public virtual void ShowWithParen() {
            Console.WriteLine("(" + str + ")");
        }

        public virtual void ShowWithAster() {
            Console.WriteLine("*" + str + "*");
        }

        #region IBanner メンバ


        public string Text {
            get { return str; }
            set { str = value; }
        }

        #endregion
    }
}

