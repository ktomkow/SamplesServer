using Bogus;

namespace SamplesServer.Models
{
    public class Article
    {
        private static int id = 0;
        private static Faker<Article> articleFaker = new Faker<Article>()
                .StrictMode(true)
                .RuleFor(x => x.Id, f => id++)
                .RuleFor(x => x.Title, f => f.Commerce.Product())
                .RuleFor(x => x.Author, f => f.Person.FullName)
                .RuleFor(x => x.Link, f => "https://articles.com/article/" + f.Random.Number(1, 1000000).ToString())
                .RuleFor(x => x.DomainMonthlySubscribtion, f => f.Finance.Amount(0, 100));

        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Link { get; set; }

        public decimal DomainMonthlySubscribtion { get; set; }

        public static Article GetRandom()
        {
            return articleFaker.Generate();
        }
    }
}
