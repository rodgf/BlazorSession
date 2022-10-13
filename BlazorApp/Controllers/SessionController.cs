using BlazorApp.Helpers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BlazorApp.Controllers {

  //
  public class SessionController : Controller {

    [HttpPost]
    public async Task SetValue(string name, string value) {
      CurrentHttpContext hc = new CurrentHttpContext(GlobalObjects.ServiceProvider);
      HttpContext.Session.SetString(name, value);
    }

    [HttpPost]
    public async Task SetValues([FromForm]string sessionStorageObj) {
      Dictionary<string, string> localStorage = JsonConvert.DeserializeObject<Dictionary<string, string>>(sessionStorageObj);
      foreach (KeyValuePair<string, string> kvp in localStorage) {
        HttpContext.Session.SetString(kvp.Key, kvp.Value);
      }
    }
  }
}
