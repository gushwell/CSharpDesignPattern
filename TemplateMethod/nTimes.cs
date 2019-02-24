using System;

namespace Gushwell.Dejavu {
    public static class NTimes {
        public static void Times(this int n, Action<int> action) {
            for (var i = 0; i < n; i++) {
                action(i);
            }
        }

        public static void Times(this int n, Action action) {
            for (var i = 0; i < n; i++) {
                action();
            }
        }
    }
}
