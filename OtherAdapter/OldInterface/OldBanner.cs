using System;

namespace Gushwell.DesignPatterns {

    // 古いインターフェースのクラス
    // もう中身がぐちゃぐちゃでメンテナンスが無理なので、
    // NewBannerクラスを新規に作成し、処理を委譲するように変更した。
    public class OldBanner : IOldBanner {
        private IBanner banner;
        public OldBanner(string str) {
            banner = new NewBanner(str);
        }

        public void ShowWithParen() {
            banner.PrintWeak();
        }

        public void ShowWithAster() {
            banner.PrintStrong();
        }
    }
}

