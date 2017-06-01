public string GetDay()
    {
      System.DateTime dt = new DateTime(2017, 5, 31);
      string day = dt.ToString("dddd");
      Console.WriteLine(day);
      return day;
    }
