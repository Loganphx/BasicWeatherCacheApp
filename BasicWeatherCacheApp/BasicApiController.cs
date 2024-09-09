using Microsoft.AspNetCore.Mvc;

namespace BasicWeatherCacheApp;

// [ServiceFilter(typeof(LogUserActivity))]
[ApiController]
[Route("api/[controller]")]
public class BaseApiController : ControllerBase
{
    
}