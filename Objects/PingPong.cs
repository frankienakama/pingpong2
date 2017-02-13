using System;
using System.Collections.Generic;

namespace PingPongApp
{
  public class PingPongApp
  {
    private int _number;
    private static List<int> _pingPongList = new List<int>{};

    public int GetNumber()
    {
      return _number;
    }
    public void SetNumber(int inputNumber)
    {
      _number = inputNumber;
    }

    public static List<int> GetList()
    {
      return _pingPongList;
    }
  }
}
