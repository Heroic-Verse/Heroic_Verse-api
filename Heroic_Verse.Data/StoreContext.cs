using Heroic.Verse.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Heroic_Verse.Data
{
public class StoreContext : DbContext
{
    public StoreContext(DbContextOptions<StoreContext> options)
        : base(options)
    {}    

    public DbSet<Item> Items { get; set;}
  }
}
