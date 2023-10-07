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
    }
}
