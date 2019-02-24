using System;

namespace Gushwell.DesignPatterns {
    // 代理クラス。
    // 実際のクラスと同じインターフェスを持つ。
    public class PrinterProxy : IPrintable {
        private string name;  // 名前
        private IPrintable real; // 「本人」

        private static object _lockobj = new Object();

        // コンストラクタ
        public PrinterProxy(string name) {
            this.name = name;
        }

        // 名前の取得、名前の設定
        public string PrinterName { 
            get {
                return name;
            }
            set {
                lock (_lockobj) {
                    if (real != null) {
                        real.PrinterName = value; // 「本人」にも設定する
                    }
                    this.name = value;
                }
            }
        }

        // 表示
        public void Print(string text) {
            Realize();
            real.Print(text);
        }

        // 「本人」を生成
        private void Realize() {
            lock (_lockobj) {
                if (real == null) {
                    // 実際に利用するまでインスタンスの生成を遅延させている
                    real = new Printer(name);
                }
            }
        }
    }
}

