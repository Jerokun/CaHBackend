using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CahBackend.Repositories
{
    public class GameStateDbContext : DbContext
    {
        public GameStateDbContext(DbContextOptions<GameStateDbContext> options) : base(options)
        {

        }

        public DbSet<GameStateDbContext> GameStates { get; set; }
    }
}
