using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;
using Gushwell.Dejavu;

namespace Gushwell.DesignPatterns {
    public class BigString {
        private BigChar[] bigchars; // 「大きな文字」の配列

        // コンストラクタ
        public BigString(string str) {
            bigchars = new BigChar[str.Length];
            var factory = BigCharFactory.Instance;
            var i = 0;
            str.ForEach(ch => bigchars[i++] = factory.GetBigChar(ch));
        }

        // 表示
        public virtual void Print() {
            bigchars.ForEach(bc => bc.Print());
        }
    }

}

