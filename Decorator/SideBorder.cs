using System;
using System.Collections.Generic;

namespace Gushwell.DesignPatterns {
    // コンストラクタで与えた Displayオブジェクトに SideBorderの能力を付加する。
    public class SideBorder : Border {
        // コンストラクタ
        public SideBorder(Display display, char ch)
            : base(display) {
            this.borderChar = ch;
        }

        // Columnsは中身の両側に飾り文字分を加えたもの
        public override  int Columns {
            get { return 1 + display.Columns + 1; }
        }

        // 行数は中身の行数に同じ
        public override  int Rows {
            get { return display.Rows; }

        }
        // 飾りとなる文字
        private char borderChar;


        // 指定行の内容は、中身の指定行の両側に飾り文字をつけたもの
        public override IEnumerable<string> GetRowTexts() {
            foreach (var s in display.GetRowTexts())
                yield return borderChar + s + borderChar;

        }
    }
}

