using CahBackend.Lobby;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CahBackend.Repositories
{
    public class LobbyDbContext : DbContext
    {
        public LobbyDbContext(DbContextOptions<LobbyDbContext> options) : base(options)
        {

        }

        public DbSet<LobbyDbContext> ChatMessages { get; set; }
    }
}
