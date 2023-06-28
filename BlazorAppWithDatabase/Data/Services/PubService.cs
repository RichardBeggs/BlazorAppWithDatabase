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
            /*
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new Pub
            {
                Id = index,
                Name = $"Pub {index}",
                AddressLine1 = $"Address Line 1 {index}",
                AddressLine2 = $"Address Line 2 {index}",
            }).ToList());*/
        }
    }
}
