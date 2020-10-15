using Microsoft.EntityFrameworkCore;
using System;
using P4ProjectApi.Domain;

namespace P4ProjectApi.Data
{
    public class P4Context : DbContext
    {
        public P4Context(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserChat> UserChats { get; set; }
        public DbSet<UserInventory> UserInventories { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<UserStat> UserStats { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
               "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = P4ProjectApi");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ////modelBuilder.Entity<OrderStatus>().HasKey(k => new { k.StatusId });
        }
    }
    
    
}
    