using BlazorAppWithDatabase.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppWithDatabase.Data.Database
{
    public class PubContext :DbContext
    {
        public PubContext(DbContextOptions<PubContext> options) : base(options)
        {
        }

        public DbSet<Pub> Pubs { get; set; }
    }
}
