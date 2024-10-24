using Microsoft.AspNetCore.Mvc;
using Heroic.Verse.Domain.Catalog;

namespace Heroic.Verse.Api.Controllers
{
     [ApiController]
     [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
       [HttpGet]
       public IActionResult GetItems()
    {
            return Ok("hello world.");
        }
    }
}
