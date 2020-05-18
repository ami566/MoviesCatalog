using Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MovieStudioContext: DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Studio> Studios{ get; set; }

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

