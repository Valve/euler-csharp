using System;
using System.Linq;
using System.Numerics;

namespace euler_csharp {
    public class Problem016 {
        public static int Solution() {
            return (int)BigNumber.Power(new BigInteger(2), 1000).ToString().ToCharArray().Select(Char.GetNumericValue).Sum();
        }
    }
}
