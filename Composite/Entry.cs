using System;

namespace Gushwell.DesignPatterns {

    public abstract class Entry {
        public abstract string Name { get; protected set; }
        
        public abstract int Size { get; protected set;  }



        // エントリを追加する
        public virtual Entry Add(Entry entry) {
            // オリジナルは独自例外クラスだったが、ここでは.NET標準の例外クラスにした。
            throw new NotSupportedException();
        }

        // 一覧を表示する
        public virtual void PrintList() {
            PrintList("");
        }

        // prefixを前につけて一覧を表示する
        protected internal abstract void PrintList(string prefix);

        // 文字列表現
        public override string ToString() {
            return Name + " (" + Size + ")";
        }
    }
}

