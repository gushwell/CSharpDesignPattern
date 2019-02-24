using System;

namespace Gushwell.DesignPatterns {
    public class Program {
        public static void Main(string[] args) {
            // 新しいインターフェースで Bannerを利用する。
            IPrint p = new PrintBanner("Hello");
            p.PrintWeak();
            p.PrintStrong();
            Console.ReadLine();

            // 独自追加部分
            IPrint p2 = new PrintBanner(new Banner("Hello"));
            p2.PrintWeak();
            p2.PrintStrong();
            Console.ReadLine();

        }
    }
}

