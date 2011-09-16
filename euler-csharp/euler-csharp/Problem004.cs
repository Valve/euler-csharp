using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace euler_csharp {
    public class Problem004 {
        public static int Solution() {
            return Multiplications(800, 999).Where(Palindrome.IsPalindrome).Max();
        }

        public static IEnumerable<int> Multiplications(int n1, int n2) {
            for (int i = n1; i <= n2; i++) {
                for (int j = n1; j <= n2; j++) {
                    yield return i * j;
                }
            }
        }
    }
}
