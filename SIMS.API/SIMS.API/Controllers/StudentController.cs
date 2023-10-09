using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIMS.API.Extensions;
using SIMS.API.Repositories.Contracts;
using SIMS.Models.Dtos;

namespace SIMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public readonly IStudentRepositories studentRepositories;
        public StudentController(IStudentRepositories studentRepositories)
        {
            this.studentRepositories = studentRepositories;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentDto>>> GetStudents()
        {
            try
            {
                var faculties = await this.studentRepositories.GetFaculties();
                var semesters = await this.studentRepositories.GetSemesters();
                var students = await this.studentRepositories.GetStudents();

                if (faculties == null || semesters == null || students == null)
                {
                    return NotFound();
                }
                else
                {
                    var subjectDto = students.ConvertToDto(semesters, faculties);
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
