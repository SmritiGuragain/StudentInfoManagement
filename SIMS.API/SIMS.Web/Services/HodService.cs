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

        public async Task<HodDto> GetHod(int id)
        {
            try
            {
                var response = await httpClient.GetAsync($"api/Hod/{id}");
                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(HodDto);
                    }
                    return await response.Content.ReadFromJsonAsync<HodDto>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<HodDto>> GetHods()
        {
            try
            {
                var response = await this.httpClient.GetAsync("api/Hod");
                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<HodDto>();
                    }
                    return await response.Content.ReadFromJsonAsync<IEnumerable<HodDto>>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
