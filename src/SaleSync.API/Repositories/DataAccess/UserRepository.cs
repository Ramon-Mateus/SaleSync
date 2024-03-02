using SaleSync.API.Contracts;
using SaleSync.API.Entities;

namespace SaleSync.API.Repositories.DataAccess
{
    public class UserRepository : IUserRepository
    {
        private readonly SaleSyncAuctionEntityDbContext _dbContext;

        public UserRepository(SaleSyncAuctionEntityDbContext dbContext) => _dbContext = dbContext;

        public bool ExistUserWithEmail(string email)
        {
            return _dbContext.Users.Any(user => user.Email.Equals(email));
        }

        public User GetUserByEmail(string email) => _dbContext.Users.First(user => user.Email.Equals(email));
    }
}
