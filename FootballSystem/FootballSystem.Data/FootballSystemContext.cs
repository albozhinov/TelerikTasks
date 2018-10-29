using FootballSystem.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FootballSystem.Data
{
    public class FootballSystemContext : DbContext
    {
        public FootballSystemContext(DbContextOptions<FootballSystemContext> options)
            : base(options)
        {

        }

        public DbSet<Player> Players { get; set; }

        public DbSet<Team> Teams { get; set; }        
    }
}
