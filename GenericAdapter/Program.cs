using System;

namespace Gushwell.DesignPatterns {
    public class Program {
        public static void Main(string[] args) {
            IPrint p = new PrintBanner<Banner>("Hello");
            p.PrintWeak();
            p.PrintStrong();
            Console.ReadLine();
        }
    }
}

