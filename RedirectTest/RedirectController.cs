using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace RedirectTest;

[ApiController]
[Route("[controller]")]
//[EnableCors]
public class RedirectController : ControllerBase
{
    [HttpGet]
    public IActionResult RedirectToGoogle()
    {
        return Redirect("https://www.google.com");
    }
}