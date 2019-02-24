using System;

namespace Gushwell.DesignPatterns {

    public class Program {
        public static void Main(string[] args) {
            Display b1 = new StringDisplay("Hello, world.");
            
            // b1にSiderBorderの能力を付加する。
            Display b2 = new SideBorder(b1, '#');

            // b2にFullBorderの能力を付加する。
            Display b3 = new FullBorder(b2);
            b1.Show();
            b2.Show();
            b3.Show();

            // Border(の派生クラス）は、Displayの派生クラスだから、SideBorder, FullBorderには、
            // SiderBorder, FullBorderのオブジェクトを渡せる。
            Display b4 =
                new SideBorder(
                    new FullBorder(
                        new FullBorder(
                            new SideBorder(
                                new FullBorder(
                                    new StringDisplay("こんにちは。")
                                ),
                                '*'
                            )
                        )
                    ),
                    '/'
                );
            b4.Show();
            Console.ReadLine();
        }
    }
}
