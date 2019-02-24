using System;

namespace Gushwell.DesignPatterns {

    public class NoSupport : Support {
        public NoSupport(string name)
            : base(name) {
        }

        // 解決用メソッド
        protected override bool Resolve(Trouble trouble) {
            return false; // 自分は何も処理しない
        }
    }
}