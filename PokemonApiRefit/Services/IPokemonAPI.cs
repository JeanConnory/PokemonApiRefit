using PokemonApiRefit.Model;
using Refit;

namespace PokemonApiRefit.Services
{
    public interface IPokemonAPI
    {
        [Get("/pokemon/{name}")]
        Task<Pokemon> GetPokemonAsync(string name);
    }
}
