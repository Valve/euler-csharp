

using System.Collections.Generic;

namespace euler_csharp {
    public class Fib {
        public static IEnumerable<int> Sequence() {
            int a = 1;
            int b = 1;
            int c = 1;
            yield return a;
            while (c <= int.MaxValue) {
                yield return b;
                c = a;
                a = b;
                b = c + b;
            }
        }
    }
}
