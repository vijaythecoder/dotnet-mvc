using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnet_mvc.Models;

namespace dotnet_mvc.Controllers
{
  public class QuoteController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
    public IActionResult ShowText()
    {
      return Content("Here is text - hit back to return. ");
    }
    public IActionResult ShowJSON()
    {
      return  Json(new {name="favorite quote", quote="This is my favorite quote."});
    }
    public IActionResult ShowHTML()
    {
      var h = "<!DOCTYPE html><html><body>An awesome quote. Note return path has to use the name of the controller." + 
      "<br><br> <a href='/Quote'>Go Back to Quotes</a></body></html>";
      return Content(h, "text/html");
    }

    public IActionResult ShowView()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
