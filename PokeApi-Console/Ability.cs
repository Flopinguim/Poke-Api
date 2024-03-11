using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeApi_Console
{
    public class Ability
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        public string Url { get; set; }

        public Ability()
        {
            Name = 
                Url = string.Empty;
        }
    }
}
