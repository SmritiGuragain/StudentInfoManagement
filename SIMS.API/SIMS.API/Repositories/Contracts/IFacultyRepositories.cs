using SIMS.API.Entities;

namespace SIMS.API.Repositories.Contracts
{
    public interface IFacultyRepositories
    {
        Task<IEnumerable<Faculty>> GetFaculties();
        Task<IEnumerable<Department>> GetDepartments();
        Task<IEnumerable<Faculty>> GetFaculty(int Id);
        Task<IEnumerable<Department>> GetDepartment(int Id);
    }
}
