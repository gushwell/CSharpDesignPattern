using System;

namespace Gushwell.DesignPatterns {

    public class LimitSupport : Support {
        private int limit; // この番号未満なら解決できる

        public LimitSupport(string name, int limit)
            : base(name) {
            this.limit = limit;
        }

        // 解決用メソッド
        protected override bool Resolve(Trouble trouble) {
            return trouble.Number < limit;
        }
    }
}
