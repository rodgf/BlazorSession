using BlazorApp.Helpers;
using BlazorApp.Data;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddSession(options => {
  options.IdleTimeout = TimeSpan.FromMinutes(int.Parse(builder.Configuration["Session:Timeout"]));
});
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped<SessionStorageAccessor>();

GlobalObjects.ServiceProvider = builder.Services.BuildServiceProvider();

WebApplication? app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
  app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
  );

app.UseSession();

app.Run();
