using SaleSync.API.Entities;
using SaleSync.API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace SaleSync.API.UseCases.Auctions.GetCurrent
{
    public class GetCurrentAuctionUseCase
    {
        public Auction Execute()
        {
            var repository = new SaleSyncAuctionEntityDbContext();

            return repository
                .Auctions
                .Include(auction => auction.Items)
                .First();
        }
    }
}
