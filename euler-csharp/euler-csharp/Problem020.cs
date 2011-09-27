using System;
using System.Linq;

namespace euler_csharp {
    public class Problem020 {
        public static int Solution() {
            return (int)Number.Factorial(100).ToString().ToCharArray().Select(Char.GetNumericValue).Sum();
        }
    }
}
