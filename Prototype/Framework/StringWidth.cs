using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Prototype.Framework {
    static class StringWidth {

        // ちょっと手抜き
        public static int Get(string str) {
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
