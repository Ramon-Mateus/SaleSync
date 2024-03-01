using SaleSync.API.Entities;

namespace SaleSync.API.Contracts
{
    public interface IOfferRepository
    {
        void add(Offer offer);
    }
}
