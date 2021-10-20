using P2LBookingSystem.API.Models;
using P2LBookingSystem.Models;

namespace P2LBookingSystem.API.Repositories
{
    public class BookingRepository : RepositoryBase<Booking>, IBookingRepository
    {
        public BookingRepository(MyDBContext repositoryContext)
            : base(repositoryContext)
        {

        }
    }
}