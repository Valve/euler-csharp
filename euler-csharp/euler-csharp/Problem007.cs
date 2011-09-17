using System.Linq;

namespace euler_csharp {
    public class Problem007 {
        public static int Solution() {
            return Prime.Sequence().Skip(10001).Take(1).First();
        }
    }
}
