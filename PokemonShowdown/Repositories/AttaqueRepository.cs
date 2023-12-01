using Microsoft.EntityFrameworkCore;
//using PokemonShowdown.Filters;
using PokemonShowdown.Models;
using PokemonShowdown.PokemonSHDbContext;

namespace PokemonShowdown.Repositories
{
    public class AttaqueRepository : IAttaqueRepository
    {

        private readonly PokemonSHContext _context;
        public AttaqueRepository(PokemonSHContext context)
        {
            _context = context;
        }

        public void CreateAttaque(Attaque Attaque)
        {
            _context.Attaque.Add(Attaque);

            _context.SaveChanges();
        }

        public void DeleteAttaque(int AttaqueId)
        {
            _context.Attaque.Remove(GetAttaqueByID(AttaqueId));

            _context.SaveChanges();
        }

        public Attaque GetAttaqueByID(int AttaqueId)
        {
            return _context.Attaque.Find(AttaqueId);
        }
        public void UpdateAttaque(Attaque Attaque, int AttaqueId)
        {
            Attaque attaqueEntity = GetAttaqueByID(AttaqueId);
            attaqueEntity.Nom_Attaque = Attaque.Nom_Attaque;
            attaqueEntity.TypeAtk = Attaque.TypeAtk;
            _context.Attaque.Update(attaqueEntity);
            _context.SaveChanges();
        }
    }
}



