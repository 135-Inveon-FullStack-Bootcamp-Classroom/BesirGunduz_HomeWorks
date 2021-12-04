using FootballManager.API.Entities;
using FootballManager.API.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootballManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagementPositionsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ManagementPositionsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("GetManagementPositions")]
        public async Task<ActionResult<IEnumerable<Team>>> GetManagementPositions()
        {
            var managementPositions = await _unitOfWork.ManagementPositionService.GetAllAsync();
            return Ok(managementPositions);
        }

        [HttpGet("GetManagementPosition/{id}")]
        public async Task<ActionResult<Team>> GetManagementPosition(int id)
        {
            var managementPosition = await _unitOfWork.ManagementPositionService.GetAsync(id);
            return Ok(managementPosition);
        }

        [HttpPut("UpdateManagementPosition")]
        public IActionResult UpdateManagementPosition(ManagementPosition managementPosition)
        {
            _unitOfWork.ManagementPositionService.Update(managementPosition);
            return Ok(managementPosition);
        }
        [HttpPost("AddManagementPosition")]
        public IActionResult AddManagementPosition(ManagementPosition managementPosition)
        {
            _unitOfWork.ManagementPositionService.Add(managementPosition);
            return Ok(managementPosition);
        }

        [HttpDelete("DeleteManagementPosition")]
        public IActionResult DeleteManagementPosition(ManagementPosition managementPosition)
        {
            _unitOfWork.ManagementPositionService.Delete(managementPosition);
            return Ok();
        }
    }
}
