using System.Numerics;

namespace euler_csharp {
    public class BigNumber {
        public static BigInteger Power(BigInteger a, int power) {
            BigInteger number = a;
            for (int i = 1; i < power; i++) {
                number = number * a;
            }
            return number;
        }
    }
}
