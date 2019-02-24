using System;
using System.Text;
using Gushwell.DesignPatterns.BaseFactory;

namespace Gushwell.DesignPatterns.List {

    public class ListPage : Page {
        public ListPage(string title, string author)
            : base(title, author) {
        }

        public override string MakeHTML() {
            var buffer = new StringBuilder();
            buffer.AppendLine("<!DOCTYPE html>");
            buffer.AppendLine("<html><head><title>" + title + "</title></head>");
            buffer.AppendLine("<body>");
            buffer.AppendLine("<h1>" + title + "</h1>");
            buffer.AppendLine("<ul>");
            content.ForEach(item => buffer.Append(item.MakeHTML()));
            buffer.AppendLine("</ul>");
            buffer.AppendLine("<hr><address>" + author + "</address>");
            buffer.AppendLine("</body></html>");
            return buffer.ToString();
        }
    }
}

