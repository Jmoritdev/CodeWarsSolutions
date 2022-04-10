using System;
using System.Linq;
public class Kata {
    //https://www.codewars.com/kata/reviews/599a2180a48343e7b900172d/groups/599a83857781220eb100014e
    public static string Rot13(string input) {
        var s1 = "NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm";
        var s2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        return string.Join("", input.Select(x => char.IsLetter(x) ? s1[s2.IndexOf(x)] : x));
    }
}