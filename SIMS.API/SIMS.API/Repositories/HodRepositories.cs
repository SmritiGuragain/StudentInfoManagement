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
        public async Task<Department> GetDepartment(int id)
        {
            var category = await studentDbContext.Departments.SingleOrDefaultAsync(c => c.Id == id);
            return category;
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            var departments = await this.studentDbContext.Departments.ToListAsync();
            return departments;
        }

        public async Task<HOD> GetHod(int id)
        {
            var hod = await studentDbContext.HODs.FindAsync(id);
            return hod;
        }

        public async Task<IEnumerable<HOD>> GetHods()
        {
            var hods = await this.studentDbContext.HODs.ToListAsync() ;
            return hods ;
        }
    }
}
