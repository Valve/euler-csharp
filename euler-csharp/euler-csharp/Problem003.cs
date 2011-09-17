using System.Linq;

namespace euler_csharp {
    public class Problem003 {
        public static int Solution(long value) {
            return Prime.Factorize(value).Max();
        }
    }
}
