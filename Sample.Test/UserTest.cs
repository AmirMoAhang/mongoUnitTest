using System.Threading.Tasks;
using MongoDB.Driver;
using Moq;
using Sample.Data.Context;
using Sample.Data.Entities;
using Sample.Data.Repository;
using Xunit;

namespace Sample.Test
{
    public class UserTest
    {
        private readonly Mock<MongoContext> _contextMock;
        private readonly Mock<BaseRepository<User>> _repoMock;

        public UserTest()
        {
            _contextMock = new Mock<MongoContext>();
            _repoMock = new Mock<BaseRepository<User>>(_contextMock.Object);
        }

        [Fact]
        public async Task Test1()
        {
            var user = new User
            {
                Name = "None"
            };
            await _repoMock.Object.Create(user);

            Assert.True(true);
        }
    }
}
