using PokeApi_Console;
using RestSharp;
using System.Text.Json;

// request
try
{
    var options = new RestClientOptions("https://pokeapi.co") { MaxTimeout = -1, };
    var client = new RestClient(options);

    // get
    Console.WriteLine("Insira o nome de um pokemon ou id:");
    string inputPokemon = Console.ReadLine().ToLower();

    var request = new RestRequest($"/api/v2/pokemon/{inputPokemon}", Method.Get);
    RestResponse response = await client.ExecuteAsync(request);

    // Json
    var pokemon = JsonSerializer.Deserialize<Pokemon>(response.Content);

    Console.WriteLine($"Id: {pokemon.Id}");
    Console.WriteLine($"Nome: {pokemon.Nome}");

    foreach (var abilityDetail in pokemon.Habilidades )
        Console.WriteLine(abilityDetail.Ability.Name);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
