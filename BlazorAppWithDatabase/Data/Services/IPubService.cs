using BlazorAppWithDatabase.Data.Models;

namespace BlazorAppWithDatabase.Data.Services
{
    public interface IPubService
    {
        void DeletePub(Pub pub);

        void UpdatePub(Pub pub);

        Task<List<Pub>> GetPubsAsync();

        Task<List<Pub>> GetPubsAsync(string cityFilter);
    }
}