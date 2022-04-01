using System;
using System.Linq;

namespace CodeWarsSolutions {
    //https://www.codewars.com/kata/reviews/56a1b62ceb07a6fb3900001e/groups/62475f0d63279a0001928016
    public class TicTacToeCheckerMySolution {
        public static int IsSolved(int[,] board) {

            //horizontals
            for(int x = 0; x < 3; x++) {
                if(CheckWinner(new int[] { board[x, 0], board[x, 1], board[x, 2] }) is int winner && winner > 0) {
                    return winner;
                }
            }

            //verticals
            for (int y = 0; y < 3; y++) {
                if (CheckWinner(new int[] {board[0,y], board[1,y], board[2,y] }) is int winner && winner > 0) {
                    return winner;
                }
            }

            //diagonal 1
            if(CheckWinner(new int[] {board[0,0], board[1,1], board[2,2]}) is int dWinner1 && dWinner1 > 0) {
                return dWinner1;
            }

            //diagonal 2
            if (CheckWinner(new int[] { board[0, 2], board[1, 1], board[2, 0] }) is int dWinner2 && dWinner2 > 0) {
                return dWinner2;
            }

            for (int x = 0; x < 3; x++) {
                if (new[] { board[x, 0], board[x, 1], board[x, 2] }.Contains(0)) {
                    return -1; //there is still a zero so the game is not done yet
                }
            }

            return 0;
        }

        public static int CheckWinner(int[] row) {
            if(row.Sum() == 3 && !row.Contains(0)) {
                return 1;
            }
            if(row.Sum() == 6 && !row.Contains(0)) {
                return 2;
            }
            return 0;
        }
    }
}
