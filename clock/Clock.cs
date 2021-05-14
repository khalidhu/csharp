using System;

public class Clock
{
    //private const int DayMinutes = 24 * 60;
    //private readonly int hours, minutes;
    //protected readonly int TotalMinutes;

    //public Clock(int h, int m = 0)
    //{
    //    TotalMinutes = h * 60 + m;
    //    if (TotalMinutes < 0)
    //    {
    //        TotalMinutes += DayMinutes;
    //    }
    //    TotalMinutes %= DayMinutes;
    //    hours = Math.DivRem(TotalMinutes, 60, out minutes);
    //}
    private int Hours { get; }
    private int Minutes { get; }

    private const int MinutesHour = 60;
    private const int HoursDay = 24;
    private readonly Func<int, int, int> GetValues = (int value, int time) => value < 0 ? value % time + time : value % time;
    public int GetHours(int hours, int minutes)
    {
        int hr = (int)Math.Floor((decimal)(hours * MinutesHour + minutes) / MinutesHour);
        return GetValues(hr, HoursDay) == HoursDay ? 0 : GetValues(hr, HoursDay); 
    }
    public int GetMinutes(int minutes) =>  GetValues(minutes, MinutesHour) == MinutesHour ? 0 : GetValues(minutes, MinutesHour);
       
    public Clock(int hours, int minutes)
    {
        Hours = GetHours(hours, minutes);
        Minutes = GetMinutes(minutes);
    }

    public override string ToString() => $"{Hours:00}:{Minutes:00}";

    public override bool Equals(object obj) => ToString().Equals(obj.ToString());
   

    public override int GetHashCode() => HashCode.Combine(Hours, Minutes);

    public Clock Add(int minutesToAdd) => new Clock(Hours, Minutes + minutesToAdd);

    public Clock Subtract(int minutesToSubtract) => new  Clock(Hours, Minutes - minutesToSubtract); 
    
}
