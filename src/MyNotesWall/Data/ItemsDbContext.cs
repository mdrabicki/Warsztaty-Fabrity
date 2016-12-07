using Microsoft.EntityFrameworkCore;
using MyNotesWall.Models;

namespace MyNotesWall.Data
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
