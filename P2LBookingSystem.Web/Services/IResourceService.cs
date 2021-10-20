using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using P2LBookingSystem.Models;

namespace P2LBookingSystem.Web.Services
{
    public interface IResourceService
    {
        Task<IEnumerable<Resource>> GetResources();
        Task<Resource> GetResource(int id);
        Task<ActionResult<Resource>> UpdateResource(Resource resource);
        Task<ActionResult<Resource>> CreateResource(Resource resource);
        Task DeleteResource(int id);
    }
}