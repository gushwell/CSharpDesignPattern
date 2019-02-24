using System;
using System.IO;

namespace Gushwell.DesignPatterns.Facade {

    public class HtmlWriter {
        private StreamWriter writer;

        // コンストラクタ
        public HtmlWriter(StreamWriter writer) {
            this.writer = writer;
        }

        // タイトルの出力
        public virtual void Title(string title) {
            writer.WriteLine("<!DOCTYPE html>");
            writer.WriteLine("<html>");
            writer.WriteLine("<head>");
            writer.WriteLine("<title>" + title + "</title>");
            writer.WriteLine("</head>");
            writer.WriteLine("<body>");
            writer.WriteLine("<h1>" + title + "</h1>");        }

        // 段落の出力
        public virtual void Paragraph(string msg) {
            writer.WriteLine("<p>" + msg + "</p>");
        }

        // リンクの出力
        public virtual void Link(string href, string caption) {
            Paragraph("<a href=\"" + href + "\">" + caption + "</a>");
        }

        // メールアドレスの出力
        public virtual void Mailto(string mailaddr, string userName) {
            Link("mailto:" + mailaddr, userName);
        }

        // 閉じる
        public virtual void Close() {
            writer.WriteLine("</body>");
            writer.WriteLine("</html>");
            writer.Close();
        }
    }
}

