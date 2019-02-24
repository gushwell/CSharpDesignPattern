using System;
using System.Linq;
using Gushwell.Dejavu;

namespace Gushwell.DesignPatterns {
    // Visitor具象クラス
    public class ListVisitor : IVisitor {
        private string currentdir = ""; // 現在注目しているディレクトリ名

        // ファイルを訪問したときに呼ばれる
        public void Visit(File file) {
            Console.WriteLine(currentdir + "/" + file);
        }

        // ディレクトリを訪問したときに呼ばれる
        public void Visit(Directory directory) {
            Console.WriteLine(currentdir + "/" + directory);
            var savedir = currentdir;
            currentdir = currentdir + "/" + directory.Name;
            // Directoryは、IEnumerable<Entry>を実装している。
            // directory配下のすべてのEntryを受け入れる。
            directory.ForEach(e => e.Accept(this));
            currentdir = savedir;
        }
    }
}
