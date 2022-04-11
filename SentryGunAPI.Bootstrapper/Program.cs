using System.Runtime.Loader;
using SentryGunAPI.Modules.Conferences.Api;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// builder.Services.AddControllers();
// builder.Services.AddConferences();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/", async context => { await context.Response.WriteAsync("Dupa romana!");});
});

await app.RunAsync();