using System.Linq;

namespace euler_csharp {
    public class Problem014 {
        public static int Solution() {
            return Enumerable.Range(1, 999999).Select(x => new {Number = x, Count = Number.Collatz(x).Count()}).
                OrderByDescending(x => x.Count).First().Number;
        }
    }
}
