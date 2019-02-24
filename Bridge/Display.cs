using System;

namespace Gushwell.DesignPatterns {

    // Displayは、機能（インターフェース）を管理
    // 具体的に何をするのか（実装）は、IDisplayImpl側で管理
    // Displayから派生するのは、is a 関係
    // IDisplayImplを実装するクラスは、Displayとは use-a (or made-of)関係になる？
    public class Display {
        private IDisplayImpl impl;

        // コンストラクタでIDisplayImplを受け取る -> これにより動作が変化する。
        public Display(IDisplayImpl impl) {
            this.impl = impl;
        }

        public void Open() {
            impl.RawOpen();
        }

        public void Print() {
            impl.RawPrint();
        }

        public void Close() {
            impl.RawClose();
        }

        // オリジナルのメソッド名は 'display'
        // クラス名とバッティングするため、Showに変更
        public void Show() {
            Open();
            Print();
            Close();
        }
    }
}

