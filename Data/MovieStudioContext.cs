using Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    // creates and connects the app with the database
    public class MovieStudioContext: DbContext
    {
        // defines the tables for the database
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Studio> Studios{ get; set; }

        // creates local database for the app
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // configures one-to-many relationship
            modelBuilder.Entity<Movie>()
                .HasRequired<Studio>(s => s.StudioM)
                .WithMany(g => g.Movies)
                .HasForeignKey<int>(s => s.StudioMId);
        }
    }
}

