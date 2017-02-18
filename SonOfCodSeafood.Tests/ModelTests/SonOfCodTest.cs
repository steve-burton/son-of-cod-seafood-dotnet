using SonOfCodSeafood.Models;
using Xunit;

namespace SonOfCodSeafood.Tests
{
    public class SonOfCodTest
    {
        [Fact]
        public void GetMailingListTest()
        {
            //Arrange
            var user = new PublicUser();
            user.Email = "bobfrapples@gmail.com";

            //Act
            var result = user.Email;

            //Assert
            Assert.Equal("bobfrapples@gmail.com", result);
        }
    }
}
