using System;
using System.Collections.Generic;
using System.Linq;


namespace euler_csharp {
    public class Prime {
        public static bool IsPrime(int candidate) {
            if ((candidate & 1) != 0) {
                int limit = (int)Math.Sqrt(candidate);
                for (int divisor = 3; divisor <= limit; divisor += 2) {
                    if ((candidate % divisor) == 0)
                        return false;
                }
                return true;
            }
            return (candidate == 2);
        }

        public static bool IsPrime(long candidate) {
            if ((candidate & 1) != 0) {
                long limit = (long)Math.Sqrt(candidate);
                for (long divisor = 3; divisor <= limit; divisor += 2) {
                    if ((candidate % divisor) == 0)
                        return false;
                }
                return true;
            }
            return (candidate == 2);
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
        public static IEnumerable<long> LongSequence() {
            yield return 1;
            yield return 2;
            for (long i = 3; i <= long.MaxValue; i++) {
                if (i % 2 != 0 && IsPrime(i)) {
                    yield return i;
                }
            }
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
