using FootballManager.API.Entities;
using FootballManager.API.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootballManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TacticsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public TacticsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("GetTactics")]
        public async Task<ActionResult<IEnumerable<Tactic>>> GetTactics()
        {
            var tactics = await _unitOfWork.TacticService.GetAllAsync();
            return Ok(tactics);
        }

        [HttpGet("GetTactic/{id}")]
        public async Task<ActionResult<Team>> GetManagementPosition(int id)
        {
            var tactic = await _unitOfWork.TacticService.GetAsync(id);
            return Ok(tactic);
        }

        [HttpPut("UpdateTactic")]
        public IActionResult UpdateTactic(Tactic tactic)
        {
            _unitOfWork.TacticService.Update(tactic);
            return Ok(tactic);
        }
        [HttpPost("AddTactic")]
        public IActionResult AddManagementPosition(Tactic tactic)
        {
            _unitOfWork.TacticService.Add(tactic);
            return Ok(tactic);
        }

        [HttpDelete("DeleteTactic")]
        public IActionResult DeleteTactic(Tactic tactic)
        {
            _unitOfWork.TacticService.Delete(tactic);
            return Ok();
        }
    }
}
