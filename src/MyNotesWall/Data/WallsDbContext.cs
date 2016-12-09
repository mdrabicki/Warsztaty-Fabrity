using Microsoft.EntityFrameworkCore;
using MyNotesWall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyNotesWall.Data
{
    public class WallsDbContext : DbContext
    {
        public virtual DbSet<Wall> Walls { get; set; }
        public  WallsDbContext(DbContextOptions<WallsDbContext> options)
            : base(options)
        {

        }
        public void OnOnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Wall>()
                .HasMany(s => s.Items)
                .WithOne(s => s.Wall)
                .HasForeignKey(s => s.Wall);
            builder.Entity<Wall>()
                .HasMany(s => s.UsersWithAccess);
                
        }
    }
}
