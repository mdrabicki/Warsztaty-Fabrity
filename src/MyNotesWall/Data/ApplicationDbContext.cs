using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyNotesWall.Models;


namespace MyNotesWall.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual DbSet<Wall> Walls { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<UserWallItem> UserWallItems { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            
          // builder.Entity<UserWallItem>()
             //  .HasKey(x => new {x.WallId, x.ItemId, x.UserId });
            /*     builder.Entity<ApplicationUser>()
                     .HasMany(x => x.UserWallItems)
                     .WithOne(x=>x.User)
                     .IsRequired(false);
                 builder.Entity<Wall>()
                     .HasMany(x => x.UserWallItems)
                     .WithOne(x=>x.Wall)
                     .IsRequired(false);
                 builder.Entity<Item>()
                      .HasMany(x => x.UserWallItems)
                      .WithOne(x => x.Item)
                      .IsRequired(false);
                 builder.Entity<UserWallItem>()
                     .HasMany(x => x.Walls)
                     .WithOne(x=>x.UserWallItem)
                     .IsRequired(false);
                 builder.Entity<UserWallItem>()
                     .HasMany(x => x.Items)
                     .WithOne(x=>x.UserWallItem)
                     .IsRequired(false);
                 builder.Entity<UserWallItem>()
                     .HasMany(x => x.Users)
                     .WithOne(x=>x.UserWallItem)
                     .IsRequired(false);
                */


        }
    }
}
