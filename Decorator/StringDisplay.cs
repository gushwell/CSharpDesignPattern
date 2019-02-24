using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Gushwell.DesignPatterns {

public class StringDisplay : Display {
        // 表示文字列
        private string str;

        // コンストラクタ：引数で表示文字列を指定
        public StringDisplay(string str) {
            this.str = str;
        }

        // 文字数（半角換算）
        public override  int Columns {
            get {
                return StringWidth(str);
            }
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


        // 行数は1
        public override  int Rows {
            get { return 1; }
        }

        // strのみ返す
        public override IEnumerable<string> GetRowTexts() {
            yield return str;

        }
    }
}

