using System;
using Gushwell.DesignPatterns.BaseFactory;

namespace Gushwell.DesignPatterns {
    public class Program {
        public static void Main(string[] args) {
            if (args.Length != 1) {
                const string ListFactoryClass = "Gushwell.DesignPatterns.List.ListFactory";
                const string TableFactoryClass = "Gushwell.DesignPatterns.Table.TableFactory";
                Console.WriteLine("Usage: AbstractFactory TypeName");
                Console.WriteLine("Example 1: AbstractFactory " + ListFactoryClass);
                Console.WriteLine("Example 2: AbstractFactory " + TableFactoryClass);
                return;
            }
            var factory = Factory.GetFactory(args[0]);

            var asahi = factory.CreateLink("朝日新聞", "http://www.asahi.com/");
            var yomiuri = factory.CreateLink("読売新聞", "http://www.yomiuri.co.jp/");

            var us_yahoo = factory.CreateLink("Yahoo!", "http://www.yahoo.com/");
            var jp_yahoo = factory.CreateLink("Yahoo!Japan", "http://www.yahoo.co.jp/");
            var excite = factory.CreateLink("Excite", "http://www.excite.com/");
            var google = factory.CreateLink("Google", "http://www.google.com/");

            var traynews = factory.CreateTray("新聞");
            traynews.Add(asahi);
            traynews.Add(yomiuri);

            var trayyahoo = factory.CreateTray("Yahoo!");
            trayyahoo.Add(us_yahoo);
            trayyahoo.Add(jp_yahoo);

            var traysearch = factory.CreateTray("サーチエンジン");
            traysearch.Add(trayyahoo);
            traysearch.Add(excite);
            traysearch.Add(google);

            var page = factory.CreatePage("LinkPage", "結城 浩");
            page.Add(traynews);
            page.Add(traysearch);
            page.Output();
        }
    }
}

