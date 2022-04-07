namespace CodeWarsSolutions {
    //https://www.codewars.com/kata/reviews/59960ed4f017e45f6000156b/groups/624e2b10ae3ae80001856f6b
    public class ValidParenthesesMySolution {
        public static bool ValidParentheses(string input) {
            int depth = 0;
            foreach (char c in input) {
                if (c == '(') {
                    depth++;
                    continue;
                }
                if (c == ')') {
                    if(depth == 0) {
                        return false;
                    }
                    depth--;
                } 
            }

            return depth == 0;
        }
    }
}
