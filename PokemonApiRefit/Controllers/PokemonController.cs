using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokemonApiRefit.Services;
using Refit;

namespace PokemonApiRefit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetPokemon(string name)
        {
            try
            {
                var apiClient = RestService.For<IPokemonAPI>(CaminhoBaseAPI.BaseUrl);
                var pokemon = await apiClient.GetPokemonAsync(name);
                pokemon.Image = $"https://pokeres.bastionbot.org/images/pokemon/{pokemon.Id}.png";

                if (pokemon == null)
                {
                    return NotFound();
                }

                return Ok(pokemon);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
