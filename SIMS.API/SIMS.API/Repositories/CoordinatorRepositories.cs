using Microsoft.EntityFrameworkCore;
using SIMS.API.Data;
using SIMS.API.Entities;
using SIMS.API.Repositories.Contracts;

namespace SIMS.API.Repositories
{
    public class CoordinatorRepositories : ICoordinatorRepositories
    {
        private readonly StudentDbContext studentDbContext;
        public CoordinatorRepositories(StudentDbContext studentDbContext)
        {
            this.studentDbContext = studentDbContext;
        }
        public Task<IEnumerable<Coordinator>> GetCoordinator(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Coordinator>> GetCoordinators()
        {
            var coordinators = await this.studentDbContext.Coordinators.ToListAsync();
            return coordinators;
        }

        public async Task<IEnumerable<Faculty>> GetFaculties()
        {
            var faculties = await this.studentDbContext.Faculties.ToArrayAsync();
            return faculties;
        }

        public Task<IEnumerable<Faculty>> GetFaculty(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
