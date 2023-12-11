using System.Reflection;
using System.Text.Json.Serialization;

namespace Phoenix.Models.Models
{
    public class Temperature
    {
        [JsonPropertyName("CountryId")]
        public string CountryId { get; set; }

  
        [JsonPropertyName("Temperature")]
        public int Temp { get; set; }

    }
}


