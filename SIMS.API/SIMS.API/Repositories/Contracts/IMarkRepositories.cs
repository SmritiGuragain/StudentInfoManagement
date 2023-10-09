using SIMS.API.Entities;

namespace SIMS.API.Repositories.Contracts
{
    public interface IMarkRepositories
    {
        Task<IEnumerable<Student>> GetStudents();
        Task<IEnumerable<Semester>> GetSemesters();
        Task<IEnumerable<Subject>> GetSubjects();
        Task<IEnumerable<Mark>> GetMarks();

        Task<IEnumerable<Student>> GetStudent(int id);
        Task<IEnumerable<Semester>> GetSemester(int id);
        Task<IEnumerable<Subject>> GetSubject(int id);
        Task<IEnumerable<Mark>> GetMark(int id);
    }
}
