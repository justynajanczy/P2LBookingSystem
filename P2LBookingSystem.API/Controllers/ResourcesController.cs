using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using P2LBookingSystem.API.Repositories;
using P2LBookingSystem.Models;

namespace P2LBookingSystem.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ResourcesController : ControllerBase
    {
        private readonly IResourceRepository _resourceRepository;

        public ResourcesController(IResourceRepository resourceRepository)
        {
            _resourceRepository = resourceRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Resource>> GetResources()
        {
            return await _resourceRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Resource>> GetResources(int id)
        {
            return await _resourceRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Resource>> PostResources(Resource resource)
        {
            var newResource = await _resourceRepository.Create(resource);
            return CreatedAtAction(nameof(GetResources), new { id = newResource.Id }, newResource);
        }

        [HttpPut]
        public async Task<ActionResult> PutResources(Resource resource)
        {
            await _resourceRepository.Update(resource);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Resource>> DeleteResource (int id)
        {
            var resourceToDelete = await _resourceRepository.Get(id);
            if(resourceToDelete == null)
            {
                return NotFound($"Resource with Id = {id} not found");
            }

            return await _resourceRepository.Delete(id);
        }
    }
}