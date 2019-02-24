using System;

namespace Gushwell.DesignPatterns.Prototype.Framework {
    // Prototypeのインターフェース
    public interface IPrototype<T>  {
        T Clone();
    }
}
