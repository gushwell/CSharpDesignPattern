using System;

namespace Gushwell.DesignPatterns {
    public class Printer : IPrintable {
        // コンストラクタ
        public Printer() {
            HeavyJob("Printerのインスタンスを生成中");
        }

        // コンストラクタ
        public Printer(string name) {
            this.PrinterName = name;
            HeavyJob("Printerのインスタンス(" + name + ")を生成中");
        }

        public string PrinterName { get; set; }      


        // 名前付きで表示
        public void Print(string text) {
            Console.WriteLine("=== " + PrinterName + " ===");
            Console.WriteLine(text);
        }

        // 重い作業(のつもり)
        private void HeavyJob(string msg) {
            Console.Write(msg);
            for (var i = 0; i < 5; i++) {
                System.Threading.Thread.Sleep(1000);
                Console.Write(".");
            }
            Console.WriteLine("完了。");
        }
    }
}

