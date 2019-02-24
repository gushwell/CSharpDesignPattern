using System;
using Gushwell.DesignPatterns.Facade;

namespace Gushwell.DesignPatterns {

    public static class Program {
        public static void Main(string[] args) {
            PageMaker.MakeWelcomePage("hyuki@hyuki.com", "welcome.html");
        }
    }
}

