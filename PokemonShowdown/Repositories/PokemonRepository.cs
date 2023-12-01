using Microsoft.EntityFrameworkCore;
//using PokemonShowdown.Filters;
using PokemonShowdown.Models;
using PokemonShowdown.PokemonSHDbContext;

namespace PokemonShowdown.Repositories
{
    public class PokemonRepository : IPokemonRepository
    {

        private readonly PokemonSHContext _context;
        public PokemonRepository(PokemonSHContext context)
{
           _context = context;
        }

        public void CreatePokemon(Pokemon Pokemon)
        {
          _context.Pokemon.Add(Pokemon);

        }

        public void DeletePokemon(int PokemonId)
        {
            _context.Pokemon.Remove(GetPokemonByID(PokemonId));

            _context.SaveChanges();
        }

        public Pokemon GetPokemonByID(int PokemonId)
        {
            return _context.Pokemon.Find(PokemonId);
        }
        public void UpdatePokemon(Pokemon Pokemon, int PokemonId)
        {
            Pokemon pokemonEntity = GetPokemonByID(PokemonId);
            pokemonEntity.Nom = Pokemon.Nom;
           pokemonEntity.Forme = Pokemon.Forme;
          pokemonEntity.Cri = Pokemon.Cri;
            pokemonEntity.Evolution = Pokemon.Evolution;
           pokemonEntity.Type = Pokemon.Type;
           _context.Pokemon.Update(pokemonEntity);
           _context.SaveChanges();
        }

   }
}



