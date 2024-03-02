using SaleSync.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace SaleSync.API.Repositories
{
    public class SaleSyncAuctionEntityDbContext : DbContext
    {
        public SaleSyncAuctionEntityDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Auction> Auctions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Offer> Offers { get; set; }
    }
}
