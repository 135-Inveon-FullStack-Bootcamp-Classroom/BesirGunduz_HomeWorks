using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStore.API.Data;
using MovieStore.API.Dtos;
using MovieStore.API.Entities;

namespace MovieStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IAppRepository _appRepository;
        private readonly IMapper _mapper;


        public GenresController(IAppRepository appRepository, IMapper mapper)
        {
            _appRepository = appRepository;
            _mapper = mapper;
        }

        [HttpPost("Add")]
        public IActionResult Add(GenreDto genreDto)
        {
            var genre = _mapper.Map<Genre>(genreDto);
            _appRepository.Add(genre);
            _appRepository.SaveAll();
            return Ok(genre);
        }

        [HttpPut("Update")]
        public IActionResult Update(UpdateGenreDto updateGenreDto)
        {
            var genre = _mapper.Map<Genre>(updateGenreDto);
            _appRepository.Update(genre);
            _appRepository.SaveAll();
            return Ok(genre);
        }

        [HttpDelete("Delete")]
        public IActionResult Delete(int genreId)
        {
            var genre = _appRepository.GetGenreById(genreId);
            _appRepository.Delete(genre);
            _appRepository.SaveAll();
            return Ok(genre);
        }

        [HttpGet("GetGenreById")]
        public IActionResult GetGenreById(int genreId)
        {
            var genre = _appRepository.GetGenreById(genreId);
            return Ok(genre);
        }

        [HttpGet("GetGenres")]
        public IActionResult GetGenres()
        {
            var genres = _appRepository.GetGenres();
            return Ok(genres);
        }
    }
}
