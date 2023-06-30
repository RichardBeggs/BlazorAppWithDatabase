using BlazorAppWithDatabase.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppWithDatabase.Data.Database
{
    public class Seed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new PubContext(serviceProvider.GetRequiredService<DbContextOptions<PubContext>>());
            context.Database.EnsureCreated();

            if (!context.Pubs.Any())
            {
                context.Pubs.Add(new Pub { Name = "The Parlour", AddressLine1 = "2-4 Elmwood Ave.", AddressLine2 = "", City = "Belfast" });
                context.Pubs.Add(new Pub { Name = "House Belfast", AddressLine1 = "59-63 Bontanic Ave.", AddressLine2 = "", City = "Belfast" });
                context.Pubs.Add(new Pub { Name = "The Stables at Hilden Brewery", AddressLine1 = "192 Grand St", AddressLine2 = "", City = "Lisburn" });
                context.Pubs.Add(new Pub { Name = "The Three Crowns", AddressLine1 = "21 Bridge St", AddressLine2 = "", City = "Lisburn" });
                context.Pubs.Add(new Pub { Name = "The Bryansburn Inn", AddressLine1 = "151 Bryansburn Road.", AddressLine2 = "", City = "Bangor" });
                context.Pubs.Add(new Pub { Name = "Donegans Restaurant", AddressLine1 = "37-39 High Street.", AddressLine2 = "", City = "Bangor" });
                context.SaveChanges();
            }


        }
    }
}
