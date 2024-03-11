using System.Text.Json.Serialization;

namespace PokeApi_Console
{
    public class AbilityDetail
    {
        [JsonPropertyName("ability")]
        public Ability Ability { get; set; }
        public bool IsHidden { get; set; }
        public int Slot { get; set; }

        public AbilityDetail()
        {
            Ability = new Ability();
            IsHidden = false;
            Slot = 0;
        }
    }
}
