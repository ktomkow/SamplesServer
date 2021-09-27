using System;

namespace SamplesServer.Models
{
    public class Temperature
    {
        public Guid Id { get; set; }

        public int StationId { get; set; }

        public DateTime Date { get; set; }

        public double Result { get; set; }

        public Temperature()
        {
            this.Id = Guid.NewGuid();
        }
    }
}
