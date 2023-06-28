using BlazorAppWithDatabase.Data.Models;

namespace BlazorAppWithDatabase.Data.Services
{
    public interface IPubService
    {
        Task<List<Pub>> GetPubsAsync();
    }
}
