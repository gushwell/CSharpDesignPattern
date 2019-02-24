using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Gushwell.Dejavu;

namespace Gushwell.DesignPatterns {

    public abstract class Display  {
        public abstract int Columns { get; }

        // このサンプルアプリでは利用していない
        public abstract int Rows { get; }

        //// 指定した行の内容を順に取り出す
        public abstract IEnumerable<string> GetRowTexts();

        // 全部表示する
        public virtual void Show() {
            GetRowTexts().ForEach(s => Console.WriteLine(s));
        }

    }
}

