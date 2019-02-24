using System;

namespace Gushwell.DesignPatterns {

    // オブジェクトを生成するのに複雑な手順を踏む必要がある場合は、
    // このようなクラスてお定義し、隠蔽してしまえば、オブジェクトの生成はとても楽になる。
    // なお、IBuilder にしか依存していないので、様々な実装に対応できる。
    public class Director {
        private IBuilder builder;

        public Director(IBuilder builder) {
            // Builderのサブクラスのインスタンスが与えられるので、
            // builderフィールドに保持しておく。
            this.builder = builder;
        }

        public void Construct() {
            // builderを使って文書構築
            builder.MakeTitle("Greeting");              // タイトル
            builder.MakeString("朝から昼にかけて");     // 文字列
            builder.MakeItems(new string[] { "おはようございます。", "こんにちは。" });
            builder.MakeString("夜に");                 // 別の文字列
            builder.MakeItems(new string[] { "こんばんは。", "おやすみなさい。", "さようなら。" });
            builder.Close();                            // 文書を完成させる
        }
    }
}
