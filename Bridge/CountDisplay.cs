using System;
using Gushwell.Dejavu;

namespace Gushwell.DesignPatterns {

    // Displayの具象クラス
    // Displayにない新しいメソッドMultiDisplayを追加。
    public class CountDisplay : Display {
        public CountDisplay(IDisplayImpl impl)
            : base(impl) {
        }

        // times回繰り返して表示する
        public virtual void MultiDisplay(int times) {
            Open();
            // 繰返し文をなくすために、Times拡張メソッドを定義し、使ってみた。
            times.Times(() => Print());
            Close();
        }
    }
}

