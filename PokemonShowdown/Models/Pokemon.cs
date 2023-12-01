

using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonShowdown.Models
{
    public class Pokemon
    {
        public int PokemonId { get; set; }
        public string Nom { get; set; }
        public string Forme { get; set; }
        public string Cri { get; set; }
        public int Evolution { get; set; }
        public int Type { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public ICollection<AttaquePokemon> AttaquePokemons { get; set; }
    }
}
