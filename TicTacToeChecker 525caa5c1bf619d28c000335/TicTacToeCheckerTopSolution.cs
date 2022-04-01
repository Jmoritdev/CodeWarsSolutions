namespace CodeWarsSolutions.TicTacToeChecker_525caa5c1bf619d28c000335 {
    //https://www.codewars.com/kata/reviews/56a1b62ceb07a6fb3900001e/groups/56c346cac44a3a2cea00141f
    //yeah its fancy, colleagues might want to kill me while trying to read it though
    public class TicTacToe {
        public int IsSolved(int[,] board) {
            int d1 = 1, d2 = 1;
            bool empty = false;
            for (int i = 0; i < 3; i++) {
                d1 *= board[i, i];
                d2 *= board[2 - i, i];
                int row = 1, col = 1;
                for (int j = 0; j < 3; j++) {
                    row *= board[i, j];
                    col *= board[j, i];
                }
                if (row == 1 || col == 1) return 1;
                if (row == 8 || col == 8) return 2;
                if (row == 0 || col == 0) empty = true;
            }
            if (d1 == 1 || d2 == 1) return 1;
            if (d1 == 8 || d2 == 8) return 2;
            if (empty) return -1;
            return 0;
        }
    }
}
