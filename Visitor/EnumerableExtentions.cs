using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gushwell.Dejavu {
    public static class EnumerableExtentions {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action) {
            foreach (var x in source) {
                action(x);
            }
        }
    }
}
