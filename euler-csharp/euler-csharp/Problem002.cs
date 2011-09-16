
using System.Linq;

namespace euler_csharp {
    public class Problem002 {

        public static int Solution() {
            return Fib.Sequence().Where(x => x % 2 == 0).TakeWhile(x => x < 4000000).Sum();
        }
    }
}
