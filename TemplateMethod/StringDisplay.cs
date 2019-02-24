using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Gushwell.DesignPatterns {
    // StringDisplayも、テンプレートクラス(AbstractDisplay)から派生したサブクラス。

    public class StringDisplay : AbstractDisplay {
        private readonly string str;             // 表示するべき文字列。
        private readonly int width;              // バイト単位で計算した文字列の「幅」。
        public StringDisplay(string str) {
            // コンストラクタで渡された文字列stringを、
            this.str = str;             // フィールドに記憶。
            this.width = GetWidth(str); // それからバイト単位の幅もフィールドに記憶しておいて、後で使う。
        }

        // オーバーライドして定義するopenメソッド。
        public override void Open() {
            PrintLine();                // このクラスのメソッドPrintLineで線を引いている。
        }

        // Printメソッドは、
        // フィールドに記憶しておいた文字列の前後に"|"をつけて表示。
        public override void Print() {
            Console.WriteLine("|" + str + "|");
        }

        // Closeメソッドは、
        // Openと同じくPrintLineメソッドで線を引いている。
        public override void Close() {
            PrintLine();
        }

        // OpenとCloseから呼ばれるPrintLineメソッドだ。
        // privateなので、このクラスの中だけで使われる。
        private void PrintLine() {
            // 枠の角を表現する"+"マークを表示。
            Console.Write("+");         
            // width個の"-"を表示して、枠線として用いる。
            Console.Write(new string('-', width));
            // 枠の角を表現する"+"マークを表示。
            Console.WriteLine("+");     
        }

        // 文字幅を求める
        private int GetWidth(string str) {
            return StringWidth(str);
        }

        // ちょっと手抜き
        private static int StringWidth(string str) {
            var len = 0;
            var charEnum = StringInfo.GetTextElementEnumerator(str);
            while (charEnum.MoveNext()) {
                var element = charEnum.GetTextElement();
                var width = element.Aggregate(0, (l, c) => ((0 <= c && c < 255) ? 1 : 2) + l);
                len += width == 1 ? 1 : 2;
            }
            return len;
        }
    }
}
