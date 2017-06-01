using Xunit;
using System;
using System.Collections.Generic;
using WeekdayFinderProject.Objects;

namespace WeekdayFinderProject
{
  public class WeekdayFinderTest
  {
    [Fact]
    public void GetDayOfWeek_ReturnDay()
    {
      WeekdayFinder newFinder = new WeekdayFinder();
      Assert.Equal("Thursday", newFinder.GetDay(2017, 6, 1));
    }
  }
}
