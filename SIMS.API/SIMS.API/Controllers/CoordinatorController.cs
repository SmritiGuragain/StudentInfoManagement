using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIMS.API.Extensions;
using SIMS.API.Repositories.Contracts;
using SIMS.Models.Dtos;

namespace SIMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoordinatorController : ControllerBase
    {
        private readonly ICoordinatorRepositories coordinatorRepositories;
        public CoordinatorController(ICoordinatorRepositories coordinatorRepositories)
        { 
            this.coordinatorRepositories = coordinatorRepositories;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CoordinatorDto>>> GetCoordinators()
        {
            try
            {
                var coordinators = await this.coordinatorRepositories.GetCoordinators();
                var faculties = await this.coordinatorRepositories.GetFaculties();

                if (coordinators == null || faculties == null)
                {
                    return NotFound();
                }
                else
                {
                    var coordinatorDto = coordinators.ConvertToDto(faculties);
                    return Ok(coordinatorDto);
                }

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }

        }
    }
}
