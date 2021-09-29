using Microsoft.AspNetCore.Mvc;
using SamplesServer.Models;
using System;
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
            var random = new Random();
            await Task.Delay(random.Next(1, 100));

            var result = Article.GetRandom();

            return Ok(result);
        }

        [HttpGet]
        [Route("{count}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Article>))]
        public async Task<IActionResult> Get(int count)
        {
            var random = new Random();
            await Task.Delay(random.Next(1, 100));

            var list = new List<Article>();
            for (int i = 0; i < count; i++)
            {
                list.Add(Article.GetRandom());
            }

            return Ok(list);
        }

        [HttpGet]
        [Route("specific")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Article>))]
        public async Task<IActionResult> GetSpecific()
        {
            var random = new Random();
            await Task.Delay(random.Next(1, 100));

            var result = new Article()
            {
                Id = 21,
                Author = "John Doe Junior",
                Title = "Loremus ipsumus wizardus",
                DomainMonthlySubscribtion = 19.99m,
                Link = "https://fake-address.com.org"
            };

            return Ok(result);
        }
    }
}
