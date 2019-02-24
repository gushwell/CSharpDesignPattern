using System;

namespace Gushwell.DesignPatterns.Prototype.Framework {
    public interface IProduct : IPrototype<IProduct> {
        void Use(string s);
    }    
}
