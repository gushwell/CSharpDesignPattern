using System;
using System.Collections.Generic;

namespace Gushwell.DesignPatterns.Prototype.Framework {

    public class Manager {
        private readonly Dictionary<string,IProduct> showcase = new Dictionary<string,IProduct>();

        // Prototypeを登録する
        public void Register(string name, IProduct proto) {
            showcase[name] = proto;
        }

        // インスタンスを生成する。実際には、登録済みのプロトタイプの複製を返す。
        // これがこのパターンの肝。Flyweightとはここが異なる。
        public IProduct Create(string protoname) {
            var p = showcase[protoname];
            return p.Clone();
        }
    }
}
