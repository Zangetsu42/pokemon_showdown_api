using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PokemonShowdown.Models;

namespace PokemonShowdown.PokemonSHDbContext
{
    public class PokemonSHContext : IdentityDbContext<User,Role, int>
    {
        public PokemonSHContext(DbContextOptions<PokemonSHContext> options) : base (options) 
        { 

        }
        public DbSet<Pokemon> Pokemon { get; set; }
        public DbSet<AttaquePokemon> AttaquePokemon { get; set; }
        public DbSet<Attaque> Attaque { get; set; }
    }

}
