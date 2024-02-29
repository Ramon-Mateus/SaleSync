using SaleSync.API.Contracts;
using SaleSync.API.Entities;

namespace SaleSync.API.UseCases.Auctions.GetCurrent
{
    public class GetCurrentAuctionUseCase
    {
        private readonly IAuctionRepository _repository;

        public GetCurrentAuctionUseCase(IAuctionRepository repository) => _repository = repository;

        public Auction? Execute()
        {
            return _repository.GetCurrent();   
        }
    }
}
