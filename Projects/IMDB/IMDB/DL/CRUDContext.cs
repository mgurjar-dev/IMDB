using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IMDB.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace IMDB.DL
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CRUDContext:MyDbContext
    {
        public CRUDContext(DbContextOptions options) : base(options)
        {
            
        }

        //public List<IMViewModel> GetActors()
        //{
        //    var models = base.Set<Actor>().ToList().Select(r => new IMViewModel
        //    {
        //        Id = r.ActorId,
        //        Name = r.Name
        //    });
        //    return models.ToList();
        //}
        public bool SeedMovie()
        {
            if (!base.Set<Movie>().ToList().Any())
            {
                Movie movie1 = new Movie();
                movie1.Name = "Movie A";
                Actor actor1 = new Actor();
                actor1.Name = "Actor A";
                Actor actor2 = new Actor();
                actor2.Name = "Actor B";
                Actor actor3 = new Actor();
                actor3.Name = "Actor C";
                movie1.MovieActors = new List<MovieActor>();
                movie1.MovieActors.Add(new MovieActor { Actor = actor1, Movie = movie1 });
                movie1.MovieActors.Add(new MovieActor { Actor = actor2,  Movie = movie1 });
                Producer producer = new Producer();
                producer.Name = "Producer A";
                movie1.Producer = producer;
                base.Actors.Add(actor1);
                base.Actors.Add(actor2);
                base.Actors.Add(actor3);
                base.Producers.Add(producer);
                base.Movies.Add(movie1);


                Movie movie2 = new Movie();
                movie2.Name = "Movie B";
                movie2.MovieActors = new List<MovieActor>();
                movie2.MovieActors.Add(new MovieActor { Actor = actor1, Movie = movie2 });
                movie2.MovieActors.Add(new MovieActor { Actor = actor3, Movie = movie2 });
                movie2.Producer = producer;
                base.Movies.Add(movie2);
                base.SaveChanges();
            }
            return true;
        }


        public List<IMViewModel> GetMovies()
        {
            var models = base.Set<Movie>().Include(e=>e.MovieActors).ThenInclude(d=>d.Actor).Include(e=>e.Producer).ToList().Select(r => new IMViewModel
            {
                MovieId = r.MovieId,
                MovieName = r.Name,
                Actors = r.MovieActors.Select(s=>s.Actor).ToList(),
                Producer = r.Producer
            });
            return models.ToList();
        }
        public void UpdateMovie(IMViewModel data)
        {
            var movie = new Movie();
            movie.MovieId = data.MovieId;
            movie.MovieActors = new List<MovieActor>();
            data.Actors.ForEach(e => movie.MovieActors.Add(new MovieActor { Actor = e, ActorId = e.ActorId, Movie = movie, MovieId = data.MovieId }));
            movie.Name = data.MovieName;
            movie.Producer = new Producer();
            movie.Producer.Name = data.Producer.Name;
            movie.Producer.ProducerId = data.Producer.ProducerId;
            movie.ProducerId = data.ProducerId;
            base.Update(movie);
            base.SaveChangesAsync();

        }
        public void AddMovie(IMViewModel data)
        {
            var movie = new Movie();
            movie.MovieActors = new List<MovieActor>();
            data.Actors.ForEach(e => movie.MovieActors.Add(new MovieActor { Actor = e, Movie = movie, ActorId=0, MovieId=0 }));
            movie.Name = data.MovieName;
            var producer = new Producer();
            producer.Name = data.Producer.Name;
            producer.ProducerId = 0;
            movie.Producer = producer;
            movie.ProducerId = 0;
            data.Actors.ForEach(e => base.Actors.Add(e));
            base.Producers.Add(producer);
            base.Movies.Add(movie);
            base.SaveChanges();
        }
        public IMViewModel GetMovie(int id)
        {
            var model = base.Set<Movie>().Include(e => e.MovieActors).ThenInclude(d => d.Actor).Include(e => e.Producer).Where(e=>e.MovieId==id).Select(r => new IMViewModel
            {
                MovieId = r.MovieId,
                MovieName = r.Name,
                Actors = r.MovieActors.Select(s => s.Actor).ToList(),
                Producer = r.Producer,
                ProducerId=r.ProducerId,
                ActorsList= r.MovieActors.Select(s => new SelectListItem { Value = s.Actor.ActorId.ToString(),Text=s.Actor.Name}).ToList()
            }).FirstOrDefault();

            return model;
        }
    }
}
