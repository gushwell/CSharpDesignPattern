using System;

namespace Gushwell.DesignPatterns {

    public sealed class Singleton {
        public static Singleton Instance { get; } = new Singleton();

        private Singleton() {
            Console.WriteLine("インスタンスを生成しました。");
        }
    }
}
