using MovieStore.API.Dtos;
using MovieStore.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MovieStore.API.Data
{
    public interface IAppRepository
    {
        void Add<T>(T entity);
        void Update<T>(T entity);
        void Delete<T>(T entity);
        bool SaveAll();

        Director GetDirectorById(int directorId);
        List<Director> GetDirectors();

        Movie GetMovieById(int movieId);
        List<Movie> GetMovies();

        Actor GetActorById(int actorId);
        List<Actor> GetActors();

        Genre GetGenreById(int genreId);
        List<Genre> GetGenres();
    }
}
