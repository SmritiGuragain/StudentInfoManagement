using Microsoft.EntityFrameworkCore;
using SIMS.API.Data;
using SIMS.API.Entities;
using SIMS.API.Repositories.Contracts;

namespace SIMS.API.Repositories
{
    public class FacultyRepositories : IFacultyRepositories
    {
        private readonly StudentDbContext studentDbContext;
        public FacultyRepositories(StudentDbContext studentDbContext)
        {
            this.studentDbContext = studentDbContext;
        }
        public Task<IEnumerable<Department>> GetDepartment(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            var departments=await this.studentDbContext.Departments.ToListAsync();
            return departments;
        }

        public async Task<IEnumerable<Faculty>> GetFaculties()
        {
            var faculties = await this.studentDbContext.Faculties.ToListAsync();
            return faculties;
        }

        public Task<IEnumerable<Faculty>> GetFaculty(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
