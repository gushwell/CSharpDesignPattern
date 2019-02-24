using System;

namespace Gushwell.DesignPatterns {

    public class Trouble {
        // トラブル番号を得る
        virtual public int Number { get; private set; }

        // トラブルの生成
        public Trouble(int number) {
            Number = number;
        }

        // トラブルの文字列表現
        public override string ToString() {
            return "[Trouble " + Number + "]";
        }
    }
}