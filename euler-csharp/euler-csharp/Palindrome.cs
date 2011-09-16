
using System;

namespace euler_csharp {
    public class Palindrome {
        public static bool IsPalindrome(int number) {
            string s1 = number.ToString();
            var chars = number.ToString().ToCharArray();
            Array.Reverse(chars);
            string s2 = new string(chars);
            return s1 == s2;
        }
    }
}
