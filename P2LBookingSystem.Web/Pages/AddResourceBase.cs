using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using P2LBookingSystem.Models;
using P2LBookingSystem.Web.Services;

namespace P2LBookingSystem.Web.Pages
{
    public class AddResourceBase : ComponentBase
    {
        [Inject] public IResourceService ResourceService { get; set; }
        [Inject] public NavigationManager NavigationManager { get; set; }
        public IEnumerable<Resource> Resources { get; set; }
        public Resource newResource = new Resource();

        protected override async Task OnInitializedAsync()
        {
            Resources = (await ResourceService.GetResources()).ToList();
        }
        protected void AddNewResource()
        {
            int max = Resources.Max(r => r.Id);
            newResource.Id = (++max);
            ResourceService.CreateResource(newResource);
            NavigationManager.NavigateTo("/");
        }
    }
}