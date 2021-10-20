using System.Threading.Tasks;
using P2LBookingSystem.API.Models;
using P2LBookingSystem.Models;

namespace P2LBookingSystem.API.Repositories
{
    public class ResourceRepository : RepositoryBase<Resource>, IResourceRepository
    {
        public ResourceRepository(MyDBContext repositoryContext)
            :base(repositoryContext)
        {

        }
    }
}