using System;

namespace Gushwell.DesignPatterns {
    public interface IPrintable {
        string PrinterName { get; set; }
        void Print(string text);  // 文字列表示(プリントアウト)
    }
}

