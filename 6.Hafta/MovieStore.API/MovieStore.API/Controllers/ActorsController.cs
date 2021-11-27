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
    public class ActorsController : ControllerBase
    {
        private readonly IAppRepository _appRepository;
        private readonly IMapper _mapper;


        public ActorsController(IAppRepository appRepository, IMapper mapper)
        {
            _appRepository = appRepository;
            _mapper = mapper;
        }

        [HttpPost("Add")]
        public IActionResult Add(ActorDto actorDto)
        {
            var actor = _mapper.Map<Actor>(actorDto);
            _appRepository.Add(actor);
            _appRepository.SaveAll();
            return Ok(actor);
        }

        [HttpPut("Update")]
        public IActionResult Update(UpdateActorDto updateActorDto)
        {
            var actor = _mapper.Map<Actor>(updateActorDto);
            _appRepository.Update(actor);
            _appRepository.SaveAll();
            return Ok(actor);
        }

        [HttpDelete("Delete")]
        public IActionResult Delete(int actorId)
        {
            var actor = _appRepository.GetActorById(actorId);
            _appRepository.Delete(actor);
            _appRepository.SaveAll();
            return Ok(actor);
        }

        [HttpGet("GetActorById")]
        public IActionResult GetActorById(int actorId)
        {
            var actor = _appRepository.GetActorById(actorId);
            return Ok(actor);
        }

        [HttpGet("GetActors")]
        public IActionResult GetActors()
        {
            var actors = _appRepository.GetActors();
            return Ok(actors);
        }
    }
}
