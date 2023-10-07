using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIMS.API.Extensions;
using SIMS.API.Repositories.Contracts;
using SIMS.Models.Dtos;

namespace SIMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HodController : ControllerBase
    {
        private readonly IHodRepositories hodRepositories;

        public HodController(IHodRepositories hodRepositories)
        {
            this.hodRepositories = hodRepositories;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HodDto>>> GetHods()
        {
            try
            {
                var hods = await this.hodRepositories.GetHods();
                var departments = await this.hodRepositories.GetDepartments();

                if (hods == null || departments == null)
                {
                    return NotFound();
                }
                else
                {
                    var hodDto = hods.ConvertToDto(departments);
                    return Ok(hodDto);
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
