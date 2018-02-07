using System;
using Microsoft.AspNetCore.Mvc;
using RectangleChecker.Models;
using System.Collections.Generic;

namespace RectangleChecker.Controllers
{
  public class RectanglesController : Controller
  {
    [HttpGet("/rectangles")]
    public ActionResult Index()
    {
      return View("CreateForm");
    }
    [HttpPost("/rectangles/result")] // was Get
    public ActionResult Result()
    {
      Dictionary<string, object> Shapes = new Dictionary<string, object>();

      Rectangle myRectangle = new Rectangle(Int32.Parse(Request.Form["side-length"]), Int32.Parse(Request.Form["side-width"]));
      Shapes.Add("ResultingRectangle", myRectangle);
      if (myRectangle.IsSquare())
      {
        Cube myCube = new Cube(myRectangle);
        Shapes.Add("ResultingCube", myCube);
      }
      return View(Shapes);
    }
  }
}
