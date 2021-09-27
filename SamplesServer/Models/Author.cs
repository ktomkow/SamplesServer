namespace SamplesServer.Models
{
    public class Author
    {
        public int Id { get; set; }

        public string RealName { get; set; }

        public string Nickname { get; set; }

        public Contact Contact { get; set; }

        public bool HasNickname => !string.IsNullOrEmpty(Nickname);
    }
}
