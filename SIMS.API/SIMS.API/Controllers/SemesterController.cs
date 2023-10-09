using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIMS.API.Extensions;
using SIMS.API.Repositories.Contracts;
using SIMS.Models.Dtos;

namespace SIMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SemesterController : ControllerBase
    {
        private readonly ISemesterRepositories SemesterRepositories;
        public SemesterController(ISemesterRepositories SemesterRepositories)
        {
            this.SemesterRepositories = SemesterRepositories;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SemesterDto>>> GetSemesters()
        {
            try
            {
                var faculties = await this.SemesterRepositories.GetFaculties();
                var semesters = await this.SemesterRepositories.GetSemesters();

                if (faculties == null || semesters == null)
                {
                    return NotFound();
                }
                else
                {
                    var semesterDto = semesters.ConvertToDto(faculties);
                    return Ok(semesterDto);
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
