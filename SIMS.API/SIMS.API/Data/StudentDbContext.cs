using Microsoft.EntityFrameworkCore;
using SIMS.API.Entities;

namespace SIMS.API.Data
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }
        DbSet<Coordinator> Coordinators {  get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<Faculty> Faculties { get; set;}
        DbSet<HOD> HODs { get; set; }
        DbSet<Mark> Marks { get; set; }
        DbSet<Semester> Semesters { get; set; }
        DbSet<Student> Students { get; set; }
        DbSet<Subject> Subjects { get; set; }
    }
}
