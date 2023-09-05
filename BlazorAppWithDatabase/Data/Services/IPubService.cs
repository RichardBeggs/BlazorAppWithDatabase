using BlazorAppWithDatabase.Data.Models;

namespace BlazorAppWithDatabase.Data.Services
{
    public interface IPubService
    {
        void DeletePub(Pub pub);

        void UpdatePub(Pub pub);

        Task<List<Pub>> GetPubsAsync();

        Task<Pub> GetPubAsync(int id);

        Task<List<Pub>> GetPubsAsync(string cityFilter);
    }
}