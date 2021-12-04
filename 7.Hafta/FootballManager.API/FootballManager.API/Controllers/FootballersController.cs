using FootballManager.API.Entities;
using FootballManager.API.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace FootballManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public FootballersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("GetFootballers")]
        public async Task<ActionResult<IEnumerable<Coach>>> GetFootballers()
        {
            var footballers = await _unitOfWork.FootballerService.GetAllAsync();
            return Ok(footballers);
        }

        [HttpGet("GetFootballer/{id}")]
        public async Task<ActionResult<Team>> GetFootballer(int id)
        {
            var footballer = await _unitOfWork.FootballerService.GetAsync(id);
            return Ok(footballer);
        }

        [HttpPut("UpdateFootballer")]
        public IActionResult UpdateFootballer(Footballer footballer)
        {
            _unitOfWork.FootballerService.Update(footballer);
            return Ok(footballer);
        }
        [HttpPost("AddFootballer")]
        public IActionResult AddFootballer(Footballer footballer)
        {
            _unitOfWork.FootballerService.Add(footballer);
            return Ok(footballer);
        }

        [HttpDelete("DeleteFootballer")]
        public IActionResult DeleteFootballer(Footballer footballer)
        {
            _unitOfWork.FootballerService.Delete(footballer);
            return Ok();
        }
    }
}
