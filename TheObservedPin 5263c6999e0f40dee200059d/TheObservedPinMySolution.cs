using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWarsSolutions {
    //https://www.codewars.com/kata/reviews/5b4c9bfbe35052a1a2001f04/groups/6245e01bbe56650001011899
    public class TheObservedPinMySolution {
        static Dictionary<char, char[]> adjacents = new Dictionary<char, char[]>() {
            { '1', new char[] { '2', '4' } },
            { '2', new char[] { '1', '3', '5'} },
            { '3', new char[] { '2', '6' } },
            { '4', new char[] { '1', '5', '7' } },
            { '5', new char[] { '2', '4', '6', '8' } },
            { '6', new char[] { '3', '5', '9' } },
            { '7', new char[] { '4', '8' } },
            { '8', new char[] { '5', '7', '9', '0' } },
            { '9', new char[] { '6', '8' } },
            { '0', new char[] { '8' } },
        };

        public static List<string> GetPINs(string observed) {
            List<string> results = findNewPossibilities(new List<string>() { observed }, 0);

            return results.Distinct().ToList();
        }

        public static List<string> findNewPossibilities(List<string> list, int digitNr) {
            List<string> newPossibilities = new List<string>(list);

            foreach (var combination in list) {
                char[] altDigits = adjacents.GetValueOrDefault(combination[digitNr]);

                foreach (char c in altDigits) {
                    newPossibilities.Add(combination.Remove(digitNr, 1).Insert(digitNr, c.ToString()));
                }
            }

            if (digitNr + 1 == list[0].Length) {
                return newPossibilities;
            }

            return findNewPossibilities(newPossibilities, digitNr + 1);
        }
    }
}
