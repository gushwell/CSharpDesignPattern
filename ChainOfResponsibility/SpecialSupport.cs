using System;

namespace Gushwell.DesignPatterns {

    public class SpecialSupport : Support {
        private int number; // この番号だけ解決できる

        public SpecialSupport(string name, int number)
            : base(name) {
            this.number = number;
        }

        // 解決用メソッド
        protected override bool Resolve(Trouble trouble) {
            return (trouble.Number == number);
        }
    }
}