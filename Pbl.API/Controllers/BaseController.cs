using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Pbl.API.Controllers
{
    [Authorize]
    [ApiController]
    public class BaseController : ControllerBase
    {
    }
}
