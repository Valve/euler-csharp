using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace euler_csharp {
    public class Problem014 {
        public static int Solution() {
            return Enumerable.Range(1, 999999).Select(x => new {Number = x, Count = Number.Collatz(x).Count()}).
                OrderByDescending(x => x.Count).First().Number;
        }
    }
}
