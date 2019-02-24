using System;
using System.Threading;

namespace Gushwell.DesignPatterns {

    // w“ÇÒƒNƒ‰ƒX‚ÍAIObserver<T>‚ğÀ‘•‚·‚é‚Ì‚ªC#—¬

    public class DigitObserver : IObserver<int> {
        public void OnCompleted() {
 
        }

        public void OnError(Exception error) {

        }

        public void OnNext(int value) {
            Console.WriteLine("DigitObserver:" + value);
            Thread.Sleep(100);
        }

    }
}
