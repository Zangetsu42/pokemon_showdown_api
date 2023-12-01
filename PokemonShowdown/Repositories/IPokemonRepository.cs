using PokemonShowdown.Models;
//using PokemonShowdown.Filters;

namespace PokemonShowdown.Repositories
{
   public interface IPokemonRepository
 {
   void CreatePokemon(Pokemon Pokemon);

        Pokemon GetPokemonByID(int PokemonId);
        void UpdatePokemon(Pokemon Pokemon, int PokemonId);
       void DeletePokemon(int PokemonId);
   }
}
