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
    }
}
