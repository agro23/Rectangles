using System;
using Microsoft.AspNetCore.Mvc;
using RectangleChecker.Models;

namespace RectangleChecker.Controllers
{
  public class HomeController : Controller
  // public class RectangleController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    // [Route("/")]
    // public ActionResult Form()
    // {
    //     return View();
    // }

    // [Route("/greeting_card")]
    // public ActionResult GreetingCard()
    // {
    //     LetterVariable myLetterVariable = new LetterVariable();
    //     myLetterVariable.SetRecipient(Request.Query["recipient"]);
    //     myLetterVariable.SetSender(Request.Query["sender"]);
    //     return View("Letter", myLetterVariable);
    // }

  }



}
