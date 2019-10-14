using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharacterCreator.Models;
using Microsoft.EntityFrameworkCore;



namespace CharacterCreator.Models
{
    public class CharacterContext : DbContext
    {
        public CharacterContext(DbContextOptions<CharacterContext> options) : base(options)
        {
        }


        public DbSet<Characters> Features { get; set; }
        public DbSet<Race> Race { get; set; }
        public DbSet<Class> Class { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Characters>().ToTable("Features");
            modelBuilder.Entity<Race>().ToTable("Race");
            modelBuilder.Entity<Class>().ToTable("Class");
        }
    }
}
