using System.Threading.Tasks;
using Sample.Data.Entities;
using Sample.Data.Repository;

namespace Sample.Data.Services
{
    public class UserService : IUserService
    {
        private readonly IBaseRepository<User> _userDb;

        public UserService(IBaseRepository<User> userDb)
        {
            _userDb = userDb;
        }

        public async Task InsertUser()
        {
            var user = new User
            {
                Name = "amir"
            };
            await _userDb.Create(user);
        }
    }
}