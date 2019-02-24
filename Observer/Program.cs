using System;
using System.Threading;

namespace Gushwell.DesignPatterns {

    public class Program {
        
        public static void Main(string[] args) {
            var generator = new RandomNumberGenerator();

            var observer1 = new DigitObserver();
            var observer2 = new GraphObserver();
            generator.Subscribe(observer1);
            generator.Subscribe(observer2);
            generator.Execute();
        }
    }
}
