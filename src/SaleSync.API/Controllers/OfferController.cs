using Microsoft.AspNetCore.Mvc;
using SaleSync.API.Communication.Requests;
using SaleSync.API.Filters;

namespace SaleSync.API.Controllers
{
    [ServiceFilter(typeof(AuthenticationUserAttribute))]
    public class OfferController : SaleSyncBaseController
    {
        [HttpPost]
        [Route("{itemId}")]
        public IActionResult CreateOffer([FromRoute] int itemId, [FromBody] RequestCreateOfferJson request)
        {
            return Created();
        }
    }
}
