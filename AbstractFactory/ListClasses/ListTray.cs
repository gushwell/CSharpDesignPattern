using System;
using System.Text;
using Gushwell.DesignPatterns.BaseFactory;

namespace Gushwell.DesignPatterns.List {

    public class ListTray : Tray {
        public ListTray(string caption)
            : base(caption) {
        }

        public override string MakeHTML() {
            var buffer = new StringBuilder();
            buffer.AppendLine("<li>");
            buffer.AppendLine(caption);
            buffer.AppendLine("<ul>");
            tray.ForEach(item => buffer.AppendLine(item.MakeHTML()));
            buffer.AppendLine("</ul>");
            buffer.AppendLine("</li>");
            return buffer.ToString();
        }
    }
}

