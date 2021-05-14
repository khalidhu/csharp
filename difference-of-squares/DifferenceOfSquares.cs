using System;
using System.Linq;

public static class DifferenceOfSquares
{
    private static readonly Func<int, int> SumOfSquares = (x) => (int)Enumerable.Range(1, x - 1 + 1).Select(i => Math.Pow(i, 2)).Sum();
    private static readonly Func<int, int> SquareOfSum = (x) => Enumerable.Range(1, x - 1 + 1).Select(i => i).Sum();

    public static int CalculateSquareOfSum(int max) => (int)Math.Pow(SquareOfSum(max), 2);

    public static int CalculateSumOfSquares(int max) => SumOfSquares(max); 

    public static int CalculateDifferenceOfSquares(int max) => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);


}