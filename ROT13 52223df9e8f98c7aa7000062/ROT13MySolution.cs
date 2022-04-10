using System;

namespace CodeWarsSolutions {
    public class ROT13MySolution {
        //https://www.codewars.com/kata/reviews/599a2180a48343e7b900172d/groups/62535684c522ea0001d72d83
        public static string Rot13(string input) {
            string result = "";
            foreach(char c in input) {
                if (char.IsUpper(c)) {
                    result += (c + 13 > 90 ? Convert.ToChar(c - 13) : Convert.ToChar(c + 13));
                    continue;
                }
                if (char.IsLower(c)) {
                    result += (c + 13 > 122 ? Convert.ToChar(c - 13) : Convert.ToChar(c + 13));
                    continue;
                }
                result += c;
            }
            return result;
        }
    }
}
