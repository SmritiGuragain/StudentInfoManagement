using Microsoft.EntityFrameworkCore;
using SIMS.API.Entities;

namespace SIMS.API.Data
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }
        public DbSet<Coordinator> Coordinators {  get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Faculty> Faculties { get; set;}
        public DbSet<HOD> HODs { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
