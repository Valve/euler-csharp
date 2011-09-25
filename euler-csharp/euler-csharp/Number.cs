using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace euler_csharp {
    public class Number {
        public static int GCD(int n1, int n2) {
            int max = Math.Max(n1, n2);
            int min = Math.Min(n1, n2);
            while (max % min != 0) {
                int tmp = min;
                min = max % min;
                max = tmp;
            }
            return min;
        }



        public static int LCM(int n1, int n2) {
            return n1 * n2 / GCD(n1, n2);
        }

        public static int NumberOfDivisors(int number) {
            if (number == 1) return 1;
            var factors = Prime.Factorize(number);
            var q = from o in factors
                    group o by o into g
                    select g.Count() + 1;
            var r = q.Aggregate((x, y) => x * y);
            return r;
        }

        public static IEnumerable<int> Triangulars() {
            int sum = 0;
            for (int i = 1; i < int.MaxValue; i++) {
                sum += i;
                yield return sum;
            }
        }

        public static IEnumerable<long> Collatz(long number) {
            while (number > 1) {
                yield return number;
                if (number % 2 == 0) {
                    number /= 2;
                }
                else {
                    number = number * 3 + 1;
                }
            }
            yield return number;

        }

        public static IEnumerable<BigInteger> BigIntegerRange(int start, int count) {
            for(int i = start;i<=count;i++) {
                yield return new BigInteger(i);
            }
        }

        public static BigInteger Factorial(int n) {
            return BigIntegerRange(1,n).Aggregate<BigInteger, BigInteger>(1, (a, b) => a * b);
        }

        public static BigInteger MultisetPermutations(int n) {
            return Factorial(n) / (Factorial(n / 2) * Factorial(n / 2));
        }
    }
}
