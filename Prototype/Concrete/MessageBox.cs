using System;
using Gushwell.DesignPatterns.Prototype.Framework;
using Prototype.Framework;

namespace Gushwell.DesignPatterns.Prototype {
    // Prototypeの具象クラス
    public class MessageBox : IProduct {
        private char decoChar;
        public MessageBox(char decochar) {
            this.decoChar = decochar;
        }

        public void Use(string s) {
            var length = StringWidth.Get(s) + 4;
            Console.WriteLine(new string(decoChar,length));

            Console.WriteLine("{0} {1} {0}",decoChar,s);

            Console.WriteLine(new string(decoChar, length));
        }

        public IProduct Clone() {
            return (IProduct)MemberwiseClone();
        }

    }
}
