using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Warsztaty.Models.DbEntities
{
    public partial class WarsztatyContext : DbContext
    {
        public virtual DbSet<Items> Items { get; set; }

        // Unable to generate entity type for table 'dbo.Testty'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server = DESKTOP-QM9LQEE\SQLEXPRESS; Database = Warsztaty; Trusted_Connection = True; ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}