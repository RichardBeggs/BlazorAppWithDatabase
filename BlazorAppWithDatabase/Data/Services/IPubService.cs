using BlazorAppWithDatabase.Data.Models;

namespace BlazorAppWithDatabase.Data.Services
{
    public interface IPubService
    {
        Task<List<Pub>> GetPubsAsync();

        Task<List<Pub>> GetPubsAsync(string cityFilter);
    }
}