using System;

namespace Gushwell.DesignPatterns.BaseFactory {

    public abstract class Link : Item {
        protected string url;

        public Link(string caption, string url)
            : base(caption) {
            this.url = url;
        }
    }
}
