using System;

namespace Gushwell.Design.Patterns {

    public interface IStrategy {
        Hand NextHand();
        void Study(bool win);
    }
}