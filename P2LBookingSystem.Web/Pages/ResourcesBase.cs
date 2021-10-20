using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using P2LBookingSystem.Models;
using P2LBookingSystem.Web.Services;

namespace P2LBookingSystem.Web.Pages
{
    public class ResourcesBase : ComponentBase
    {
        [Inject] public IResourceService ResourceService { get; set; }
        [Inject] private NavigationManager NavigationManager { get; set; }
        public IList<Resource> Resources { get; set; }
        //public IList<Resource> ResourcesToShow { get; set; }
        public bool BookDialogOpen { get; set; }
        protected Resource _resourceToBook;

        protected override async Task OnInitializedAsync()
        {
            Resources = (await ResourceService.GetResources()).ToList();
            //ResourcesToShow = Resources;
        }

        protected void OnBookDialogClose(bool accepted)
        {
            if (accepted)
            {
                _resourceToBook = null;
            }
            BookDialogOpen = false;
            StateHasChanged();
        }

        protected void OpenBookDialog(Resource resource)
        {
            _resourceToBook = resource;
            BookDialogOpen = true;
            StateHasChanged();
        }

        protected async Task RemoveResource(int Id)
        {
            Resource toRemove = Resources.First(r => r.Id == Id);
            await ResourceService.DeleteResource(Id);
            Resources.Remove(toRemove);
        }

        protected void Edit(int id)
        {
            NavigationManager.NavigateTo($"/Update/{id}");
        }
    }
}