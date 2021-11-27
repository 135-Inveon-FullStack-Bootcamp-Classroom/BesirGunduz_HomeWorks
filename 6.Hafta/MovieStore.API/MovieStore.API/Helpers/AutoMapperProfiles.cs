using AutoMapper;
using MovieStore.API.Dtos;
using MovieStore.API.Entities;

namespace MovieStore.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DirectorDto, Director>();
            CreateMap<UpdateDirectorDto, Director>();

            CreateMap<MovieDto, Movie>();
            CreateMap<UpdateMovieDto, Movie>();

            CreateMap<ActorDto, Actor>();
            CreateMap<UpdateActorDto, Actor>();

            CreateMap<GenreDto, Genre>();
            CreateMap<UpdateGenreDto, Genre>();

        }
    }
}
