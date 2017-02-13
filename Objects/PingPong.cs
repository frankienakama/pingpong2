using System;
using System.Collections.Generic;

namespace PingPongApp
{
  public class PingPong
  {
    public bool Rules(int input)
    {
      if (input % 15 == 0)
      {
        return true;
      }
      else if (input % 3 != 0 && input % 5 != 0 && input % 15 != 0)
      {
        return false;
      }
      if (input % 5 == 0)
      {
        return true;
      }
      else
      {
        return input % 3 == 0;
      }
    }

    public List<string> count = new List<string>{};
    public List<string> CountList(int countTo)
    {
      for(int index = 1; index <= countTo; index++) {
        if (index % 15 == 0)
        {
          string number = index.ToString();
          count.Add(number);
          count[index - 1] = "ping pong";
        }
        else if (index % 5 == 0)
        {
          string number = index.ToString();
          count.Add(number);
          count[index - 1] = "pong";
        }
        else if (index % 3 == 0)
        {
          string number = index.ToString();
          count.Add(number);
          count[index - 1] = "ping";
        }
        else
        {
          count.Add(index.ToString());
        }
    }
    return count;
  }
    // private int _number;
    // private static List<int> _pingPongList = new List<int>{};
    //
    // public PingPong(int number)
    // {
    //   _number = number;
    // }
    //
    // public int GetNumber()
    // {
    //   return _number;
    // }
    // public void SetNumber(int inputNumber)
    // {
    //   _number = inputNumber;
    // }
    //
    // public static List<int> GetList()
    // {
    //   return _pingPongList;
    // }
  }
}
