using System;
using System.IO;
using System.Collections.Specialized;

namespace Gushwell.DesignPatterns.Facade {

    public static class Database {
        // データベース名からPropertiesを得る
        // ここでは、説明を単純化するために、テキストファイルからデータを読み込んでいる
        public static NameValueCollection GetProperties(string dbname) {
            var filename = dbname + ".txt";
            var prop = new NameValueCollection();
            try {
                using (var sr = new StreamReader(filename)) {
                    while (!sr.EndOfStream) {
                        var line = sr.ReadLine();
                        var strs = line.Split('=');
                        prop.Add(strs[0], strs[1]);
                    }
                }
            } catch (System.IO.FileNotFoundException) {
                Console.WriteLine("Warning: " + filename + " is not found.");
            }
            return prop;
        }
    }
}

