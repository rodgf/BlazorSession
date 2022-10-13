using BlazorApp.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Controllers {

  //
  public class HomeController : Controller {

    public async Task<IActionResult> Index() {
      ViewData["Usuario"] = HttpContext.Session.GetString("Username");

      return View();
    }
  }
}
