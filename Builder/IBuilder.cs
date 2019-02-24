using System;

namespace Gushwell.DesignPatterns {
    public interface IBuilder {
        void MakeTitle(string title);
        void MakeString(string str);
        void MakeItems(string[] items);
        void Close();
        string Result { get; }
    }
}
