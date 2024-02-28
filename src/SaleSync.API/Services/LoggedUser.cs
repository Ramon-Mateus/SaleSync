using SaleSync.API.Entities;
using SaleSync.API.Repositories;

namespace SaleSync.API.Services
{
    public class LoggedUser
    {
        private readonly IHttpContextAccessor _httpContextAcessor;

        public LoggedUser(IHttpContextAccessor httpContext) 
        {
            _httpContextAcessor = httpContext;
        }

        public User User()
        {
            var repository = new SaleSyncAuctionEntityDbContext();

            var token = TokenOnRequest();

            var email = FromBase64String(token);

            return repository.Users.First(user => user.Email.Equals(email));
        }

        private string TokenOnRequest(  )
        {
            var authentication = _httpContextAcessor.HttpContext!.Request.Headers.Authorization.ToString();

            return authentication["Bearer ".Length..];
        }

        private string FromBase64String(string base64)
        {
            var data = Convert.FromBase64String(base64);

            return System.Text.Encoding.UTF8.GetString(data);
        }
    }
}
