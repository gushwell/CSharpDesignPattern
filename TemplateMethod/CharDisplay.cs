using System;

namespace Gushwell.DesignPatterns {

    // CharDisplayは、テンプレートクラス(AbstractDisplay)から派生したサブクラス。
    public class CharDisplay : AbstractDisplay {
        private readonly char ch; // 表示すべき文字。

        public CharDisplay(char ch) {
            // コンストラクタで渡された文字chを、フィールドに記憶しておく。
            this.ch = ch;               
        }

        // スーパークラスでは抽象メソッドだった。ここでオーバーライドして実装。
        public override void Open() {
            // 開始文字列として"<<"を表示する。
            Console.Write("<<");        
        }

        // printメソッドもここで実装する。これがdisplayから繰り返して呼び出される。
        public override void Print() {
            // フィールドに記憶しておいた文字を1個表示する。
            Console.Write(ch);          
        }

        // closeメソッドもここで実装。
        public override void Close() {
            // 終了文字列">>"を表示。
            Console.WriteLine(">>");    
        }
    }
}

