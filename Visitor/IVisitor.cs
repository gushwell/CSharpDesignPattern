using System;

namespace Gushwell.DesignPatterns {
    // Visitorインターフェース
    public interface IVisitor {
        void Visit(File file);
        void Visit(Directory directory);
    }
}