using System;

namespace Gushwell.DesignPatterns {
    // Compositeパターンを使えば、木構造を伴う再帰的なデータ構造を扱うことができまる。

    public class Program {
        public static void Main(string[] args) {
            try {
                Console.WriteLine("Making root entries...");
                (new File("latex", 20000)).PrintList("");
                var rootdir = new Directory("root");
                var bindir = new Directory("bin");
                var tmpdir = new Directory("tmp");
                var usrdir = new Directory("usr");
                rootdir.Add(bindir);
                rootdir.Add(tmpdir);
                rootdir.Add(usrdir);
                bindir.Add(new File("vi", 10000));
                bindir.Add(new File("latex", 20000));
                rootdir.PrintList();

                Console.WriteLine("");
                Console.WriteLine("Making user entries...");
                var yuki = new Directory("yuki");
                var hanako = new Directory("hanako");
                var tomura = new Directory("tomura");
                usrdir.Add(yuki);
                usrdir.Add(hanako);
                usrdir.Add(tomura);
                yuki.Add(new File("diary.html", 100));
                yuki.Add(new File("Composite.java", 200));
                hanako.Add(new File("memo.tex", 300));
                tomura.Add(new File("game.doc", 400));
                tomura.Add(new File("junk.mail", 500));
                rootdir.PrintList();

                Console.WriteLine(rootdir.Size);
                Console.WriteLine(rootdir);
            }
            catch (NotSupportedException e) {
                Console.WriteLine(e.StackTrace.ToString());
            }
        }
    }
}

