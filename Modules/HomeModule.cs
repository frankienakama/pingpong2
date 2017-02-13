using Nancy;
using System.Collections.Generic;
using System;
using PingPongApp;

namespace PingPongGenerator
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/results"] = _ => {
        int userInput = Request.Form["inputNumber"];
        PingPong testPingPong = new PingPong();
        List<string> output = testPingPong.CountList(userInput);
        return View["results.cshtml", output];
      };
    }
  }
}
