using Nancy;
using System.Collections.Generic;
using System;
using PingPongApp.Objects;

namespace PingPongApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/results"] = _ => {
        int userInput = int.Parse(Request.Form["inputNumber"]);
        PingPong testPingPong = new PingPong(userInput);
        List<string> output = testPingPong.CountList();
        return View["results.cshtml", output];
      };
    }
  }
}
