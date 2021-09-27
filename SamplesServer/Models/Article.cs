using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamplesServer.Models
{
    public class Article
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Link { get; set; }

        public decimal DomainMonthlySubscribtion { get; set; }
    }
}
