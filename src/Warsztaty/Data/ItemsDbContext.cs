using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warsztaty.Data.Models;

namespace Warsztaty.Data
{
    public class ItemsDbContext:DbContext
    {
        public DbSet<Item> Items { get; set; }
         public  ItemsDbContext(DbContextOptions<ItemsDbContext> options)
            : base(options)
        {
        }
    }
}
