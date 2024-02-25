using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeApi_Console
{
    public class Ability
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool HiddenAbility { get; set; }

        public Ability()
        {
            Nome = 
                Descricao = string.Empty;
            HiddenAbility = false;
        }

        public void fillByUrl(string url)
        {

        }
    }
}
