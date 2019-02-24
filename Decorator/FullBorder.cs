using System;
using System.Collections.Generic;

namespace Gushwell.DesignPatterns {

    // コンストラクタで与えた Displayオブジェクトに FullBorderの能力を付加する。
    public class FullBorder : Border {
        // コンストラクタ
        public FullBorder(Display display)
            : base(display) {
        }
        
        // 文字数は中身の両側に左右の飾り文字分を加えたもの
        public override  int Columns {
            get { return 1 + display.Columns + 1; }

        }

        // 行数は中身の行数に上下の飾り文字分を加えたもの
        public override  int Rows {
            get { return 1 + display.Rows + 1; }
        }

        // 指定した行の内容を順に取り出す
        public override IEnumerable<string> GetRowTexts() {
            yield return "+" + MakeLine('-', display.Columns) + "+";
            foreach (var text in display.GetRowTexts())
                yield return "|" + text + "|";
            yield return "+" + MakeLine('-', display.Columns) + "+";

        }
        // 文字chをcount個連続させた文字列を作る
        private string MakeLine(char ch, int count) {
            return new string(ch, count);
        }
    }
}

