using PokemonShowdown.Models;

namespace PokemonShowdown.Repositories
{
    public interface IAttaquePokemonRepository
    {
        void CreateAttaquePokemon(AttaquePokemon AttaquePokemon);
        void UpdateAttaquePokemon(AttaquePokemon AttaquePokemon, int AttaquePokemonId);
        void DeleteAttaquePokemon(int AttaquePokemonId);
        AttaquePokemon GetAttaquePokemonById(int AttaquePokemonId);

    }
}
