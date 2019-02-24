using System;
using Gushwell.DesignPatterns.Framework;
using Gushwell.DesignPatterns.Concrete;
using Gushwell.Dejavu;

namespace Gushwell.DesignPatterns {
    public class Program {
        public static void Main(string[] args) {
            // Factoryクラスは、IProductを実装していれば、IDCard以外のインスタンスも生成できる
            var factory = new ProductFactory<IDCard>();

            // これ以降は、IDCardという具象クラスには依存していない
            // IDCardではなく、IProductというインターフェースに対してプログラミングしている。
            IProduct card1 = factory.Create("結城浩");
            IProduct card2 = factory.Create("とむら");
            IProduct card3 = factory.Create("佐藤花子");
            card1.Use();
            card2.Use();
            card3.Use();

            factory.Owners.ForEach(owner => Console.WriteLine(owner));
        }

    }
}
