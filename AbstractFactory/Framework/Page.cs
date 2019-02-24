using System;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace Gushwell.DesignPatterns.BaseFactory {

    public abstract class Page {
        protected string title;
        protected string author;
        protected List<Item> content = new List<Item>();

        public Page(string title, string author) {
            this.title = title;
            this.author = author;
        }

        public void Add(Item item) {
            this.content.Add(item);
        }

        public void Output() {
            try {
                var filename = this.title + ".html";
                var writer = new StreamWriter(filename, false, Encoding.UTF8);
                writer.Write(this.MakeHTML());
                writer.Close();
                Console.WriteLine(filename + " を作成しました。");
            } catch (IOException e) {
                Console.Error.WriteLine(e.StackTrace);
            }
        }

        public abstract string MakeHTML();
    }
}

