using System;

namespace Gushwell.DesignPatterns {
    // Accepterインターフェース
    public interface IAcceptor {
        void Accept(IVisitor v);
    }
}