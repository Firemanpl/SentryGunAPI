using SentryGunAPI.Modules.Conferences.Api;
using SentryGunAPI.Shared.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure();
builder.Services.AddConferences();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseInfrastructure();

await app.RunAsync();