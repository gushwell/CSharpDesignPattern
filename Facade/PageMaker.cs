using System;
using System.Text;
using System.IO;
using System.Collections.Specialized;

namespace Gushwell.DesignPatterns.Facade {

    // このPageMakerがFacadeクラス
    // Database, HtmlWriter を使い、目的とする処理を行う
    public static class PageMaker {
        public static void MakeWelcomePage(string mailAddr, string fileName) {
            try {
                var mailprop = Database.GetProperties("maildata");
                var userName = mailprop.Get(mailAddr);
                var writer =
                    new HtmlWriter(new StreamWriter(fileName, false, Encoding.Default));
                writer.Title("Welcome to " + userName + "'s page!");
                writer.Paragraph(userName + "のページへようこそ。");
                writer.Paragraph("メールまっていますね。");
                writer.Mailto(mailAddr, userName);
                writer.Close();
                Console.WriteLine(fileName + " is created for " + mailAddr +
                                    " (" + userName + ")");
            } catch (System.IO.IOException e) {
                Console.Error.WriteLine(e.StackTrace);
            }
        }
    }
}

