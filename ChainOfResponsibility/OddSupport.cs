using System;

namespace Gushwell.DesignPatterns {

    public class OddSupport : Support {
        public OddSupport(string name)
            : base(name) {
        }

        // 解決用メソッド
        protected override bool Resolve(Trouble trouble) {
            return (trouble.Number % 2 == 1);
        }
    }
}