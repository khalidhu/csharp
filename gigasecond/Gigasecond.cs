using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment) => moment.AddSeconds((double)1000000000);
   
}