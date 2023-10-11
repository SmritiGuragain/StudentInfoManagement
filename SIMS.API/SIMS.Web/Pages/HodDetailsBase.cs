using Microsoft.AspNetCore.Components;
using SIMS.Models.Dtos;
using SIMS.Web.Services.Contracts;

namespace SIMS.Web.Pages
{
    public class HodDetailsBase:ComponentBase
    {
        [Parameter]
        public int Id { get; set; }
        [Inject]
        public IHodService HodService { get; set; }
        public HodDto? Hod { get; set; }
        public string? ErrorMessage { get; set; }
        protected override async Task OnInitializedAsync()
        {
            try
            {
                Hod = await HodService.GetHod(Id);
            }
            catch (Exception ex)
            {

                ErrorMessage = ex.Message;
            }
        }
    }
}
