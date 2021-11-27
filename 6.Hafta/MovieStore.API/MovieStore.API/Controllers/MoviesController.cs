using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStore.API.Data;
using MovieStore.API.Dtos;
using MovieStore.API.Entities;
using System.Collections.Generic;

namespace MovieStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IAppRepository _appRepository;
        private readonly IMapper _mapper;


        public MoviesController(IAppRepository appRepository, IMapper mapper)
        {
            _appRepository = appRepository;
            _mapper = mapper;
        }

        [HttpPost("Add")]
        public IActionResult Add(MovieDto movieDto)
        {
            var movie = _mapper.Map<Movie>(movieDto);
            _appRepository.Add(movie);
            _appRepository.SaveAll();
            return Ok(movie);
        }

        [HttpPut("Update")]
        public IActionResult Update(UpdateMovieDto updateMovieDto)
        {
            var movie = _mapper.Map<Director>(updateMovieDto);
            _appRepository.Update(movie);
            _appRepository.SaveAll();
            return Ok(movie);
        }

        [HttpDelete("Delete")]
        public IActionResult Delete(int movieId)
        {
            var movie = _appRepository.GetDirectorById(movieId);
            _appRepository.Delete(movie);
            _appRepository.SaveAll();
            return Ok(movie);
        }

        [HttpGet("GetMovieById")]
        public IActionResult GetMovieById(int movieId)
        {
            var movie = _appRepository.GetMovieById(movieId);
            return Ok(movie);
        }

        [HttpGet("GetMovies")]
        public IActionResult GetMovies()
        {
            var movies = _appRepository.GetMovies();
            return Ok(movies);
        }
    }
}
