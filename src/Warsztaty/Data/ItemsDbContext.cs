using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warsztaty.Data.Models;

namespace Warsztaty.Data
{
    public partial class ItemsDbContext:DbContext
    {
        public virtual DbSet<Item> Items { get; set; }
        public  ItemsDbContext(DbContextOptions<ItemsDbContext> options)
            : base(options)
        {
            
        }
    }
}
