using Microsoft.AspNetCore.Components;
using SIMS.Models.Dtos;
using SIMS.Web.Services.Contracts;

namespace SIMS.Web.Pages
{
    public class HodBase : ComponentBase
    {
        [Inject]
        public IHodService? HodService { get; set; }
        public IEnumerable<HodDto>? Hods { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Hods = await HodService.GetHods();
        }
    }
}
