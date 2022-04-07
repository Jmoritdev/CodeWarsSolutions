using System;

namespace CodeWarsSolutions
{
    internal class Program
    {
        //this is mostly used for debugging
        static void Main(string[] args)
        {
            //TheObservedPinTopSolution.GetPINs("51298615871");
            //TheObservedPinMySolution.GetPINs("51298615871");
            //Console.WriteLine(TicTacToeCheckerMySolution.IsSolved(new[,] { { 1, 2, 1 }, { 1, 1, 2 }, { 2, 1, 2 } }));
            Console.WriteLine(ValidParenthesesMySolution.ValidParentheses("(())((()())())"));
        }
    }
}
