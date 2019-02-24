using System;
using System.Collections.Generic;
using System.Linq;

namespace Gushwell.DesignPatterns {
    // Acceptor具象クラス
    public class Directory : Entry, IEnumerable<Entry> {

        // 再帰を使いTree構造を表している
        private List<Entry> dir = new List<Entry>(); // ディレクトリエントリの集合

        // コンストラクタ
        public Directory(string name) : base(name){
        }


        // サイズを得る
        public override int Size {
            get {
                //int size = 0;
                //foreach (Entry entry in dir)
                //    size += entry.Size;
                //return size;
                //上記処理をAggregateを使って書いてみた。
                return dir.Aggregate(0, (a, entry) => a + entry.Size);
            }

        }

        // エントリの追加
        public override Entry Add(Entry entry) {
            dir.Add(entry);
            return this;
        }

        // 訪問者の受け入れ
        // 受け入れたときに何をするかは、Visitorが知っている。
        public override void Accept(IVisitor v) {
            v.Visit(this);
        }

        public IEnumerator<Entry> GetEnumerator() {
            return dir.GetEnumerator();
        }


        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
            return this.GetEnumerator();
        }
    }
}