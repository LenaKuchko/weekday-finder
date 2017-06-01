using System;

namespace WeekdayFinderProject.Objects
{
  public class WeekdayFinder
  {
    public string GetDay(int year, int month, int day)
      {
        DateTime dt = new DateTime(year, month, day);
        string dayOfWeek = dt.ToString("dddd");
        Console.WriteLine(dayOfWeek);
        return dayOfWeek;
      }
  }
}
