// おまけ
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gushwell.DesignPatterns {
    // インスタンスを３つに限定です。
    public class Triple {
        public static Triple GetInstance(int n) {
            return triple[n];
        }

        private static readonly Triple[] triple = 
            new[] { new Triple(), new Triple(), new Triple() };

        private Triple() {
            Console.WriteLine("インスタンスを生成しました。");
        }
    }
}
