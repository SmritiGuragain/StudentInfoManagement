using SIMS.API.Entities;

namespace SIMS.API.Repositories.Contracts
{
    public interface ISemesterRepositories
    {
        Task<IEnumerable<Faculty>> GetFaculties();
        Task<IEnumerable<Semester>> GetSemesters();
        Task<IEnumerable<Faculty>> GetFaculty(int id);
        Task<IEnumerable<Semester>> GetSemester(int id);
    }
}
