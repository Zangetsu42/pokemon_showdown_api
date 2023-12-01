using PokemonShowdown.Models;
//using PokemonShowdown.Filters;

namespace PokemonShowdown.Repositories
{
    public interface IAttaqueRepository
    {
        void CreateAttaque(Attaque Attaque);

        Attaque GetAttaqueByID(int AttaqueId);
        void UpdateAttaque(Attaque Attaque, int AttaqueId);
        void DeleteAttaque(int AttaqueId);
    }
}
