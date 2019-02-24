using System;
using System.IO;

namespace Gushwell.DesignPatterns {
    public class Program {
        public static void Main(string[] args) {
            if (args.Length != 1) {
                Usage();
                return;
            }
            if (args[0].Equals("plain")) {
                var textbuilder = new TextBuilder();
                var result = DoWork(textbuilder, "sample.txt");
                Console.WriteLine(result);
            } else if (args[0].Equals("html")) {
                var htmlbuilder = new HTMLBuilder();
                var result = DoWork(htmlbuilder, "sample.html");
                Console.WriteLine(result);
            } else {
                Usage();
                return;
            }
        }

        private static string DoWork(IBuilder builder, string filename = null) {
            var director = new Director(builder);
            director.Construct();
            var result = builder.Result;
            if (filename != null) {              
                try {
                    using (var writer = new StreamWriter(filename, false)) {
                        writer.Write(result);
                    }
                } catch (System.IO.IOException e) {
                    Console.WriteLine(e.StackTrace);
                }
            }
            return builder.Result;
        }

        private static void Usage() {
            Console.WriteLine("Usage: BuilderSample plain プレーンテキストで文書作成");
            Console.WriteLine("Usage: BuilderSample html  HTMLファイルで文書作成");
        }
    }
}
