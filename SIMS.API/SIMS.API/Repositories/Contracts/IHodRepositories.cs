using SIMS.API.Entities;

namespace SIMS.API.Repositories.Contracts
{
    public interface IHodRepositories
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<IEnumerable<HOD>> GetHods();
        Task<Department> GetDepartment(int id);
        Task<HOD> GetHod(int id);
    }
}
