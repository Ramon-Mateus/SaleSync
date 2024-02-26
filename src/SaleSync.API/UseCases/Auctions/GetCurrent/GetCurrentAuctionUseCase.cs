using SaleSync.API.Entities;
using SaleSync.API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace SaleSync.API.UseCases.Auctions.GetCurrent
{
    public class GetCurrentAuctionUseCase
    {
        public Auction? Execute() // o ponto de interrogação diz que pode ser retornado um nulo
        {
            var repository = new SaleSyncAuctionEntityDbContext();

            var today = DateTime.Now; // new DateTime(2024, 05, 01);

            return repository
                .Auctions
                .Include(auction => auction.Items)
                .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
        }
    }
}
