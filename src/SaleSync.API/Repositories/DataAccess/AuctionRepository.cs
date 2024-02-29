using Microsoft.EntityFrameworkCore;
using SaleSync.API.Contracts;
using SaleSync.API.Entities;

namespace SaleSync.API.Repositories.DataAccess
{
    public class AuctionRepository : IAuctionRepository
    {
        private readonly SaleSyncAuctionEntityDbContext _dbContext;

        public AuctionRepository(SaleSyncAuctionEntityDbContext dbContext) => _dbContext = dbContext;

        public Auction? GetCurrent() // o ponto de interrogação diz que pode ser retornado um nulo
        {
            var today = DateTime.Now; // new DateTime(2024, 05, 01);

            return _dbContext
                .Auctions
                .Include(auction => auction.Items)
                .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
        }

    }
}
