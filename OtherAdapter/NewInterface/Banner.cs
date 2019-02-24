using System;

namespace Gushwell.DesignPatterns {

    // 新しいBannerクラス。インターフェースも刷新する。
    // OldBannerはメンテナンスせずに、こちらだけをメンテナンス対象とする。
    public class NewBanner : IBanner {
        private string str;

        public NewBanner(System.String str) {
            this.str = str;
        }

        public void PrintWeak() {
            Console.WriteLine("(" + str + ")");
        }

        public void PrintStrong() {
            Console.WriteLine("*" + str + "*");
        }
    }
}

