using System;
using System.Linq;

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
    }
}
