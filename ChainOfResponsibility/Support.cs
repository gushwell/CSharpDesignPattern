using System;

namespace Gushwell.DesignPatterns {

    public abstract class Support {
        private string name; // このトラブル解決者の名前
        private Support next; // たらい回しの先

        // トラブル解決者の生成
        public Support(string name) {
            this.name = name;
        }

        // たらい回しの先を設定
        public virtual Support SetNext(Support next) {
            this.next = next;
            return next;
        }

        // トラブル解決の手順
        public void DoSupport(Trouble trouble) {
            if (Resolve(trouble)) {
                Done(trouble);
            } else if (next != null) {
                next.DoSupport(trouble);
            } else {
                Fail(trouble);
            }
        }
        // 文字列表現
        public override string ToString() {
            return "[" + name + "]";
        }

        // 解決用メソッド
        protected abstract bool Resolve(Trouble trouble);

        // 解決
        protected virtual void Done(Trouble trouble) {
            Console.WriteLine(trouble + " is resolved by " + this + ".");
        }

        // 未解決
        protected virtual void Fail(Trouble trouble) {
            Console.WriteLine(trouble + " cannot be resolved.");
        }
    }
}