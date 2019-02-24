using System;

namespace Gushwell.DesignPatterns {
    public class Program {
        // 新しい部品を使いたいが、書き換えるコストが大変。
        // しばらくは古いインターフェースのまま使いたい。
        public static void Main(string[] args) {
            // 古いインターフェースで NewBannerを利用する。
            IOldBanner p = new OldBanner("Hello");
            p.ShowWithParen();
            p.ShowWithAster();
            Console.ReadLine();

            // もちろん新しいインターフェースでも利用も可能
            // 新規にコーディングする部分は新しいインターフェースを利用する。
            IBanner p2 = new NewBanner("Hello");
            p2.PrintWeak();
            p2.PrintStrong();
            Console.ReadLine();
        }
    }
}

