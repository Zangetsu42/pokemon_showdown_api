using Microsoft.AspNetCore.Mvc;
using PokemonShowdown.Models;
using PokemonShowdown.Repositories;

namespace PokemonShowdown.Controllers
{
    [ApiController]
    [Route("AttaquePokemon")]
    public class AttaquePokemonController : Controller
    {
        private readonly IAttaquePokemonRepository _AttaquePokemonRepository;
        public AttaquePokemonController(IAttaquePokemonRepository AttaquePokemonRepository)
        {
            _AttaquePokemonRepository = AttaquePokemonRepository;
        }

        [HttpGet("{AttaquePokemonId}")]
        public ActionResult<AttaquePokemon> GetAttaquePokemonById(int AttaquePokemonId) 
        {
            return Ok(_AttaquePokemonRepository.GetAttaquePokemonById(AttaquePokemonId));
        }
        [HttpPut("{AttaquePokemonId}")]
        public IActionResult UpdateAttaquePokemon(int AttaquePokemonId, AttaquePokemon AttaquePokemon)
        {
            _AttaquePokemonRepository.UpdateAttaquePokemon(AttaquePokemon, AttaquePokemonId);
            return NoContent();
        }
        [HttpDelete("{AttaquePokemonId}")]
        public IActionResult DeleteAttaquePokemon(int AttaquePokemonId)
        {
            _AttaquePokemonRepository.DeleteAttaquePokemon(AttaquePokemonId);
            return NoContent();
        }
        [HttpPost]
        public IActionResult CreateAttaquePokemon(AttaquePokemon AttaquePokemon)
        {
            _AttaquePokemonRepository.CreateAttaquePokemon(AttaquePokemon);
            return Ok();
        }
    }
}
