﻿using Heroic.Verse.Domain.Catalog;
using Heroic.Verse.Domain.Orders;
using Heroic_Verse.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Heroic_Verse.Data
{
public class StoreContext : DbContext
{
    public StoreContext(DbContextOptions<StoreContext> options)
        : base(options)
    {}    

    public DbSet<Item> Items { get; set;}

    public DbSet<Orders> Orders {get; set; }

      protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            DbInitializer.Initialize(builder);
        }
    }
}
