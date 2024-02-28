using Microsoft.AspNetCore.Mvc;
using SaleSync.API.Communication.Requests;
using SaleSync.API.Filters;
using SaleSync.API.UseCases.Offers.CreateOffer;

namespace SaleSync.API.Controllers
{
    [ServiceFilter(typeof(AuthenticationUserAttribute))]
    public class OfferController : SaleSyncBaseController
    {
        [HttpPost]
        [Route("{itemId}")]
        public IActionResult CreateOffer(
            [FromRoute] int itemId,
            [FromBody] RequestCreateOfferJson request,
            [FromServices] CreateOfferUseCase useCase)
        {
            var id = useCase.Execute(itemId, request);

            return Created(string.Empty, id);
        }
    }
}
