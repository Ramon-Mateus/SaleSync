using SaleSync.API.Contracts;
using SaleSync.API.Entities;

namespace SaleSync.API.Repositories.DataAccess
{
    public class OfferRepository : IOfferRepository
    {
        private readonly SaleSyncAuctionEntityDbContext _dbContext;

        public OfferRepository(SaleSyncAuctionEntityDbContext dbContext) => _dbContext = dbContext;

        public void add(Offer offer)
        {
            _dbContext.Offers.Add(offer);

            _dbContext.SaveChanges();
        }
    }
}
