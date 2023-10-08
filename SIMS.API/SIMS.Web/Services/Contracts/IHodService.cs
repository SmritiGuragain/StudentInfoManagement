using SIMS.Models.Dtos;

namespace SIMS.Web.Services.Contracts
{
    public interface IHodService
    {
        Task<IEnumerable<HodDto>> GetHods();
    }
}
