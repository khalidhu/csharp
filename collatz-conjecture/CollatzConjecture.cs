using System;

public static class CollatzConjecture
{
    public static Func<int, int> Sequence = n => (n == 1) ? 0 : n % 2 == 0 ? Sequence(n / 2) + 1 : Sequence(3 * n + 1) + 1;
    public static int Steps(int number) => (number < 1) ? throw new ArgumentOutOfRangeException() : Sequence(number);

}
