using System.Linq;
namespace euler_csharp {
    public class Problem001 {
        public static int Solution() {
            return Enumerable.Range(1, 999).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
        }
    }
}
