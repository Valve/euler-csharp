
using System;
using System.Linq;
using System.Numerics;


namespace euler_csharp {
    class Program {
        static void Main() {
            var j = Number.Collatz(9);

            var i = Enumerable.Range(900000, 99999)
                .Select(x => new {Index = x, Numbers = Number.Collatz(x).Count()})
                .OrderByDescending(x => x.Numbers).ToArray().First().Index;

            Console.WriteLine(i);

            //Console.WriteLine(Problem013.Solution());
        }
    }
}
