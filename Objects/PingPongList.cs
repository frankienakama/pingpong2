using System;
using System.Collections.Generic;

namespace PingPongApp.Objects
{
  public class PingPong
  {
    private int _number;
    public List<string> _instances = new List<string>{};

    public PingPong(int number)
    {
     _number = number;
    }

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


    public List<string> CountList()
    {
      for(int index = 1; index <= _number; index++) {
        if (index % 15 == 0)
        {
          _instances.Add("ping pong");
        }
        else if (index % 5 == 0)
        {
          _instances.Add("pong");
        }
        else if (index % 3 == 0)
        {
          string number = index.ToString();
          _instances.Add("ping");
        }
        else
        {
          _instances.Add(index.ToString());
        }
    }
    return _instances;
  }

  }
}
