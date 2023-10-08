using SIMS.Models.Dtos;
using SIMS.Web.Services.Contracts;
using System.Net.Http.Json;

namespace SIMS.Web.Services
{
    public class HodService : IHodService
    {
        private readonly HttpClient httpClient;

        public HodService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<HodDto>> GetHods()
        {
            try
            {
                var hods = await this.httpClient.GetFromJsonAsync<IEnumerable<HodDto>>("api/Hod");
                return hods;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
