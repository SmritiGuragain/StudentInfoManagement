using SIMS.API.Entities;

namespace SIMS.API.Repositories.Contracts
{
    public interface ICoordinatorRepositories
    {
        Task<IEnumerable<Faculty>> GetFaculties();
        Task<IEnumerable<Coordinator>> GetCoordinators();
        Task<IEnumerable<Faculty>> GetFaculty(int Id);
        Task<IEnumerable<Coordinator>> GetCoordinator(int Id);
    }
}
