using Microsoft.AspNetCore.Mvc;

namespace SentryGunAPI.Modules.Conferences.Api.Controllers;
[Route("home")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> Get() => "Welcome home!";
}