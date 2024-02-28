using SaleSync.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace SaleSync.API.Repositories
{
    public class SaleSyncAuctionEntityDbContext : DbContext
    {
        public DbSet<Auction> Auctions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=D:\Cursos\NLW Expert\C#\leilaoDbNLW.db");
        }
    }
}
