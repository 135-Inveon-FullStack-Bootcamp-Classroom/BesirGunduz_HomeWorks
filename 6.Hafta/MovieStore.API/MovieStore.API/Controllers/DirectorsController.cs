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
    public class DirectorsController : ControllerBase
    {
        private readonly IAppRepository _appRepository;
        private readonly IMapper _mapper;

        public DirectorsController(IAppRepository appRepository, IMapper mapper)
        {
            _appRepository = appRepository;
            _mapper = mapper;
        }

        [HttpPost("Add")]
        public IActionResult Add(DirectorDto directorDto)
        {
            var director = _mapper.Map<Director>(directorDto);
            _appRepository.Add(director);
            _appRepository.SaveAll();
            return Ok(director);
        }

        [HttpPut("Update")]
        public IActionResult Update(UpdateDirectorDto updateDirectorDto)
        {
            var director = _mapper.Map<Director>(updateDirectorDto);
            _appRepository.Update(director);
            _appRepository.SaveAll();
            return Ok(director);
        }

        [HttpDelete("Delete")]
        public IActionResult Delete(int directorId)
        {
            var director = _appRepository.GetDirectorById(directorId);
            _appRepository.Delete(director);
            _appRepository.SaveAll();
            return Ok(director);
        }

        [HttpGet("GetDirectorById")]
        public IActionResult GetDirectorById(int directorId)
        {
            var director = _appRepository.GetDirectorById(directorId);
            return Ok(director);
        }

        [HttpGet("GetDirectors")]
        public IActionResult GetDirectors()
        {
            var directors = _appRepository.GetDirectors();
            return Ok(directors);
        }
    }
}
