using System;
using System.Collections.Generic;

namespace Gushwell.Design.Patterns {
    // IEnumerable<T>を実装するのがC#流
    public class BookShelf : IEnumerable<Book> {
        private Book[] books;
        private int last = 0;

        public BookShelf(int maxsize) {
            this.books = new Book[maxsize];
        }

        public virtual int Length {
            get { return last; }
        }

        public virtual Book this[int index] {
            get { return books[index]; }
        }

        public virtual void AppendBook(Book book) {
            this.books[last] = book;
            last++;
        }

        public virtual IEnumerator<Book> GetEnumerator() {
            for (var i = 0; i < Length; i++) {
                yield return this[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
            return this.GetEnumerator();
        }
    }
}

