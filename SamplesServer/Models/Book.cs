using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamplesServer.Models
{
    public class Book
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public Author Author { get; set; }

        public int SoldCount { get; set; }

        public List<Comment> Comments { get; set; }

        public Genre Genre { get; set; }

        public Book()
        {
            this.Comments = new();
        }
    }

    public enum Genre
    {
        Unknown,
        Fantasy,
        Drama,
        Thriller,
        Romance
    }
}
