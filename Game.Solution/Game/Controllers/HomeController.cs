using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Game.Models;

namespace Game.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpPost("/play")]
    public ActionResult Play()
    {
      try
      {
        Throw player1 = RPS.Convert(Request.Form["player1-throw"]);
        Throw player2 = RPS.Convert(Request.Form["player2-throw"]);

        return View(RPS.Play(player1, player2));
      }
      catch(Exception)
      {
        return View("Play", "NOOOOOOOOO!!! STAAAHHHPPPP!!! YOU'RE NOT MY REAL DAD!!!");
      }
    }
  }
}
