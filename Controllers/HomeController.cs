using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SurveyApp.Models;

namespace SurveyApp.Controllers;

public class HomeController : Controller
{
  public IActionResult Index()
  {
    return View();
  }

  [HttpGet]
  public IActionResult Reply()
  {
    return View();
  }

  [HttpPost]
  public IActionResult Reply(SurveyResponse userResponse)
  {
    if (ModelState.IsValid)
    {
      Repository.AddResponse(userResponse);
      return View("Thanks");
    }
    return View(userResponse);
  }

  [HttpGet]
  public IActionResult SurveyResult()
  {
    return View(Repository.SurveyResponses);
  }

}
