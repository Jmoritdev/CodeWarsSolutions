using System;

namespace CodeWarsSolutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TheObservedPinTopSolution.GetPINs("51298615871");
            TheObservedPinMySolution.GetPINs("51298615871");
            Console.WriteLine(TicTacToeCheckerMySolution.IsSolved(new[,] { { 1, 2, 1 }, { 1, 1, 2 }, { 2, 1, 2 } }));
        }
    }
}
