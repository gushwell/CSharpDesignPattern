using System;
using System.Text;
using Gushwell.DesignPatterns.BaseFactory;

namespace Gushwell.DesignPatterns.Table {

    public class TablePage : Page {
        public TablePage(string title, string author)
            : base(title, author) {
        }

        public override string MakeHTML() {
            var buffer = new StringBuilder();
            buffer.AppendLine("<!DOCTYPE html>");
            buffer.AppendLine("<html><head><title>" + title + "</title>");
            buffer.AppendLine("<link rel=\"stylesheet\" href=\"style.css\" >");
            buffer.AppendLine("</head>");
            buffer.AppendLine("<body>");
            buffer.AppendLine("<h1>" + title + "</h1>");
            buffer.AppendLine("<table width=\"80%\" >");

            content.ForEach(item =>
                buffer.AppendLine("<tr>" + item.MakeHTML() + "</tr>"));

            buffer.AppendLine("</table>");
            buffer.AppendLine("<hr><address>" + author + "</address>");
            buffer.AppendLine("</body></html>");
            return buffer.ToString();
        }
    }
}

