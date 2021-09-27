﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace SamplesServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await Task.CompletedTask;

            return Ok();
        }
    }
}
