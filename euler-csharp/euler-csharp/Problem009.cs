using System;


namespace euler_csharp {
    public class Problem009 {
        public static int Solution() {
            for (int a = 1; a < 1000; a++) {
                for (int b = 1; b < 1000; b++) {
                    double c = Math.Sqrt(a*a + b*b);
                    if(a + b + c == 1000) {
                        return (int)(a * b * c);
                    }

                }
            }
            return -1;
        }
    }
}
