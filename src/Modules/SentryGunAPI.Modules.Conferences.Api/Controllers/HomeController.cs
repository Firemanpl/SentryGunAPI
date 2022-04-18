using Microsoft.AspNetCore.Mvc;
namespace SentryGunAPI.Modules.Conferences.Api.Controllers;

[Route("home")]
internal class HomeController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> Get() => "Welcome home!";
}