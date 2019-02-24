using System;
using Gushwell.DesignPatterns.Framework;

namespace Gushwell.DesignPatterns.Concrete {

    public class IDCard : IProduct {

        public IDCard(string owner) {
            this.Owner = owner;
            Console.WriteLine("{0} のカードを作ります。", Owner);
        }

        public void Use() {
            Console.WriteLine("{0} のカードを使います。", Owner);
        }

        public string Owner { get; }
        

    }
}
