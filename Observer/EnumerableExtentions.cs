using System;
using System.Collections.Generic;

namespace Gushwell.Dejavu {
    public static class EnumerableExtentions {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action) {
            foreach (var x in source) {
                action(x);
            }
        }
    }
}
