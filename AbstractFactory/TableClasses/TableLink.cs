using System;
using Gushwell.DesignPatterns.BaseFactory;


namespace Gushwell.DesignPatterns.Table {

    public class TableLink : Link {
        public TableLink(string caption, string url)
            : base(caption, url) {
        }

        public override string MakeHTML() {
            return "<td><a href=\"" + url + "\">" + caption + "</a></td>";
        }
    }
}

