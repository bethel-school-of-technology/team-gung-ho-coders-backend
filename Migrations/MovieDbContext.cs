using team_gung_ho_coders_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace team_gung_ho_coders_backend.Migrations
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movie { get; set; }
        // public DbSet<User> Users { get; set; }

        public MovieDbContext(DbContextOptions<MovieDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.HasKey(e => e.MovieId);
                entity.Property(e => e.MovieTitle).IsRequired();
            });

            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    MovieTitle = "Die Hard",
                },
                new Movie
                {
                    MovieId = 2,
                    MovieTitle = "The Proposal",
                }
            );

            // modelBuilder.Entity<User>(entity =>
            // {
            //     entity.HasKey(e => e.UserId);
            //     entity.Property(e => e.Email).IsRequired();
            //     entity.HasIndex(x => x.Email).IsUnique();
            //     entity.Property(e => e.Password).IsRequired();
            // });
        }
    }
}
