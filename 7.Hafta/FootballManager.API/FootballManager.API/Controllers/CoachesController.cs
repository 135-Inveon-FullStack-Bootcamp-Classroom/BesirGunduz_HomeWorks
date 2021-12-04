using FootballManager.API.Entities;
using FootballManager.API.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootballManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoachesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CoachesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("GetCoaches")]
        public async Task<ActionResult<IEnumerable<Coach>>> GetCoaches()
        {
            var coaches = await _unitOfWork.CoachService.GetAllAsync();
            return Ok(coaches);
        }

        [HttpGet("GetCoach/{id}")]
        public async Task<ActionResult<Team>> GetCoach(int id)
        {
            var coach = await _unitOfWork.CoachService.GetAsync(id);
            return Ok(coach);
        }

        [HttpPut("UpdateCoach")]
        public IActionResult UpdateCoach(Coach coach)
        {
            _unitOfWork.CoachService.Update(coach);
            return Ok(coach);
        }
        [HttpPost("AddCoach")]
        public IActionResult AddCoach(Coach coach)
        {
            _unitOfWork.CoachService.Add(coach);
            return Ok(coach);
        }

        [HttpDelete("DeleteCoach")]
        public IActionResult DeleteCoach(Coach coach)
        {
            _unitOfWork.CoachService.Delete(coach);
            return Ok();
        }
    }
}
