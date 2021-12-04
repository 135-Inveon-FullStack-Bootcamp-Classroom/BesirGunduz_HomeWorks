using FootballManager.API.Entities;
using FootballManager.API.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootballManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public PositionsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("GetPositions")]
        public async Task<ActionResult<IEnumerable<Position>>> GetPositions()
        {
            var positions = await _unitOfWork.PositionService.GetAllAsync();
            return Ok(positions);
        }

        [HttpGet("GetPosition/{id}")]
        public async Task<ActionResult<Position>> GetPosition(int id)
        {
            var position = await _unitOfWork.PositionService.GetAsync(id);
            return Ok(position);
        }

        [HttpPut("UpdatePosition")]
        public IActionResult UpdatePosition(Position position)
        {
            _unitOfWork.PositionService.Update(position);
            return Ok(position);
        }
        [HttpPost("AddPosition")]
        public IActionResult AddPosition(Position position)
        {
            _unitOfWork.PositionService.Add(position);
            return Ok(position);
        }

        [HttpDelete("DeletePosition")]
        public IActionResult DeletePosition(Position position)
        {
            _unitOfWork.PositionService.Delete(position);
            return Ok();
        }
    }
}
