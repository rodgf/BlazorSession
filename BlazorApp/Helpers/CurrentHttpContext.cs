using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Helpers {

  //
  public class CurrentHttpContext {

    //
    public CurrentHttpContext([FromServices] IServiceProvider serviceProvider) {
      IHttpContextAccessor httpContextAccessor = serviceProvider.GetRequiredService<IHttpContextAccessor>();
      HttpRequest request = httpContextAccessor.HttpContext.Request;
      GlobalObjects.WebScheme = request.Scheme;
      GlobalObjects.WebHost = request.Host.Value;
      GlobalObjects.WebPath = request.PathBase;
      GlobalObjects.AppURL = $"{request.Scheme}://{request.Host}/{request.PathBase}";
    }
  }	
}
