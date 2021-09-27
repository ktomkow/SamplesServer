using System.Collections.Generic;

namespace SamplesServer.Models
{
    public class WeatherStation
    {
        public int Id { get; set; }

        public List<Temperature> Measures { get; set; }

        public WeatherStation()
        {
            this.Measures = new();
        }
    }
}
