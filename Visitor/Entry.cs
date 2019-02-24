using System;
using System.Collections.Generic;

namespace Gushwell.DesignPatterns {
    // Entryは、IAcceptorインターフェースを持つ
    // このクラスから、FIle, Directoryを派生させる。
    public abstract class Entry : IAcceptor { 
        public string Name { get; }
        public abstract int Size { get; }

        public Entry(string name) {
            this.Name = name;
        }

        // エントリを追加する
        public virtual Entry Add(Entry entry) {
            throw new FileTreatmentException();
        }

        // 文字列表現
        public override string ToString() {
            return Name + " (" + Size + ")";
        }
        
        // IAcceptorインターフェースのメソッド
        public abstract void Accept(IVisitor param1);

    }
}