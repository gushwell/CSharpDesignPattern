using System;

namespace Gushwell.Design.Patterns {

    public class Program {
        
        public static void Main(string[] args) {
            if (args.Length != 2) {
                Console.WriteLine("Usage: StrategySample randomseed1 randomseed2");
                Console.WriteLine("Example: StrategySample 314 15");
                return;
            }

            var seed1 = int.Parse(args[0]);
            var seed2 = int.Parse(args[1]);
            var player1 = new Player("Taro", new WinningStrategy(seed1));
            var player2 = new Player("Hana", new ProbStrategy(seed2));
            for (var i = 0; i < 1000; i++) {
                var nextHand1 = player1.NextHand();
                var nextHand2 = player2.NextHand();
                Console.WriteLine("{0} {1}", nextHand1.ToString(), nextHand2.ToString());
                if (nextHand1.IsStrongerThan(nextHand2)) {
                    player1.Win();
                    player2.Lose();
                    Console.WriteLine("Winner:" + player1);
                } else if (nextHand2.IsStrongerThan(nextHand1)) {
                    player1.Lose();
                    player2.Win();
                    Console.WriteLine("Winner:" + player2);
                } else {
                    player1.Even();
                    player2.Even();
                    Console.WriteLine("Even...");
                }
            }

            Console.WriteLine("Total result:");
            Console.WriteLine(player1.ToString());
            Console.WriteLine(player2.ToString());
        }
    }
}