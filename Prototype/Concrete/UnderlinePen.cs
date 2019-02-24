using System;
using System.Text;
using Gushwell.DesignPatterns.Prototype.Framework;
using Prototype.Framework;

namespace Gushwell.DesignPatterns.Prototype {
    // Prototypeの具象クラス
    public class UnderlinePen : IProduct {
        private readonly char ulchar;
        public UnderlinePen(char ulchar) {
            this.ulchar = ulchar;
        }

        public void Use(string s) {
            var length = StringWidth.Get(s);

            Console.WriteLine("\"{0}\"",s);
            Console.Write(" ");
            Console.WriteLine(new string(ulchar,length));
        }

        public IProduct Clone() {
            return (IProduct)MemberwiseClone();
        }


    }
}
