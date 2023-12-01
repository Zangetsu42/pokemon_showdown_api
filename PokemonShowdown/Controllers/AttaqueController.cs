using Microsoft.AspNetCore.Mvc;
using PokemonShowdown.Models;
using PokemonShowdown.Repositories;

namespace PokemonShowdown.Controllers
{
    [Route("Attaque")]
    [ApiController]
    public class AttaqueController : Controller
    {
        private readonly IAttaqueRepository _AttaqueRepository;

        public AttaqueController(IAttaqueRepository AttaqueRepository)
        {
            _AttaqueRepository = AttaqueRepository;
        }
        [HttpPost]
        public IActionResult CreateAttaque(Attaque Attaque)
        {
            _AttaqueRepository.CreateAttaque(Attaque);
            return Ok();
        }
        [HttpGet("{AttaqueId}")]
        public ActionResult<Attaque> GetAttaqueById(int AttaqueId)
        {
            return Ok(_AttaqueRepository.GetAttaqueByID(AttaqueId));
        }
        [HttpPut("{AttaqueId}")]
        public IActionResult UpdateAttaque(int AttaqueId, Attaque Attaque)
        {
            _AttaqueRepository.UpdateAttaque(Attaque, AttaqueId);
            return NoContent();
        }
        [HttpDelete ("{AttaqueId}")]
        public IActionResult DeleteSubject(int AttaqueId)
        {
            _AttaqueRepository.DeleteAttaque(AttaqueId);   
            return NoContent();
        }
    }
}
