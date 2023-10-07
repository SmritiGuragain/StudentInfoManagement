using SIMS.API.Entities;

namespace SIMS.API.Repositories.Contracts
{
    public interface IHodRepositories
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<IEnumerable<HOD>> GetHods();
        Task<IEnumerable<Department>> GetDepartment(int id);
        Task<IEnumerable<HOD>> GetHod(int id);
    }
}
