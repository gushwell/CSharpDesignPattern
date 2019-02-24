using System;
using Gushwell.DesignPatterns.BaseFactory;

namespace Gushwell.DesignPatterns.List {

    public class ListLink : Link {
        public ListLink(string caption, string url)
            : base(caption, url) {
        }

        public override string MakeHTML() {
            return "  <li><a href=\"" + url + "\">" + caption + "</a></li>";
        }
    }
}
