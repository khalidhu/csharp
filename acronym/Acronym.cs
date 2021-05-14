using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase) => WordSplit(phrase.Split(new char[] { ' ', '_', '-' }, StringSplitOptions.RemoveEmptyEntries));
    public static string WordSplit(string phrase) => string.Join("",(phrase.Split(' ').Select(x => x[0]).ToArray())).ToUpper();

}

