using System;

namespace Gushwell.DesignPatterns {
    public class Program {
        
        public static void Main(string[] args) {
            // Proxyを使うことで、インスタンス生成とプロパティ参照はすぐに終わる
            IPrintable p = new PrinterProxy("Alice");
            Console.WriteLine("名前は現在" + p.PrinterName + "です。");
            p.PrinterName = "Bob";
            Console.WriteLine("名前は現在" + p.PrinterName + "です。");

            p.Print("Hello, world.");
        }
    }
}

