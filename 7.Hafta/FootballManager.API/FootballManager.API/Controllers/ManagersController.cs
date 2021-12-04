using FootballManager.API.Entities;
using FootballManager.API.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FootballManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ManagersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("GetManagers")]
        public async Task<ActionResult<IEnumerable<Manager>>> GetManagers()
        {
            var managers = await _unitOfWork.ManagerService.GetAllAsync();
            return Ok(managers);
        }

        [HttpGet("GetManager/{id}")]
        public async Task<ActionResult<Manager>> GetManager(int id)
        {
            var manager = await _unitOfWork.ManagerService.GetAsync(id);
            return Ok(manager);
        }

        [HttpPut("UpdateManager")]
        public IActionResult UpdateManager(Manager manager)
        {
            _unitOfWork.ManagerService.Update(manager);
            return Ok(manager);
        }
        [HttpPost("AddManager")]
        public IActionResult AddManager(Manager manager)
        {
            _unitOfWork.ManagerService.Add(manager);
            return Ok(manager);
        }

        [HttpDelete("DeleteManager")]
        public IActionResult DeleteManager(Manager manager)
        {
            _unitOfWork.ManagerService.Delete(manager);
            return Ok();
        }
    }
}
