using System;

namespace SamplesServer.Models
{
    public class Comment
    {
        public string Author { get; set; }

        public string Text { get; set; }

        public DateTime At { get; set; }

        public double? Rate { get; set; }
    }
}
