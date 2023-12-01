using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonShowdown.Models
{
    public class AttaquePokemon
    {
        public int AttaquePokemonId { get; set; }

        public int PokemonId { get; set; }
        [ForeignKey("PokemonId")]
        public Pokemon Pokemon { get; set; }
        public int AttaqueId { get; set; }
        [ForeignKey("AttaqueId")]
        public Attaque Attaque { get; set; }
    }
}

