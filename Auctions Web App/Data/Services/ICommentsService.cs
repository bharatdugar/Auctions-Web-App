using Auctions_Web_App.Models;

namespace Auctions_Web_App.Data.Services
{
    public interface ICommentsService
    {
        Task Add(Comment comment);
    }
}
