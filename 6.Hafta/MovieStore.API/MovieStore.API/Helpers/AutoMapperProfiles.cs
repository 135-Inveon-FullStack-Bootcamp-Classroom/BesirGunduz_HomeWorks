using AutoMapper;
using MovieStore.API.Dtos;
using MovieStore.API.Entities;

namespace MovieStore.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DirectorDto, Director>().ReverseMap();
            CreateMap<UpdateDirectorDto, Director>().ReverseMap();

            CreateMap<MovieDto, Movie>().ReverseMap();
            CreateMap<UpdateMovieDto, Movie>().ReverseMap();

            CreateMap<ActorDto, Actor>().ReverseMap();
            CreateMap<UpdateActorDto, Actor>().ReverseMap();

            CreateMap<GenreDto, Genre>().ReverseMap();
            CreateMap<UpdateGenreDto, Genre>().ReverseMap();

        }
    }
}
