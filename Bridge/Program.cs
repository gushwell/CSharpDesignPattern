using System;

namespace Gushwell.DesignPatterns {

    public class Program {
        // 機能の階層が、Display, CountDisplayになる
        // 実装の階層が、IDisplayImpl, BorderedDisplayImpl, SimpleDisplayImpl
        // Bridgeは、この２つの階層を橋渡しする。
        public static void Main(string[] args) {
            var d1 = new Display(new BorderedDisplayImpl("Hello, Japan."));
            var d2 = new CountDisplay(new BorderedDisplayImpl("Hello, World."));
            var d3 = new CountDisplay(new BorderedDisplayImpl("Hello, Universe."));
            d1.Show();
            d2.Show();
            d3.Show();
            d3.MultiDisplay(5);

            // SimpleDisplayImpl という別実装のクラスを定義すれば、CountDisplayでもそれが利用できる。
            var d4 = new Display(new SimpleDisplayImpl("Hello, Japan."));
            var d5 = new CountDisplay(new SimpleDisplayImpl("Hello, Universe."));
            d4.Show();
            d5.MultiDisplay(3);
        }
    }
}
