using SaleSync.API.Entities;

namespace SaleSync.API.Contracts
{
    public interface IAuctionRepository
    {
        Auction? GetCurrent();
    }
}
