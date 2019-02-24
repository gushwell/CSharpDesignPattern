using System;

namespace Gushwell.DesignPatterns.BaseFactory {

    public abstract class Item {
        protected string caption;

        public Item(string caption) {
            this.caption = caption;
        }

        public abstract string MakeHTML();
    }
}
