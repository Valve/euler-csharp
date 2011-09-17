using System;
using System.Collections.Generic;
using System.Linq;

namespace euler_csharp {
    public class Problem006 {
        public static int Solution() {
            return Difference(Enumerable.Range(1, 100));
        }

        private static int Difference(IEnumerable<int> numbers) {
            int squareOfSums = (int)Math.Pow(numbers.Sum(), 2);
            int sumOfSquares = numbers.Select(x => x * x).Sum();
            return squareOfSums - sumOfSquares;
        }
    }
}
