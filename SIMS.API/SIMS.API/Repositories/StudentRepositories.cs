using Microsoft.EntityFrameworkCore;
using SIMS.API.Data;
using SIMS.API.Entities;
using SIMS.API.Repositories.Contracts;

namespace SIMS.API.Repositories
{
    public class StudentRepositories : IStudentRepositories
    {
        private readonly StudentDbContext studentDbContext;
        public StudentRepositories(StudentDbContext studentDbContext)
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
            var semesters=await this.studentDbContext.Semesters.ToListAsync();
            return semesters;
        }

        public Task<IEnumerable<Student>> GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            var students=await this.studentDbContext.Students.ToListAsync();
            return students;
        }
    }
}
