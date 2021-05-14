using System;
using System.Collections.Generic;
using System.Linq;

public static class ArmstrongNumbers
{
   
    private static int ArmstrongNumberSum(int number)
    {
        string text = number.ToString();
        return (int)Enumerable.Range(0, text.Length).Select(i => Math.Pow(char.GetNumericValue(text[i]), text.Length)).Sum();
    }

    public static bool IsArmstrongNumber(int number) => ArmstrongNumberSum(number) == number;


}