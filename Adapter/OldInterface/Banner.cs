using System;

namespace Gushwell.DesignPatterns {

    // 古いインターフェースのクラス
    // IPrintインターフェースに合わせたい
    public class Banner {
        private string str;

        public Banner(System.String str) {
            this.str = str;
        }

        public virtual void ShowWithParen() {
            Console.WriteLine("(" + str + ")");
        }

        public virtual void ShowWithAster() {
            Console.WriteLine("*" + str + "*");
        }
    }
}

