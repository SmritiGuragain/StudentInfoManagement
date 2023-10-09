using SIMS.API.Entities;
using SIMS.Models.Dtos;

namespace SIMS.API.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<HodDto> ConvertToDto(this IEnumerable<HOD> hods,
           IEnumerable<Department> departments)
        {
            return (from hod in hods
                    join department in departments
                    on hod.Dept_Id equals department.Id
                    select new HodDto
                    {
                        Id = hod.Id,
                        Name = hod.Name,
                        ImageURL = hod.ImageURL,
                        Email = hod.Email,
                        Phone = hod.Phone,
                        Dept_Id = hod.Dept_Id,
                        Dept_Name = department.Name
                    }).ToList();
        }

        public static IEnumerable<CoordinatorDto> ConvertToDto(this IEnumerable<Coordinator> coordinators,
           IEnumerable<Faculty> faculties)
        {
            return (from coordinator in coordinators
                    join faculty in faculties
                    on coordinator.Fac_Id equals faculty.Id
                    select new CoordinatorDto
                    {
                        Id = coordinator.Id,
                        Name = coordinator.Name,
                        ImageURL =coordinator.ImageURL,
                        Email = coordinator.Email,
                        Phone = coordinator.Phone,
                        Fac_Id = coordinator.Fac_Id,
                        Fac_Name = faculty.Name
                    }).ToList();
        }

        public static IEnumerable<FacultyDto> ConvertToDto(this IEnumerable<Faculty> faculties,
           IEnumerable<Department> departments)
        {
            return (from faculty in faculties
                    join department in departments
                    on faculty.Dep_Id equals department.Id
                    select new FacultyDto
                    {
                        Id = faculty.Id,
                        Name = faculty.Name,
                        Status= faculty.Status,
                        Dep_Id = faculty.Dep_Id,
                        Dep_Name = department.Name
                    }).ToList();
        }
    }
}
