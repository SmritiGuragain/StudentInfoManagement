using Microsoft.EntityFrameworkCore;
using SIMS.API.Data;
using SIMS.API.Entities;
using SIMS.API.Repositories.Contracts;

namespace SIMS.API.Repositories
{
    public class HodRepositories : IHodRepositories
    {
        private readonly StudentDbContext studentDbContext;

        public HodRepositories(StudentDbContext studentDbContext)
        {
            this.studentDbContext = studentDbContext;
        }
        public Task<IEnumerable<Department>> GetDepartment(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            var departments = await this.studentDbContext.Departments.ToListAsync();
            return departments;
        }

        public Task<IEnumerable<HOD>> GetHod(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<HOD>> GetHods()
        {
            var hods = await this.studentDbContext.HODs.ToListAsync() ;
            return hods ;
        }
    }
}
