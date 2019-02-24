using System;
using System.Collections.Generic;
using System.Linq;
using Gushwell.Dejavu;

namespace Gushwell.DesignPatterns {
    public class RandomNumberGenerator : NumberGenerator {

        public override void Execute() {
            RandomMaker.Random(51).Take(20)
                .ForEach(n => OnStepped(n));
        }
    }

    // LINQ の機能を使ってみました。
    public static class RandomMaker {
        // 0 - maxValue-1 の間で乱数を無限に発生させる。
        public static IEnumerable<int> Random(int maxValue) {
            var random = new Random();
            while (true) {
                yield return random.Next(maxValue);
            }
        }
    }
}
