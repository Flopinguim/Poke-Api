using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeApi_Console
{
    public class Pokemon
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Nome { get; set; }

        public List<Ability> Habilidades { get; set; }
        
        public Pokemon()
        {
            Id = 0;
            Nome = string.Empty;
            Habilidades = new List<Ability>();
        }

    }
}
