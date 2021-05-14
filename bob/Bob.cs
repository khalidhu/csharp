using System;
using System.Linq;
public static class Bob
{
    private static readonly Func<string, string>[] statmentCases = new Func<string, string>[]
    {
      s => string.IsNullOrWhiteSpace(s)? "Fine. Be that way!" : null,
      s => IsShouting(s) ? s.EndsWith("?") ? "Calm down, I know what I'm doing!" : "Whoa, chill out!":null,
      s => s.EndsWith('?') ?  "Sure." : "Whatever."

    };

    private static bool IsShouting(string message) => message.Any(char.IsLetter) && message.ToUpperInvariant() == message;
    private static Func<string, string> @switch = statmentCases.Aggregate((x, y) => z => x(z) ?? y(z));
    public static string Response(string statement) => @switch(statement.Trim());
  
       
}

  
