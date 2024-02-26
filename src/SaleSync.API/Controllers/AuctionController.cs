using SaleSync.API.UseCases.Auctions.GetCurrent;
using Microsoft.AspNetCore.Mvc;

namespace SaleSync.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuctionController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCurrentAuction()
        {
            GetCurrentAuctionUseCase useCase = new GetCurrentAuctionUseCase(); // Também funciona assim: var useCase = new GetCurrentAuctionUseCase();

            var result = useCase.Execute();

            return Ok(result);
        }
    }
}
