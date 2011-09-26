using System;

namespace euler_csharp {
    public class Problem019 {
        public static int Solution() {
            var start = new DateTime(1901, 1, 1);
            var end = new DateTime(2000, 12, 31);
            int counter = 0;
            while (start <= end) {
                if (start.DayOfWeek == DayOfWeek.Sunday) ++counter;
                start = start.AddMonths(1);
            }
            return counter;
        }
    }
}
