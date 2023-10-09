using SIMS.API.Entities;
using System.Threading.Tasks;

namespace SIMS.API.Repositories.Contracts
{
    public interface ISubjectRepositories
    {
        Task<IEnumerable<Faculty>> GetFaculties();
        Task<IEnumerable<Semester>> GetSemesters();
        Task<IEnumerable<Faculty>> GetFaculty(int id);
        Task<IEnumerable<Semester>> GetSemester(int id);
        Task<IEnumerable<Subject>> GetSubjects();
        Task<IEnumerable<Subject>> GetSubject(int id);

    }
}
