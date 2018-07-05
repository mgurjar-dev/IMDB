using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding;
using IMDB.Models;

namespace IMDB.DL
{
	public class MyDbContext: DbContext
    {
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public MyDbContext(DbContextOptions options):base(options)
        {
            base.Database.EnsureCreated();
        }
        public MyDbContext()
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Actor>(entity =>
            {
                entity.HasKey(e => e.ActorId);
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.HasKey(e => e.MovieId);
                entity.Property(e => e.Name).IsRequired();
            });
            modelBuilder.Entity<Movie>().HasOne(e => e.Producer).WithMany(e => e.Movies).HasForeignKey(e => e.ProducerId);
            modelBuilder.Entity<MovieActor>().HasKey(e => new { e.ActorId, e.MovieId });
            modelBuilder.Entity<MovieActor>().HasOne(e => e.Actor).WithMany(e => e.MovieActors).HasForeignKey(e => e.ActorId);
            modelBuilder.Entity<MovieActor>().HasOne(e => e.Movie).WithMany(e => e.MovieActors).HasForeignKey(e => e.MovieId);

        }
    }
}
