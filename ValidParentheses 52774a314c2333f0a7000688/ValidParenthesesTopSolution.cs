namespace CodeWarsSolutions  {
    // https://www.codewars.com/kata/reviews/59960ed4f017e45f6000156b/groups/59a4a683ec1f9fc29c004064
    public class ValidParenthesesTopSolution {
        public static bool ValidParentheses(string input) {
            int parentheses = 0;
            foreach (char t in input) {
                if (t == '(') {
                    parentheses++;
                } else if (t == ')') {
                    parentheses--;

                    if (parentheses < 0) {
                        return false;
                    }
                }
            }

            return parentheses == 0;
        }
    }
}
