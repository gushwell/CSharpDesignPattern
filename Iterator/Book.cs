using System;

namespace Gushwell.Design.Patterns {
    public class Book {
        private string name;

        public Book(System.String name) {
            this.name = name;
        }

        public string Name {
            get { return name; }
        }
    }
}

