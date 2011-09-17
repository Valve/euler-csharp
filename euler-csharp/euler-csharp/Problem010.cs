using System.Linq;

namespace euler_csharp {
    public class Problem010 {
        public static long Solution() {
            return Prime.LongSequence().Skip(1).TakeWhile(x => x < 2000000).Sum();
        }
    }
}
