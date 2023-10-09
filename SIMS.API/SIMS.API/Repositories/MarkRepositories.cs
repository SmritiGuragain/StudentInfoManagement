using Microsoft.EntityFrameworkCore;
using SIMS.API.Data;
using SIMS.API.Entities;
using SIMS.API.Repositories.Contracts;

namespace SIMS.API.Repositories
{
    public class MarkRepositories : IMarkRepositories
    {
        public readonly StudentDbContext studentDbContext;
        public MarkRepositories(StudentDbContext studentDbContext)
        {
            this.studentDbContext = studentDbContext;
            
        }
        public Task<IEnumerable<Mark>> GetMark(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Mark>> GetMarks()
        {
            var marks = await this.studentDbContext.Marks.ToListAsync();
            return marks;
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

        public Task<IEnumerable<Subject>> GetSubject(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Subject>> GetSubjects()
        {
            var subjects=await this.studentDbContext.Subjects.ToListAsync();
            return subjects;
        }
    }
}
