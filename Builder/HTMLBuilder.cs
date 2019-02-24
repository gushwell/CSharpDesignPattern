using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Gushwell.Dejavu;
using System.Text;

namespace Gushwell.DesignPatterns {
    // オリジナルはファイルに書き出す実装だったが、ここでは、Stringを生成するだけにする
    // 実際にファイルに書き出すかどうかは、利用者側にゆだねる。
    public class HTMLBuilder : IBuilder {
        private StringBuilder buffer = new StringBuilder();

        // 完成した文書
        public string Result {
            get { return buffer.ToString(); }
        }

        // HTMLファイルでのタイトル
        public void MakeTitle(string title) {
            // タイトルを出力
            buffer.AppendLine("<!DOCTYPE html>");
            buffer.AppendLine("<html><head><meta charset=\"utf-8\" >");
            buffer.AppendLine($"<title>{title}</title></head>");
            buffer.AppendLine("<body>");
            buffer.AppendLine($"<h1>{title}</h1>");
        }

        // HTMLファイルでの文字列
        public void MakeString(string str) {
            buffer.AppendLine($"<p>{str}</p>");         // <p>タグで出力
        }

        // HTMLファイルでの箇条書き
        public void MakeItems(string[] items) {
            buffer.AppendLine("<ul>");                       // <ul>と<li>で出力
            items.ForEach(str => buffer.AppendLine($"<li>{str}</li>"));
            buffer.AppendLine("</ul>");
        }

        // 文書の完成
        public void Close() {
            buffer.AppendLine("</body></html>");             // タグを閉じる
        }
    }
}
