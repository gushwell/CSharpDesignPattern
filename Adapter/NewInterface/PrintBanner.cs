using System;

namespace Gushwell.DesignPatterns {

    // Bannerクラスを新しいインターフェースで使えるようにする処理は、すべてBannerに委譲する。
    // 委譲しておけば、あとから、Bannerに委譲せずに、処理を行うように書き換えることで、
    // Bannerクラスを捨て去ることも可能。
    public class PrintBanner : IPrint {
        private Banner banner;
        public PrintBanner(string str) {
            banner = new Banner(str);
        }

        // こんなコンストラクタを作ってもよいかも。
        // しかし、Bannerクラスを捨て去ることが難しくなる。
        public PrintBanner(Banner banner) {
            this.banner = banner;
        }

        public void PrintWeak() {
            banner.ShowWithParen();
        }

        public void PrintStrong() {
            banner.ShowWithAster();
        }
    }
}

