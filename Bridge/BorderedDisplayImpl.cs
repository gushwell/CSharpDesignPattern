using System;
using System.Globalization;
using System.Linq;
using System.Text;
using Gushwell.Dejavu;

namespace Gushwell.DesignPatterns {

    // この実装によって、Displayの動作は変わる。
    public class BorderedDisplayImpl : IDisplayImpl {
        private string str;         // 表示するべき文字列
        private int width;          // 文字列の「幅」

        public BorderedDisplayImpl(string str) {
            //コンストラクタで渡された文字列stringを、
            this.str = str; //フィールドに記憶しておく。
            this.width = StringWidth(str);
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

        public void RawOpen() {
            PrintLine();
        }

        public void RawPrint() {
            Console.WriteLine("|" + str + "|"); // 前後に"|"をつけて表示
        }

        public void RawClose() {
            PrintLine();
        }

        private void PrintLine() {
            Console.Write("+");                     // 枠の角を表現する"+"マークを表示する。
            width.Times(() => Console.Write("-"));  // width個の"-"を表示して、枠線として用いる。
            Console.WriteLine("+");                 // 枠の角を表現する"+"マークを表示する。
        }
    }
}

