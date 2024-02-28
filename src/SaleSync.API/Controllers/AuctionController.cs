using SaleSync.API.UseCases.Auctions.GetCurrent;
using Microsoft.AspNetCore.Mvc;
using SaleSync.API.Entities;

namespace SaleSync.API.Controllers
{
    public class AuctionController : SaleSyncBaseController
    {
        [HttpGet]
        [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)] // Melhora a documentação do Swagger
        [ProducesResponseType(StatusCodes.Status204NoContent)] // Melhora a documentação do Swagger
        public IActionResult GetCurrentAuction()
        {
            GetCurrentAuctionUseCase useCase = new GetCurrentAuctionUseCase(); // Também funciona assim: var useCase = new GetCurrentAuctionUseCase();

            var result = useCase.Execute();

            if (result is null)
            {
                return NoContent();
            }

            return Ok(result);
        }
    }
}
