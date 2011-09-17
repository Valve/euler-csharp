using System.Linq;

namespace euler_csharp {
    public class Problem005 {
        public static long Solution() {
            return Enumerable.Range(1, 19).Aggregate(1, Number.LCM);
        }
    }
}
