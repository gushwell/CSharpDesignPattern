using System;
using System.Text;
using Gushwell.DesignPatterns.BaseFactory;

namespace Gushwell.DesignPatterns.Table {

    public class TableTray : Tray {
        public TableTray(string caption)
            : base(caption) {
        }

        public override string MakeHTML() {
            var buffer = new StringBuilder();
            buffer.Append("<td>");
            buffer.Append("<table width=\"100%\"><tr>");
            buffer.Append("<th align=\"center\" colspan=\"" +
                tray.Count + "\">" + caption + "</th>");
            buffer.AppendLine("</tr>");
            buffer.AppendLine("<tr>");

            tray.ForEach(item =>
                buffer.Append(item.MakeHTML()));

            buffer.Append("</tr></table>");
            buffer.Append("</td>");
            return buffer.ToString();
        }
    }
}

