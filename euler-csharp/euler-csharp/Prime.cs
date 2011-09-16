using System.Collections.Generic;
using System.Linq;


namespace euler_csharp {
    public class Prime {
        public static bool IsPrime(int x) {
            if (x == 1 || x == 2 || x == 3 || x == 5 || x == 7) return true;
            bool prime = true;
            for (int i = 2; i < x; i++) {
                if (x % i == 0) {
                    prime = false;
                    break;
                }
            }
            return prime;

        }
        public static IEnumerable<int> Sequence() {
            yield return 1;
            yield return 2;
            for (int i = 3; i <= int.MaxValue; i++) {
                if (i % 2 != 0 && IsPrime(i)) {
                    yield return i;
                }
            }
            yield break;
        }

        public static IEnumerable<int> Factorize(long value) {
            foreach (int prime in Sequence().Skip(1)) {
                while (value % prime == 0) {
                    yield return prime;
                    value /= prime;
                }
                if (value == 1) yield break;
            }
        }
    }
}
