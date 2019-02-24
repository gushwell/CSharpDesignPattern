using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gushwell.DesignPatterns {
    public interface IBanner {
        void ShowWithParen();
        void ShowWithAster();
        string Text { get; set; }
    }
}
