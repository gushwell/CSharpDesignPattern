using System;

namespace Gushwell.DesignPatterns {
    public class Program {
        public static void Main(string[] args) {
            if (args.Length == 0) {
                Console.WriteLine("Usage: Flyweight digits");
                Console.WriteLine("Example: Flyweight 1212123");
                return;
            }
            var bs = new BigString(args[0]);
            bs.Print();
        }
    }
}
