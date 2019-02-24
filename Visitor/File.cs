using System;

namespace Gushwell.DesignPatterns {
    // Acceptor具象クラス

    public class File : Entry {
        private readonly int size;

        public File(string name, int size) : base(name) {
            this.size = size;
        }


        public override int Size {
            get { return size; }

        }

        // 訪問者の受け入れ
        // 受け入れたときに何をするかは、Visitorが知っている。
        public override void Accept(IVisitor v) {
            v.Visit(this);
        }
    }
}