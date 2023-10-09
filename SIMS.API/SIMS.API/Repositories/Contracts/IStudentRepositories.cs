using SIMS.API.Entities;

namespace SIMS.API.Repositories.Contracts
{
    public interface IStudentRepositories
    {
        Task<IEnumerable<Faculty>> GetFaculties();
        Task<IEnumerable<Semester>> GetSemesters();
        Task<IEnumerable<Student>> GetStudents();
        Task<IEnumerable<Faculty>> GetFaculty(int id);
        Task<IEnumerable<Semester>> GetSemester(int id);
        Task<IEnumerable<Student>> GetStudent(int id);
    }
}
