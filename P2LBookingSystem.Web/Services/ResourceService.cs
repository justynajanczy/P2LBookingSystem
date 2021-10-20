using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Security;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using P2LBookingSystem.Models;

namespace P2LBookingSystem.Web.Services
{
    public class ResourceService : IResourceService
    {
        private readonly HttpClient _httpClient;
        
        public ResourceService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Resource>> GetResources()
        {
            return await _httpClient.GetJsonAsync<Resource[]>("resources");
        }

        public async Task<Resource> GetResource(int id)
        {
            return await _httpClient.GetFromJsonAsync<Resource>($"resources/{id}");
        }

        public async Task<ActionResult<Resource>> UpdateResource(Resource resource)
        {
            return await _httpClient.PutJsonAsync<Resource>("resources", resource);
        }

        public async Task<ActionResult<Resource>> CreateResource(Resource resource)
        {
            return await _httpClient.PostJsonAsync<Resource>("resources", resource);
        }

        public async Task DeleteResource(int id)
        {
            await _httpClient.DeleteAsync($"resources/{id}");
        }
    }
}