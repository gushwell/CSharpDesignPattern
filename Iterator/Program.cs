using System;
using System.Linq;
using Gushwell.Dejavu;

namespace Gushwell.Design.Patterns {
    public class Program {
        
        public static void Main(string[] args) {
            var bookShelf = new BookShelf(4);
            bookShelf.AppendBook(new Book("Around the World in 80 Days"));
            bookShelf.AppendBook(new Book("Bible"));
            bookShelf.AppendBook(new Book("Cinderella"));
            bookShelf.AppendBook(new Book("Daddy-Long-Legs"));

            // foreach文が使える
            foreach (var b in bookShelf) {
                Console.WriteLine(b.Name);
            }
            Console.WriteLine();

            // LINQ to Objectsが使える
            var books = bookShelf.Where(b => b.Name.Length > 10);
            books.ForEach(b => Console.WriteLine(b.Name));
            Console.WriteLine();

            
            // もう一つの書き方: MoveNextとCurrentで順に取り出す。
            var ite = bookShelf.GetEnumerator();
            Book book = null;
            while (ite.MoveNext()) {
                book = ite.Current;
                Console.WriteLine(book.Name);
            }
            ite.Dispose();
            Console.WriteLine();

            // おまけ: インデクサも定義してあるので配列のようにアクセスできる
            for (var i = 0; i < bookShelf.Length; i++) {
                Console.WriteLine(bookShelf[i].Name);
            }
        }
    }
}

