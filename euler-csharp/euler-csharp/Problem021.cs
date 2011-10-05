using System.Linq;

namespace euler_csharp {
    public class Problem021 {
        public static int Solution() {
            return Enumerable.Range(1, 9999).Where(Number.IsAmicableNumber).ToArray().Sum();
        }
    }
}
