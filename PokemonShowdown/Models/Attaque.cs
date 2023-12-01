using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonShowdown.Models
{
    public class Attaque 
    {
        public int AttaqueId { get; set; }
        public string Nom_Attaque { get; set; }

        public int TypeAtk { get; set; }
        public ICollection<AttaquePokemon> AttaquePokemons { get; set; }
    }
}
