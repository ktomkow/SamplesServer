using Microsoft.AspNetCore.Mvc;
using SamplesServer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SamplesServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Article>))]
        public async Task<IActionResult> Get()
        {
            await Task.CompletedTask;

            return Ok();
        }
    }
}
