using Microsoft.AspNetCore.Mvc;
using SamplesServer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SamplesServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Book>))]
        public async Task<IActionResult> Get()
        {
            await Task.CompletedTask;

            return Ok();
        }
    }
}
