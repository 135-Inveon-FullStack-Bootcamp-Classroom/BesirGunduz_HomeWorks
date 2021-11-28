using Microsoft.EntityFrameworkCore;
using MovieStore.API.Dtos;
using MovieStore.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MovieStore.API.Data
{
    public class AppRepository : IAppRepository
    {
        private MovieStoreContext _context;

        public AppRepository(MovieStoreContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity)
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity)
        {
            _context.Update(entity);
        }
        public void Delete<T>(T entity)
        {
            _context.Remove(entity);
        }
        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }

        public Director GetDirectorById(int directorId)
        {
            var director = _context.Directors.Include(m => m.Movies).FirstOrDefault(d => d.Id == directorId);
            return director;
        }
        public List<Director> GetDirectors()
        {
            var directors = _context.Directors.Include(m => m.Movies).ToList();
            return directors;
        }
        public Movie GetMovieById(int movieId)
        {
            var movie = _context.Movies.Include(a => a.Actors).Include(g => g.Genres).FirstOrDefault(d => d.Id == movieId);
            return movie;
        }
        public List<Movie> GetMovies()
        {
            var movies = _context.Movies.ToList();
            return movies;
        }
        public Actor GetActorById(int actorId)
        {
            var actor = _context.Actors.Include(m => m.Movies).FirstOrDefault(d => d.Id == actorId);
            return actor;
        }
        public List<Actor> GetActors()
        {
            var actors = _context.Actors.ToList();
            return actors;
        }
        public Genre GetGenreById(int genreId)
        {
            var genre = _context.Genres.Include(m => m.Movies).FirstOrDefault(d => d.Id == genreId);
            return genre;
        }
        public List<Genre> GetGenres()
        {
            var genres = _context.Genres.ToList();
            return genres;
        }
    }
}
