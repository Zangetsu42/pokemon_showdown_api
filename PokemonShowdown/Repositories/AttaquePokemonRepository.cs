using PokemonShowdown.Models;
using PokemonShowdown.PokemonSHDbContext;

namespace PokemonShowdown.Repositories
{
    public class AttaquePokemonRepository : IAttaquePokemonRepository
    {
            private readonly PokemonSHContext _context;
            public AttaquePokemonRepository(PokemonSHContext context)
            {
                _context = context;
            }

            public void CreateAttaquePokemon(AttaquePokemon AttaquePokemon) 
            {
                _context.AttaquePokemon.Add(AttaquePokemon);

                _context.SaveChanges();
            }

            public void DeleteAttaquePokemon(int AttaquePokemonId)
            {
                _context.AttaquePokemon.Remove(GetAttaquePokemonById(AttaquePokemonId));

                _context.SaveChanges();
            }

            public AttaquePokemon GetAttaquePokemonById(int AttaquePokemonId)
            {
                return _context.AttaquePokemon.Find(AttaquePokemonId);
            }

        public void UpdateAttaquePokemon(AttaquePokemon AttaquePokemon, int AttaquePokemonId)
            {
            AttaquePokemon attaquepokemonEntity = GetAttaquePokemonById(AttaquePokemonId);
                _context.AttaquePokemon.Update(attaquepokemonEntity);
                _context.SaveChanges();
            }
    }
}

