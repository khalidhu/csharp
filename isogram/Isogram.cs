using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Isogram
{

    public static bool IsIsogram(string word) => RemovedUnwantedChars(word.ToLower()).Length == GetDistinctValues(word.ToLower()).Length;
    public static string GetDistinctValues(string word) => RemovedUnwantedChars(string.Join("", word.Distinct()));
    public static string RemovedUnwantedChars(string word) => Regex.Replace(word, "[^a-z]", "");
}
 