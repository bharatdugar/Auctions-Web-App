using Auctions_Web_App.Models;

namespace Auctions_Web_App.Data.Services
{
    public interface IBidsService
    {
        Task Add(Bid bid);
        IQueryable<Bid> GetAll();   
    }
}
