using Microsoft.AspNetCore.Mvc;
using SaleSync.API.Communication.Requests;

namespace SaleSync.API.Controllers
{
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
