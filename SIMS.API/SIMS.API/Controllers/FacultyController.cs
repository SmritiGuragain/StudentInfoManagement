using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIMS.API.Extensions;
using SIMS.API.Repositories.Contracts;
using SIMS.Models.Dtos;

namespace SIMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacultyController : ControllerBase
    {
        private readonly IFacultyRepositories facultyRepositories;
        public FacultyController(IFacultyRepositories facultyRepositories)
        {
            this.facultyRepositories = facultyRepositories;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FacultyDto>>> GetFaculties()
        {
            try
            {
                var faculties = await this.facultyRepositories.GetFaculties();
                var departments=await this.facultyRepositories.GetDepartments();

                if (faculties == null || departments == null)
                {
                    return NotFound();
                }
                else
                {
                    var facultyDto = faculties.ConvertToDto(departments);
                    return Ok(facultyDto);
                }

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
}
