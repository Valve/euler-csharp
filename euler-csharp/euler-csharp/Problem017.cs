using System.Text;

namespace euler_csharp {
    public class Problem017 {
        private static string[] Numerals = {
                                               "one", 
                                               "two", 
                                               "three", 
                                               "four", 
                                               "five", 
                                               "six", 
                                               "seven", 
                                               "eight", 
                                               "nine", 
                                               "ten", 
                                               "eleven", 
                                               "twelve", 
                                               "thirteen", 
                                               "fourteen",
                                               "fifteen",
                                               "sixteen",
                                               "seventeen",
                                               "eighteen",
                                               "nineteen"
                                           };

        private static string[] Scores = {
                                             "ten",
                                             "twenty",
                                             "thirty",
                                             "forty",
                                             "fifty",
                                             "sixty",
                                             "seventy",
                                             "eighty",
                                             "ninety"
                                         };
        public static string NumberToWords(int number) {
            int thousands = number / 1000;
            int hundreds = (number % 1000) / 100;
            int belowHundredRemainder = (number % 1000) % 100;
            int scores = ((number % 1000) % 100) / 10;
            int digits = ((number % 1000) % 100) % 10;
            var stringBuilder = new StringBuilder();
            if (thousands > 0) {
                stringBuilder.AppendFormat("{0} thousand", Numerals[thousands - 1]);
            }
            if (hundreds > 0) {
                if (stringBuilder.Length > 0) stringBuilder.Append(" and ");
                stringBuilder.AppendFormat("{0} hundred", Numerals[hundreds - 1]);
            }
            if (belowHundredRemainder == 0) return stringBuilder.ToString();
            if (belowHundredRemainder < 20) {
                //1-19 special case
                if (stringBuilder.Length > 0) stringBuilder.AppendFormat(" and ");
                stringBuilder.Append(Numerals[belowHundredRemainder - 1]);
            }
            else {
                //20-99
                if (stringBuilder.Length > 0) stringBuilder.Append(" and ");
                if (scores > 0) {
                    stringBuilder.AppendFormat("{0}", Scores[scores - 1]);
                }
                if (digits > 0) {
                    if(scores>0) stringBuilder.Append("-");
                    stringBuilder.Append(Numerals[digits - 1]);
                }
            }
            return stringBuilder.ToString();

        }

        public static int Solution() {
            var stringBuilder = new StringBuilder();
            for(int i = 1;i<=1000;i++) {
                stringBuilder.Append(NumberToWords(i).Replace(" ", "").Replace("-", ""));
            }
            return stringBuilder.ToString().Length;
        }
    }
}
