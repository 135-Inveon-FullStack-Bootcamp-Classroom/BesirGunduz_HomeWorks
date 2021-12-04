using FootballManager.API.Entities;
using FootballManager.API.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootballManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public TeamsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("GetTeams")]
        public async Task<ActionResult<IEnumerable<Team>>> GetTeams()
        {
            var teams = await _unitOfWork.TeamService.GetAllAsync();
            return Ok(teams);
        }

        [HttpGet("GetTeam/{id}")]
        public async Task<ActionResult<Team>> GetTeam(int id)
        {
            var team = await _unitOfWork.TeamService.GetAsync(id);
            return Ok(team);
        }

        [HttpPut("UpdateTeam")]
        public IActionResult UpdateTeam(Team team)
        {
            _unitOfWork.TeamService.Update(team);
            return Ok(team);
        }
        [HttpPost("AddTeam")]
        public IActionResult AddTeam(Team team)
        {
            _unitOfWork.TeamService.Add(team);
            return Ok(team);
        }

        [HttpDelete("DeleteTeam")]
        public IActionResult DeleteTeam(Team team)
        {
            _unitOfWork.TeamService.Delete(team);
            return Ok();
        }
    }
}
