using System;

namespace Gushwell.DesignPatterns {
    public class Program {
        public static void Main(System.String[] args) {
            // 'H'を持ったCharDisplayのインスタンスを1個作る。
            AbstractDisplay d1 = new CharDisplay('H');

            // "Hello, world."を持ったStringDisplayのインスタンスを1個作る。
            AbstractDisplay d2 = new StringDisplay("Hello, world.");
            
            // "こんにちは。"を持ったStringDisplayのインスタンスを1個作る。
            AbstractDisplay d3 = new StringDisplay("こんにちは。");

            d1.Display(); // d1,d2,d3とも、すべて同じAbstractDisplayのサブクラスのインスタンス
            d2.Display(); // だから、継承したdisplayメソッドを呼び出すことができる。
            d3.Display(); // 実際の動作は個々のクラスCharDisplayやStringDisplayで定まる。
        }
    }
}

