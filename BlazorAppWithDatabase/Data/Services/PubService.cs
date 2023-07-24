using BlazorAppWithDatabase.Data.Database;
using BlazorAppWithDatabase.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppWithDatabase.Data.Services
{
    public class PubService : IPubService
    {
        private readonly PubContext _context;
        public PubService(PubContext context)
        {
            _context = context;
        }
        public Task<List<Pub>> GetPubsAsync()
        {
            var pubs = _context.Pubs.ToListAsync();
            return pubs;
        }

        public Task<List<Pub>> GetPubsAsync(string cityFilter)
        {
            var pubs = _context.Pubs.Where(x=>x.City==cityFilter).ToListAsync();
            return pubs;
        }
    }
}
