using Microsoft.AspNetCore.Mvc;

namespace web.common;

[ApiController]
[Route(template: "api/[controller]")]
public class BaseApiController : ControllerBase
{
}

 