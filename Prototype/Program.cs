using System;
using Gushwell.DesignPatterns.Prototype.Framework;

namespace Gushwell.DesignPatterns.Prototype {
    public class Program {
        // 事前に用意していた「原型」からインスタンスを生成するパターン

        public static void Main(string[] args) {
            // 準備 ３つのプロトタイプを用意する
            var manager = new Manager();
            var upen = new UnderlinePen('~');
            var mbox = new MessageBox('*');
            var sbox = new MessageBox('/');
            manager.Register("strong message", upen);
            manager.Register("warning box", mbox);
            manager.Register("slash box", sbox);

            // 生成
            IProduct p1 = manager.Create("strong message");
            p1.Use("Hello, world.");
            IProduct p2 = manager.Create("warning box");
            p2.Use("Hello, world.");
            IProduct p3 = manager.Create("slash box");
            p3.Use("Hello, world.");

        }
    }
}
