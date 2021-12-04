using FootballManager.API.Entities;
using FootballManager.API.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootballManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalTeamsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public NationalTeamsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("GetNationalTeams")]
        public async Task<ActionResult<IEnumerable<NationalTeam>>> GetNationalTeams()
        {
            var nationalTeams = await _unitOfWork.NationalTeamService.GetAllAsync();
            return Ok(nationalTeams);
        }

        [HttpGet("GetNationalTeam/{id}")]
        public async Task<ActionResult<NationalTeam>> GetNationalTeam(int id)
        {
            var nationalTeam = await _unitOfWork.NationalTeamService.GetAsync(id);
            return Ok(nationalTeam);
        }

        [HttpPut("UpdateNationalTeam")]
        public IActionResult UpdateNationalTeam(NationalTeam nationalTeam)
        {
            _unitOfWork.NationalTeamService.Update(nationalTeam);
            return Ok(nationalTeam);
        }
        [HttpPost("AddNationalTeam")]
        public IActionResult AddNationalTeam(NationalTeam nationalTeam)
        {
            _unitOfWork.NationalTeamService.Add(nationalTeam);
            return Ok(nationalTeam);
        }

        [HttpDelete("DeleteNationalTeam")]
        public IActionResult DeleteNationalTeam(NationalTeam nationalTeam)
        {
            _unitOfWork.NationalTeamService.Delete(nationalTeam);
            return Ok();
        }
    }
}
