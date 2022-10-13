using Microsoft.Extensions.DependencyInjection;

namespace BlazorApp.Helpers {

  //
  public static class GlobalObjects {
    public static IServiceProvider ServiceProvider { get; set; }
    public static string ProjectRootPath { get; set; }
    public static string WebScheme { get; set; }
    public static string WebHost { get; set; }
    public static string WebPath { get; set; }
    public static string AppURL { get; set; }
  }
}
