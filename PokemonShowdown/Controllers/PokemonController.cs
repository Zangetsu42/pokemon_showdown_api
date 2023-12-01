using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PokemonShowdown.Models;
using PokemonShowdown.Repositories;

namespace PokemonShowdown.Controllers
{
    [Route("Pokemon")]
    [ApiController]
    public class PokemonController : Controller
    {
        private readonly IPokemonRepository _PokemonRepository;

        public PokemonController(IPokemonRepository PokemonRepository)
        {
            _PokemonRepository = PokemonRepository;
        }
        [HttpPost]
        public IActionResult CreatePokemon(Pokemon Pokemon)
        {
            _PokemonRepository.CreatePokemon(Pokemon);
            return Ok();
        }
        [Authorize]
        [HttpGet("{PokemonId}")]
        public ActionResult<Pokemon> GetPokemonById(int PokemonId)
        {
            return Ok(_PokemonRepository.GetPokemonByID(PokemonId));
        }
        [HttpPut("{PokemonId}")]
        public IActionResult UpdatePokemon(int PokemonId, Pokemon Pokemon)
        {
            _PokemonRepository.UpdatePokemon(Pokemon, PokemonId);
            return NoContent();
        }
        [HttpDelete("{PokemonId}")]
        public IActionResult DeletePokemon(int PokemonId)
        {
            _PokemonRepository.DeletePokemon(PokemonId);
            return NoContent();
        }
    }
}
