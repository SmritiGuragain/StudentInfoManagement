using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIMS.API.Extensions;
using SIMS.API.Repositories.Contracts;
using SIMS.Models.Dtos;

namespace SIMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectRepositories SubjectRepositories;
        public SubjectController(ISubjectRepositories SubjectRepositories)
        {
            this.SubjectRepositories = SubjectRepositories;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubjectDto>>> GetSubjects()
        {
            try
            {
                var faculties = await this.SubjectRepositories.GetFaculties();
                var semesters = await this.SubjectRepositories.GetSemesters();
                var subjects = await this.SubjectRepositories.GetSubjects();

                if (faculties == null || semesters == null || subjects == null)
                {
                    return NotFound();
                }
                else
                {
                    var subjectDto = subjects.ConvertToDto(semesters, faculties);
                    return Ok(subjectDto);
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

