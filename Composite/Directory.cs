using System;
using System.Linq;
using System.Collections.Generic;

namespace Gushwell.DesignPatterns {

    // Directoryは、Entryなので、Directoryの中にDirectoryを持つことができる
    // もちろんFileもEntryなので、Directoryの中にFileを持つこともできる。
    public class Directory : Entry {
        private List<Entry> directory = new List<Entry>();  // ディレクトリエントリの集合

        // 名前を得る
        public override string Name { get; protected set; }

        // サイズを得る
        public override int Size {
            get {
                return directory.Aggregate(0, (s, e) => s + e.Size);
            }
            protected set { }
        }

        // コンストラクタ
        public Directory(string name) {
            Name = name;
        }

        // エントリの追加
        public override Entry Add(Entry entry) {
            directory.Add(entry);
            return this;
        }

        
        // エントリの一覧 (再帰処理)
        // protected internal にしないと、再帰的にPrintListを呼び出せない。
        protected internal override void PrintList(string prefix) {
            Console.WriteLine($"{prefix}/{this}");
            directory.ForEach(e => e.PrintList(prefix + "/" + Name));
        }
    }
}
