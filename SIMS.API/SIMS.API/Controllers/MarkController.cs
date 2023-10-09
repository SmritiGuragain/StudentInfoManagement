using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIMS.API.Extensions;
using SIMS.API.Repositories.Contracts;
using SIMS.Models.Dtos;

namespace SIMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarkController : ControllerBase
    {
        public readonly IMarkRepositories markRepositories;
        public MarkController(IMarkRepositories markRepositories)
        {
            this.markRepositories = markRepositories;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubjectDto>>> GetSubjects()
        {
            try
            {
                var students = await this.markRepositories.GetStudents();
                var semesters = await this.markRepositories.GetSemesters();
                var subjects = await this.markRepositories.GetSubjects();
                var marks = await this.markRepositories.GetMarks();

                if (students == null || semesters == null || subjects == null || marks==null)
                {
                    return NotFound();
                }
                else
                {
                    var markDto = marks.ConvertToDto(students,semesters, subjects);
                    return Ok(markDto);
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
