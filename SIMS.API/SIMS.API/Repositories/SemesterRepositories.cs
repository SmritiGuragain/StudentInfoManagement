using Microsoft.EntityFrameworkCore;
using SIMS.API.Data;
using SIMS.API.Entities;
using SIMS.API.Repositories.Contracts;

namespace SIMS.API.Repositories
{
    public class SemesterRepositories : ISemesterRepositories
    {
        private readonly StudentDbContext studentDbContext;
        public SemesterRepositories(StudentDbContext studentDbContext)
        {
            this.studentDbContext = studentDbContext; 
        }
        public async Task<IEnumerable<Faculty>> GetFaculties()
        {
            var faculties=await this.studentDbContext.Faculties.ToListAsync();
            return faculties;
        }

        public Task<IEnumerable<Faculty>> GetFaculty(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Semester>> GetSemester(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Semester>> GetSemesters()
        {
            var semesters= await this.studentDbContext.Semesters.ToListAsync();
            return semesters;
        }
    }
}
