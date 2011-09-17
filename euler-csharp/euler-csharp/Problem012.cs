using System.Linq;

namespace euler_csharp {
    public class Problem012 {
        public static int Solution() {
            return Number.Triangulars().Where(x => Number.NumberOfDivisors(x) > 500).First();
        }
    }
}
